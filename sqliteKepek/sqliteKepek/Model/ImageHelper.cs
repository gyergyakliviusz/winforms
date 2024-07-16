using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace sqliteKepek.Model
{
    public class ImageHelper
    {
        private dBHelper helper = null;
        private string fileLocation = string.Empty;
        private bool isSucces = false;
        private int maxImageSize = 2097152; // 2MB

        public string FileLocation
        {
            get { return fileLocation; }
            set { fileLocation = value; }
        }

        public Boolean GetSucces()
        {
            return isSucces;
        }

        public Image LoadImage()
        {
            Image image = null;
            OpenFileDialog dlg = new OpenFileDialog
            {
                InitialDirectory = @"C:\\",
                Title = "Select Image File",
                Filter = "Image Files (*.jpg ; *.jpeg ; *.png ; *.gif ; *.tiff ; *.nef)|*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.nef"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileLocation = dlg.FileName;
                FileInfo info = new FileInfo(fileLocation);
                long fileSize = info.Length;
                maxImageSize = (Int32)fileSize;

                if (File.Exists(fileLocation))
                {
                    using (FileStream stream = File.Open(fileLocation, FileMode.Open))
                    {
                        BinaryReader br = new BinaryReader(stream);
                        byte[] data = br.ReadBytes(maxImageSize);
                        image = new Image(dlg.SafeFileName, data, fileSize);
                    }
                }
            }

            return image;
        }

        public int InsertImage()
        {
            DataRow dataRow = null;
            isSucces = false;
            Image image = LoadImage();

            if (image == null) return 0;

            string connectionString = dBFunctions.ConnectionStringSQLite;
            string commandText = "SELECT * FROM ImageStore WHERE 1=0";
            helper = new dBHelper(connectionString);

            if (helper.Load(commandText, "image_id"))
            {
                helper.DataSet.Tables[0].Rows.Add(helper.DataSet.Tables[0].NewRow());
                dataRow = helper.DataSet.Tables[0].Rows[0];

                dataRow["ImageFile"] = image.FileName;
                dataRow["ImageBlob"] = image.ImageData;

                try
                {
                    if (helper.Save())
                    {
                        isSucces = true;
                    }
                    else
                    {
                        isSucces = false;
                        MessageBox.Show("Error during Insertion");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return Convert.ToInt32(dataRow[0].ToString());
        }

        public void DeleteImage(int imageID)
        {
            isSucces = false;
            string connectionString = dBFunctions.ConnectionStringSQLite;
            string commandText = $"SELECT * FROM ImageStore WHERE ImageStore_Id={imageID}";
            helper = new dBHelper(connectionString);

            if (helper.Load(commandText, "image_id"))
            {
                if (helper.DataSet.Tables[0].Rows.Count == 1)
                {
                    helper.DataSet.Tables[0].Rows[0].Delete();

                    try
                    {
                        if (helper.Save())
                        {
                            isSucces = true;
                        }
                        else
                        {
                            isSucces = false;
                            MessageBox.Show("Delete failed");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void SaveAsImage(int imageID)
        {
            DataRow dataRow = null;
            Image image = null;
            isSucces = false;
            SaveFileDialog dlg = new SaveFileDialog
            {
                InitialDirectory = @"C:\\",
                Title = "Save Image File",
                Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.bmp;*.nef)|*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.bmp;*.nef"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filename = dlg.FileName.Trim();
                string connectionString = dBFunctions.ConnectionStringSQLite;
                string commandText = $"SELECT * FROM ImageStore WHERE ImageStore_Id={imageID}";
                helper = new dBHelper(connectionString);

                if (helper.Load(commandText, ""))
                {
                    dataRow = helper.DataSet.Tables[0].Rows[0];
                    image = new Image(
                        (string)dataRow["ImageFile"],
                        (byte[])dataRow["ImageBlob"],
                        (long)dataRow["ImageBlob"].Length
                    );

                    using (FileStream stream = new FileStream(filename, FileMode.Create))
                    {
                        BinaryWriter bw = new BinaryWriter(stream);
                        bw.Write(image.ImageData);
                        isSucces = true;
                    }
                }

                if (isSucces)
                {
                    MessageBox.Show("Save successful");
                }
                else
                {
                    MessageBox.Show("Save failed");
                }
            }
        }
    }
}

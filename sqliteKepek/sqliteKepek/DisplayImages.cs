using sqliteKepek.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqliteKepek
{
    public partial class DisplayImages : Form
    {
        private ImageHelper imageHelper = new ImageHelper();

        public DisplayImages()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            int imageID = imageHelper.InsertImage();
            if (imageHelper.GetSucces())
            {
                LoadImageGrid();
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (dataGridViewImages.SelectedRows.Count > 0)
            {
                int imageID = Convert.ToInt32(dataGridViewImages.SelectedRows[0].Cells[0].Value);
                imageHelper.DeleteImage(imageID);
                if (imageHelper.GetSucces())
                {
                    LoadImageGrid();
                }
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (dataGridViewImages.SelectedRows.Count > 0)
            {
                int imageID = Convert.ToInt32(dataGridViewImages.SelectedRows[0].Cells[0].Value);
                imageHelper.SaveAsImage(imageID);
            }
        }

        private void LoadImageGrid()
        {
            string connectionString = dBFunctions.ConnectionStringSQLite;
            string commandText = "SELECT * FROM ImageStore";
            dBHelper helper = new dBHelper(connectionString);

            if (helper.Load(commandText, "ImageStore"))
            {
                dataGridViewImages.DataSource = helper.DataSet.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

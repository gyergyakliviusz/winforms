namespace uszas
{
    partial class ZaszloForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlKozponti = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlKozponti
            // 
            this.pnlKozponti.Location = new System.Drawing.Point(48, 42);
            this.pnlKozponti.Name = "pnlKozponti";
            this.pnlKozponti.Size = new System.Drawing.Size(708, 371);
            this.pnlKozponti.TabIndex = 0;
            // 
            // ZaszloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlKozponti);
            this.Name = "ZaszloForm";
            this.Text = "ZaszloForm";
            this.Load += new System.EventHandler(this.ZaszloForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKozponti;
    }
}
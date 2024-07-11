namespace uszas
{
    partial class InditoForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versenyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eredmenyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nevjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem,
            this.versenyToolStripMenuItem,
            this.eredmenyToolStripMenuItem,
            this.nevjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitasToolStripMenuItem,
            this.mentesToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fajlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitasToolStripMenuItem
            // 
            this.megnyitasToolStripMenuItem.Name = "megnyitasToolStripMenuItem";
            this.megnyitasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.megnyitasToolStripMenuItem.Text = "Megnyitás";
            // 
            // mentesToolStripMenuItem
            // 
            this.mentesToolStripMenuItem.Name = "mentesToolStripMenuItem";
            this.mentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mentesToolStripMenuItem.Text = "Mentés";
            this.mentesToolStripMenuItem.Click += new System.EventHandler(this.mentesToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // versenyToolStripMenuItem
            // 
            this.versenyToolStripMenuItem.Enabled = false;
            this.versenyToolStripMenuItem.Name = "versenyToolStripMenuItem";
            this.versenyToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.versenyToolStripMenuItem.Text = "Verseny";
            this.versenyToolStripMenuItem.Click += new System.EventHandler(this.versenyToolStripMenuItem_Click);
            // 
            // eredmenyToolStripMenuItem
            // 
            this.eredmenyToolStripMenuItem.Enabled = false;
            this.eredmenyToolStripMenuItem.Name = "eredmenyToolStripMenuItem";
            this.eredmenyToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.eredmenyToolStripMenuItem.Text = "Eredmény";
            this.eredmenyToolStripMenuItem.Click += new System.EventHandler(this.eredmenyToolStripMenuItem_Click);
            // 
            // nevjegyToolStripMenuItem
            // 
            this.nevjegyToolStripMenuItem.Name = "nevjegyToolStripMenuItem";
            this.nevjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.nevjegyToolStripMenuItem.Text = "Névjegy";
            this.nevjegyToolStripMenuItem.Click += new System.EventHandler(this.nevjegyToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InditoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::uszas.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InditoForm";
            this.Text = "InditoForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versenyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eredmenyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nevjegyToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


namespace diakkezeloA
{
    partial class Form1
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
            this.pnlDiakok = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiak = new System.Windows.Forms.Label();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.btnKivalaszt = new System.Windows.Forms.Button();
            this.lstKivalasztottak = new System.Windows.Forms.ListBox();
            this.lstLegidosebbek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pnlDiakok
            // 
            this.pnlDiakok.Location = new System.Drawing.Point(58, 94);
            this.pnlDiakok.Name = "pnlDiakok";
            this.pnlDiakok.Size = new System.Drawing.Size(254, 294);
            this.pnlDiakok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(153, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diákok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(446, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiválasztottak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Legidősebbek:";
            // 
            // lblDiak
            // 
            this.lblDiak.AutoSize = true;
            this.lblDiak.Location = new System.Drawing.Point(373, 414);
            this.lblDiak.Name = "lblDiak";
            this.lblDiak.Size = new System.Drawing.Size(39, 13);
            this.lblDiak.TabIndex = 6;
            this.lblDiak.Text = "lblDiak";
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(58, 409);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 7;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            // 
            // btnKivalaszt
            // 
            this.btnKivalaszt.Location = new System.Drawing.Point(237, 409);
            this.btnKivalaszt.Name = "btnKivalaszt";
            this.btnKivalaszt.Size = new System.Drawing.Size(75, 23);
            this.btnKivalaszt.TabIndex = 8;
            this.btnKivalaszt.Text = "Kiválaszt";
            this.btnKivalaszt.UseVisualStyleBackColor = true;
            this.btnKivalaszt.Click += new System.EventHandler(this.btnKivalaszt_Click);
            // 
            // lstKivalasztottak
            // 
            this.lstKivalasztottak.FormattingEnabled = true;
            this.lstKivalasztottak.Location = new System.Drawing.Point(362, 94);
            this.lstKivalasztottak.Name = "lstKivalasztottak";
            this.lstKivalasztottak.Size = new System.Drawing.Size(297, 147);
            this.lstKivalasztottak.TabIndex = 9;
            this.lstKivalasztottak.SelectedIndexChanged += new System.EventHandler(this.lstKivalasztottak_SelectedIndexChanged);
            // 
            // lstLegidosebbek
            // 
            this.lstLegidosebbek.FormattingEnabled = true;
            this.lstLegidosebbek.Location = new System.Drawing.Point(362, 291);
            this.lstLegidosebbek.Name = "lstLegidosebbek";
            this.lstLegidosebbek.Size = new System.Drawing.Size(297, 95);
            this.lstLegidosebbek.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.lstLegidosebbek);
            this.Controls.Add(this.lstKivalasztottak);
            this.Controls.Add(this.btnKivalaszt);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.lblDiak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDiakok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDiakok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDiak;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Button btnKivalaszt;
        private System.Windows.Forms.ListBox lstKivalasztottak;
        private System.Windows.Forms.ListBox lstLegidosebbek;
    }
}


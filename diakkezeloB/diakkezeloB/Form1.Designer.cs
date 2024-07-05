namespace diakkezeloB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.pnlEvek = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDiak = new System.Windows.Forms.Label();
            this.lstEredmeny = new System.Windows.Forms.ListBox();
            this.lstDiakok = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(142, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diákok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(488, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Születési év";
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(139, 396);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 3;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            // 
            // pnlEvek
            // 
            this.pnlEvek.Location = new System.Drawing.Point(356, 74);
            this.pnlEvek.Name = "pnlEvek";
            this.pnlEvek.Size = new System.Drawing.Size(385, 81);
            this.pnlEvek.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "A keresés eredménye";
            // 
            // lblDiak
            // 
            this.lblDiak.AutoSize = true;
            this.lblDiak.Location = new System.Drawing.Point(353, 401);
            this.lblDiak.Name = "lblDiak";
            this.lblDiak.Size = new System.Drawing.Size(39, 13);
            this.lblDiak.TabIndex = 7;
            this.lblDiak.Text = "lblDiak";
            // 
            // lstEredmeny
            // 
            this.lstEredmeny.FormattingEnabled = true;
            this.lstEredmeny.Location = new System.Drawing.Point(356, 221);
            this.lstEredmeny.Name = "lstEredmeny";
            this.lstEredmeny.Size = new System.Drawing.Size(385, 147);
            this.lstEredmeny.TabIndex = 8;
            // 
            // lstDiakok
            // 
            this.lstDiakok.FormattingEnabled = true;
            this.lstDiakok.Location = new System.Drawing.Point(42, 74);
            this.lstDiakok.Name = "lstDiakok";
            this.lstDiakok.Size = new System.Drawing.Size(274, 290);
            this.lstDiakok.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDiakok);
            this.Controls.Add(this.lstEredmeny);
            this.Controls.Add(this.lblDiak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlEvek);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Panel pnlEvek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDiak;
        private System.Windows.Forms.ListBox lstEredmeny;
        private System.Windows.Forms.ListBox lstDiakok;
    }
}


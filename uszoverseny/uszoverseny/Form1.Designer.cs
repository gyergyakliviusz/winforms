namespace uszoverseny
{
    partial class VersenyForm
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
            this.lstVersenyzok = new System.Windows.Forms.ListBox();
            this.rchTxtGyoztes = new System.Windows.Forms.RichTextBox();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.btnGyoztes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGyoztesIdo = new System.Windows.Forms.TextBox();
            this.txtEletKor = new System.Windows.Forms.TextBox();
            this.txtIdoEredmeny = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(153, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "200 m-es pillangó úszás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(83, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résztvevők";
            // 
            // lstVersenyzok
            // 
            this.lstVersenyzok.FormattingEnabled = true;
            this.lstVersenyzok.Location = new System.Drawing.Point(46, 114);
            this.lstVersenyzok.Name = "lstVersenyzok";
            this.lstVersenyzok.Size = new System.Drawing.Size(175, 251);
            this.lstVersenyzok.TabIndex = 2;
            this.lstVersenyzok.SelectedIndexChanged += new System.EventHandler(this.lstVersenyzok_SelectedIndexChanged);
            // 
            // rchTxtGyoztes
            // 
            this.rchTxtGyoztes.Location = new System.Drawing.Point(288, 295);
            this.rchTxtGyoztes.Name = "rchTxtGyoztes";
            this.rchTxtGyoztes.Size = new System.Drawing.Size(175, 70);
            this.rchTxtGyoztes.TabIndex = 3;
            this.rchTxtGyoztes.Text = "";
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.Location = new System.Drawing.Point(66, 396);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(131, 23);
            this.btnAdatBe.TabIndex = 4;
            this.btnAdatBe.Text = "Adatok Beolvasása";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            this.btnAdatBe.Click += new System.EventHandler(this.btnAdatBe_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(310, 396);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(131, 23);
            this.btnBezar.TabIndex = 5;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // btnGyoztes
            // 
            this.btnGyoztes.Location = new System.Drawing.Point(288, 266);
            this.btnGyoztes.Name = "btnGyoztes";
            this.btnGyoztes.Size = new System.Drawing.Size(84, 23);
            this.btnGyoztes.TabIndex = 6;
            this.btnGyoztes.Text = "Győztes";
            this.btnGyoztes.UseVisualStyleBackColor = true;
            this.btnGyoztes.Click += new System.EventHandler(this.btnGyoztes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rajtszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ország:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Időeredmény:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Életkor:";
            // 
            // txtGyoztesIdo
            // 
            this.txtGyoztesIdo.Enabled = false;
            this.txtGyoztesIdo.Location = new System.Drawing.Point(378, 268);
            this.txtGyoztesIdo.Name = "txtGyoztesIdo";
            this.txtGyoztesIdo.Size = new System.Drawing.Size(84, 20);
            this.txtGyoztesIdo.TabIndex = 11;
            // 
            // txtEletKor
            // 
            this.txtEletKor.Enabled = false;
            this.txtEletKor.Location = new System.Drawing.Point(378, 226);
            this.txtEletKor.Name = "txtEletKor";
            this.txtEletKor.Size = new System.Drawing.Size(84, 20);
            this.txtEletKor.TabIndex = 12;
            // 
            // txtIdoEredmeny
            // 
            this.txtIdoEredmeny.Enabled = false;
            this.txtIdoEredmeny.Location = new System.Drawing.Point(378, 188);
            this.txtIdoEredmeny.Name = "txtIdoEredmeny";
            this.txtIdoEredmeny.Size = new System.Drawing.Size(84, 20);
            this.txtIdoEredmeny.TabIndex = 13;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Enabled = false;
            this.txtOrszag.Location = new System.Drawing.Point(379, 149);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(84, 20);
            this.txtOrszag.TabIndex = 14;
            // 
            // txtRajtszam
            // 
            this.txtRajtszam.Enabled = false;
            this.txtRajtszam.Location = new System.Drawing.Point(378, 111);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.Size = new System.Drawing.Size(84, 20);
            this.txtRajtszam.TabIndex = 15;
            // 
            // VersenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtIdoEredmeny);
            this.Controls.Add(this.txtEletKor);
            this.Controls.Add(this.txtGyoztesIdo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGyoztes);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.rchTxtGyoztes);
            this.Controls.Add(this.lstVersenyzok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VersenyForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstVersenyzok;
        private System.Windows.Forms.RichTextBox rchTxtGyoztes;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Button btnGyoztes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGyoztesIdo;
        private System.Windows.Forms.TextBox txtEletKor;
        private System.Windows.Forms.TextBox txtIdoEredmeny;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtRajtszam;
    }
}


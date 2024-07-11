namespace uszas
{
    partial class EredmenyForm
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
            this.lblCim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstVersenyzok = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdoeredmeny = new System.Windows.Forms.TextBox();
            this.rdBtnNevsor = new System.Windows.Forms.RadioButton();
            this.rdBtnEredmeny = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCim
            // 
            this.lblCim.AutoSize = true;
            this.lblCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCim.Location = new System.Drawing.Point(221, 32);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(352, 24);
            this.lblCim.TabIndex = 0;
            this.lblCim.Text = "300 méteres gyorsúszás eredménye:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(183, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résztvevők";
            // 
            // lstVersenyzok
            // 
            this.lstVersenyzok.FormattingEnabled = true;
            this.lstVersenyzok.Location = new System.Drawing.Point(122, 113);
            this.lstVersenyzok.Name = "lstVersenyzok";
            this.lstVersenyzok.Size = new System.Drawing.Size(219, 264);
            this.lstVersenyzok.TabIndex = 2;
            this.lstVersenyzok.SelectedIndexChanged += new System.EventHandler(this.lstVersenyzok_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rajtszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ország:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Időeredmény:";
            // 
            // txtRajtszam
            // 
            this.txtRajtszam.Location = new System.Drawing.Point(524, 110);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.Size = new System.Drawing.Size(147, 20);
            this.txtRajtszam.TabIndex = 6;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(524, 164);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(147, 20);
            this.txtOrszag.TabIndex = 7;
            // 
            // txtIdoeredmeny
            // 
            this.txtIdoeredmeny.Location = new System.Drawing.Point(524, 216);
            this.txtIdoeredmeny.Name = "txtIdoeredmeny";
            this.txtIdoeredmeny.Size = new System.Drawing.Size(147, 20);
            this.txtIdoeredmeny.TabIndex = 8;
            // 
            // rdBtnNevsor
            // 
            this.rdBtnNevsor.AutoSize = true;
            this.rdBtnNevsor.Location = new System.Drawing.Point(23, 30);
            this.rdBtnNevsor.Name = "rdBtnNevsor";
            this.rdBtnNevsor.Size = new System.Drawing.Size(92, 17);
            this.rdBtnNevsor.TabIndex = 9;
            this.rdBtnNevsor.TabStop = true;
            this.rdBtnNevsor.Text = "Névsor szerint";
            this.rdBtnNevsor.UseVisualStyleBackColor = true;
            this.rdBtnNevsor.CheckedChanged += new System.EventHandler(this.rdBtnNevsor_CheckedChanged);
            // 
            // rdBtnEredmeny
            // 
            this.rdBtnEredmeny.AutoSize = true;
            this.rdBtnEredmeny.Location = new System.Drawing.Point(23, 58);
            this.rdBtnEredmeny.Name = "rdBtnEredmeny";
            this.rdBtnEredmeny.Size = new System.Drawing.Size(105, 17);
            this.rdBtnEredmeny.TabIndex = 10;
            this.rdBtnEredmeny.TabStop = true;
            this.rdBtnEredmeny.Text = "Eredmény szerint";
            this.rdBtnEredmeny.UseVisualStyleBackColor = true;
            this.rdBtnEredmeny.CheckedChanged += new System.EventHandler(this.rdBtnEredmeny_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnNevsor);
            this.groupBox1.Controls.Add(this.rdBtnEredmeny);
            this.groupBox1.Location = new System.Drawing.Point(435, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendezési szempont:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Résztvevő országok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Bezár";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EredmenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIdoeredmeny);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstVersenyzok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCim);
            this.Name = "EredmenyForm";
            this.Text = "EredmenyForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstVersenyzok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRajtszam;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdoeredmeny;
        private System.Windows.Forms.RadioButton rdBtnNevsor;
        private System.Windows.Forms.RadioButton rdBtnEredmeny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

namespace E_KART
{
    partial class ögrencikarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ögrencikarti));
            this.btnresim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtogrno = new System.Windows.Forms.MaskedTextBox();
            this.txtbolumadi = new System.Windows.Forms.TextBox();
            this.txtfakulte = new System.Windows.Forms.TextBox();
            this.txtsoyadi = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnresim
            // 
            this.btnresim.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnresim.Location = new System.Drawing.Point(154, 133);
            this.btnresim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnresim.Name = "btnresim";
            this.btnresim.Size = new System.Drawing.Size(118, 31);
            this.btnresim.TabIndex = 38;
            this.btnresim.Text = "Dosya seç";
            this.btnresim.UseVisualStyleBackColor = true;
            this.btnresim.Click += new System.EventHandler(this.btnresim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(154, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 111);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(88, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "ÖGRENCİ NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(88, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "FAKÜLTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(88, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "BÖLÜM ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "SOYADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(88, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "ADI";
            // 
            // mtxtogrno
            // 
            this.mtxtogrno.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mtxtogrno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtogrno.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtxtogrno.Location = new System.Drawing.Point(88, 400);
            this.mtxtogrno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtogrno.Mask = "0000000000000";
            this.mtxtogrno.Name = "mtxtogrno";
            this.mtxtogrno.Size = new System.Drawing.Size(253, 32);
            this.mtxtogrno.TabIndex = 31;
            this.mtxtogrno.ValidatingType = typeof(int);
            // 
            // txtbolumadi
            // 
            this.txtbolumadi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbolumadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbolumadi.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbolumadi.Location = new System.Drawing.Point(88, 589);
            this.txtbolumadi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbolumadi.Name = "txtbolumadi";
            this.txtbolumadi.Size = new System.Drawing.Size(253, 32);
            this.txtbolumadi.TabIndex = 30;
            // 
            // txtfakulte
            // 
            this.txtfakulte.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtfakulte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfakulte.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtfakulte.Location = new System.Drawing.Point(88, 499);
            this.txtfakulte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfakulte.Name = "txtfakulte";
            this.txtfakulte.Size = new System.Drawing.Size(253, 32);
            this.txtfakulte.TabIndex = 29;
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtsoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoyadi.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtsoyadi.Location = new System.Drawing.Point(88, 309);
            this.txtsoyadi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(253, 32);
            this.txtsoyadi.TabIndex = 28;
            // 
            // txtadi
            // 
            this.txtadi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadi.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtadi.Location = new System.Drawing.Point(88, 216);
            this.txtadi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(253, 32);
            this.txtadi.TabIndex = 27;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.AliceBlue;
            this.btnkaydet.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnkaydet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnkaydet.Location = new System.Drawing.Point(117, 647);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(170, 35);
            this.btnkaydet.TabIndex = 54;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnsil.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsil.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnsil.Location = new System.Drawing.Point(117, 702);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(170, 35);
            this.btnsil.TabIndex = 56;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // ögrencikarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(427, 749);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnresim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtogrno);
            this.Controls.Add(this.txtbolumadi);
            this.Controls.Add(this.txtfakulte);
            this.Controls.Add(this.txtsoyadi);
            this.Controls.Add(this.txtadi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ögrencikarti";
            this.Text = "ögrencikarti";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnresim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtogrno;
        private System.Windows.Forms.TextBox txtbolumadi;
        private System.Windows.Forms.TextBox txtfakulte;
        private System.Windows.Forms.TextBox txtsoyadi;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
    }
}
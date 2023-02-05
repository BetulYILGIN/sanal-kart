
namespace E_KART
{
    partial class kayıtlarım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayıtlarım));
            this.ogrencibtn = new System.Windows.Forms.Button();
            this.otobusbtn = new System.Windows.Forms.Button();
            this.ehliyetbtn = new System.Windows.Forms.Button();
            this.kimlikkbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogrencibtn
            // 
            this.ogrencibtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ogrencibtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ogrencibtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ogrencibtn.Location = new System.Drawing.Point(136, 416);
            this.ogrencibtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrencibtn.Name = "ogrencibtn";
            this.ogrencibtn.Size = new System.Drawing.Size(153, 72);
            this.ogrencibtn.TabIndex = 17;
            this.ogrencibtn.Text = "ÖGRENCİ   KARTI";
            this.ogrencibtn.UseVisualStyleBackColor = false;
            this.ogrencibtn.Click += new System.EventHandler(this.ogrencibtn_Click);
            // 
            // otobusbtn
            // 
            this.otobusbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.otobusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.otobusbtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.otobusbtn.Location = new System.Drawing.Point(136, 305);
            this.otobusbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.otobusbtn.Name = "otobusbtn";
            this.otobusbtn.Size = new System.Drawing.Size(153, 72);
            this.otobusbtn.TabIndex = 16;
            this.otobusbtn.Text = "OTOBÜS   KARTI";
            this.otobusbtn.UseVisualStyleBackColor = false;
            this.otobusbtn.Click += new System.EventHandler(this.otobusbtn_Click);
            // 
            // ehliyetbtn
            // 
            this.ehliyetbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ehliyetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ehliyetbtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ehliyetbtn.Location = new System.Drawing.Point(136, 195);
            this.ehliyetbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ehliyetbtn.Name = "ehliyetbtn";
            this.ehliyetbtn.Size = new System.Drawing.Size(153, 72);
            this.ehliyetbtn.TabIndex = 15;
            this.ehliyetbtn.Text = "EHLİYET";
            this.ehliyetbtn.UseVisualStyleBackColor = false;
            this.ehliyetbtn.Click += new System.EventHandler(this.ehliyetbtn_Click);
            // 
            // kimlikkbtn
            // 
            this.kimlikkbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kimlikkbtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.kimlikkbtn.FlatAppearance.BorderSize = 0;
            this.kimlikkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kimlikkbtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kimlikkbtn.ForeColor = System.Drawing.Color.Black;
            this.kimlikkbtn.Location = new System.Drawing.Point(136, 85);
            this.kimlikkbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kimlikkbtn.Name = "kimlikkbtn";
            this.kimlikkbtn.Size = new System.Drawing.Size(153, 72);
            this.kimlikkbtn.TabIndex = 14;
            this.kimlikkbtn.Text = "KİMLİK";
            this.kimlikkbtn.UseVisualStyleBackColor = false;
            this.kimlikkbtn.Click += new System.EventHandler(this.kimlikkbtn_Click_1);
            // 
            // kayıtlarım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(432, 575);
            this.Controls.Add(this.ogrencibtn);
            this.Controls.Add(this.otobusbtn);
            this.Controls.Add(this.ehliyetbtn);
            this.Controls.Add(this.kimlikkbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kayıtlarım";
            this.Text = "kayıtlarım";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ogrencibtn;
        private System.Windows.Forms.Button otobusbtn;
        private System.Windows.Forms.Button ehliyetbtn;
        private System.Windows.Forms.Button kimlikkbtn;
    }
}
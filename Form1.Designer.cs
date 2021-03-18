namespace fsuae_launcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.profilCover = new System.Windows.Forms.PictureBox();
            this.profilDesc = new System.Windows.Forms.TextBox();
            this.profilList = new System.Windows.Forms.ListBox();
            this.playButton = new System.Windows.Forms.Button();
            this.fsuaeLogo = new System.Windows.Forms.PictureBox();
            this.fsuaeLogoLabel = new System.Windows.Forms.Label();
            this.yosmontLink = new System.Windows.Forms.Button();
            this.yosmontAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsuaeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yosmontAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // profilCover
            // 
            this.profilCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.profilCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profilCover.Location = new System.Drawing.Point(526, 117);
            this.profilCover.Name = "profilCover";
            this.profilCover.Size = new System.Drawing.Size(324, 182);
            this.profilCover.TabIndex = 0;
            this.profilCover.TabStop = false;
            // 
            // profilDesc
            // 
            this.profilDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.profilDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profilDesc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profilDesc.ForeColor = System.Drawing.Color.White;
            this.profilDesc.Location = new System.Drawing.Point(526, 308);
            this.profilDesc.Multiline = true;
            this.profilDesc.Name = "profilDesc";
            this.profilDesc.ReadOnly = true;
            this.profilDesc.Size = new System.Drawing.Size(324, 188);
            this.profilDesc.TabIndex = 1;
            this.profilDesc.Text = "profil desc";
            // 
            // profilList
            // 
            this.profilList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.profilList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profilList.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profilList.ForeColor = System.Drawing.Color.White;
            this.profilList.FormattingEnabled = true;
            this.profilList.ItemHeight = 36;
            this.profilList.Location = new System.Drawing.Point(30, 117);
            this.profilList.Name = "profilList";
            this.profilList.Size = new System.Drawing.Size(447, 432);
            this.profilList.TabIndex = 2;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(66)))), ((int)(((byte)(158)))));
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(66)))), ((int)(((byte)(158)))));
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(53)))), ((int)(((byte)(127)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(524, 502);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(326, 53);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            // 
            // fsuaeLogo
            // 
            this.fsuaeLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.fsuaeLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fsuaeLogo.BackgroundImage")));
            this.fsuaeLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fsuaeLogo.Location = new System.Drawing.Point(30, 12);
            this.fsuaeLogo.Name = "fsuaeLogo";
            this.fsuaeLogo.Size = new System.Drawing.Size(90, 90);
            this.fsuaeLogo.TabIndex = 4;
            this.fsuaeLogo.TabStop = false;
            // 
            // fsuaeLogoLabel
            // 
            this.fsuaeLogoLabel.AutoSize = true;
            this.fsuaeLogoLabel.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fsuaeLogoLabel.ForeColor = System.Drawing.Color.White;
            this.fsuaeLogoLabel.Location = new System.Drawing.Point(126, 75);
            this.fsuaeLogoLabel.Name = "fsuaeLogoLabel";
            this.fsuaeLogoLabel.Size = new System.Drawing.Size(132, 27);
            this.fsuaeLogoLabel.TabIndex = 5;
            this.fsuaeLogoLabel.Text = "Launcher";
            // 
            // yosmontLink
            // 
            this.yosmontLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.yosmontLink.FlatAppearance.BorderSize = 0;
            this.yosmontLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yosmontLink.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yosmontLink.Location = new System.Drawing.Point(671, 20);
            this.yosmontLink.Name = "yosmontLink";
            this.yosmontLink.Size = new System.Drawing.Size(223, 55);
            this.yosmontLink.TabIndex = 6;
            this.yosmontLink.Text = "github repository link";
            this.yosmontLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yosmontLink.UseVisualStyleBackColor = false;
            // 
            // yosmontAvatar
            // 
            this.yosmontAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yosmontAvatar.BackgroundImage")));
            this.yosmontAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yosmontAvatar.Location = new System.Drawing.Point(838, 20);
            this.yosmontAvatar.Name = "yosmontAvatar";
            this.yosmontAvatar.Size = new System.Drawing.Size(55, 55);
            this.yosmontAvatar.TabIndex = 7;
            this.yosmontAvatar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 585);
            this.Controls.Add(this.yosmontAvatar);
            this.Controls.Add(this.yosmontLink);
            this.Controls.Add(this.fsuaeLogoLabel);
            this.Controls.Add(this.fsuaeLogo);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.profilList);
            this.Controls.Add(this.profilDesc);
            this.Controls.Add(this.profilCover);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FS-UAE Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.profilCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsuaeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yosmontAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilCover;
        private System.Windows.Forms.TextBox profilDesc;
        private System.Windows.Forms.ListBox profilList;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox fsuaeLogo;
        private System.Windows.Forms.Label fsuaeLogoLabel;
        private System.Windows.Forms.Button yosmontLink;
        private System.Windows.Forms.PictureBox yosmontAvatar;
    }
}


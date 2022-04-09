namespace WindowsForms.User_Controls
{
    partial class PlayerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblShirtNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsAddPlayerToFav = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsAddPlayerToFav.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            this.lblName.DoubleClick += new System.EventHandler(this.PlayerUserControl_DoubleClick);
            // 
            // lblShirtNumber
            // 
            this.lblShirtNumber.AutoSize = true;
            this.lblShirtNumber.Location = new System.Drawing.Point(3, 41);
            this.lblShirtNumber.Name = "lblShirtNumber";
            this.lblShirtNumber.Size = new System.Drawing.Size(35, 13);
            this.lblShirtNumber.TabIndex = 1;
            this.lblShirtNumber.Text = "label2";
            this.lblShirtNumber.DoubleClick += new System.EventHandler(this.PlayerUserControl_DoubleClick);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(3, 70);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(35, 13);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "label3";
            this.lblPosition.DoubleClick += new System.EventHandler(this.PlayerUserControl_DoubleClick);
            // 
            // lblCaptain
            // 
            this.lblCaptain.AutoSize = true;
            this.lblCaptain.Location = new System.Drawing.Point(3, 99);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(35, 13);
            this.lblCaptain.TabIndex = 3;
            this.lblCaptain.Text = "label4";
            this.lblCaptain.DoubleClick += new System.EventHandler(this.PlayerUserControl_DoubleClick);
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.Location = new System.Drawing.Point(3, 129);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(35, 13);
            this.lblFavorite.TabIndex = 4;
            this.lblFavorite.Text = "label5";
            this.lblFavorite.DoubleClick += new System.EventHandler(this.PlayerUserControl_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(102, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.PlayerUserControl_DoubleClick);
            // 
            // cmsAddPlayerToFav
            // 
            this.cmsAddPlayerToFav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavoritesToolStripMenuItem});
            this.cmsAddPlayerToFav.Name = "cmsAddPlayerToFav";
            this.cmsAddPlayerToFav.Size = new System.Drawing.Size(181, 48);
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            this.addToFavoritesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToFavoritesToolStripMenuItem.Text = "Add to favorites";
            this.addToFavoritesToolStripMenuItem.Click += new System.EventHandler(this.addToFavoritesToolStripMenuItem_Click);
            // 
            // PlayerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFavorite);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblShirtNumber);
            this.Controls.Add(this.lblName);
            this.Name = "PlayerUserControl";
            this.Size = new System.Drawing.Size(198, 200);
            this.Load += new System.EventHandler(this.PlayerUserControl_Load);
            this.DoubleClick += new System.EventHandler(this.PlayerUserControl_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUserControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsAddPlayerToFav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblShirtNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.Label lblFavorite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsAddPlayerToFav;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
    }
}

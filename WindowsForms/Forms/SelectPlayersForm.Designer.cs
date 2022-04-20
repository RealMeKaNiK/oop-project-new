namespace WindowsForms.Forms
{
    partial class SelectPlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPlayersForm));
            this.flpLoadedPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLoadingAnimation = new System.Windows.Forms.PictureBox();
            this.flpFavoritePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveFavorites = new System.Windows.Forms.Button();
            this.flpLoadedPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // flpLoadedPlayers
            // 
            resources.ApplyResources(this.flpLoadedPlayers, "flpLoadedPlayers");
            this.flpLoadedPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flpLoadedPlayers.Controls.Add(this.pbLoadingAnimation);
            this.flpLoadedPlayers.Name = "flpLoadedPlayers";
            // 
            // pbLoadingAnimation
            // 
            resources.ApplyResources(this.pbLoadingAnimation, "pbLoadingAnimation");
            this.pbLoadingAnimation.Name = "pbLoadingAnimation";
            this.pbLoadingAnimation.TabStop = false;
            // 
            // flpFavoritePlayers
            // 
            resources.ApplyResources(this.flpFavoritePlayers, "flpFavoritePlayers");
            this.flpFavoritePlayers.AllowDrop = true;
            this.flpFavoritePlayers.BackColor = System.Drawing.Color.Aqua;
            this.flpFavoritePlayers.Name = "flpFavoritePlayers";
            this.flpFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavoritePlayers_DragDrop);
            this.flpFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavoritePlayers_DragEnter);
            // 
            // btnRemoveFavorites
            // 
            resources.ApplyResources(this.btnRemoveFavorites, "btnRemoveFavorites");
            this.btnRemoveFavorites.Name = "btnRemoveFavorites";
            this.btnRemoveFavorites.UseVisualStyleBackColor = true;
            this.btnRemoveFavorites.Click += new System.EventHandler(this.btnRemoveFavorites_Click);
            // 
            // SelectPlayersForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveFavorites);
            this.Controls.Add(this.flpFavoritePlayers);
            this.Controls.Add(this.flpLoadedPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectPlayersForm";
            this.Load += new System.EventHandler(this.SelectPlayersForm_Load);
            this.flpLoadedPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnimation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLoadedPlayers;
        private System.Windows.Forms.FlowLayoutPanel flpFavoritePlayers;
        private System.Windows.Forms.Button btnRemoveFavorites;
        private System.Windows.Forms.PictureBox pbLoadingAnimation;
    }
}
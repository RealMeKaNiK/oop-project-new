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
            this.flpLoadedPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFavoritePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveFavorites = new System.Windows.Forms.Button();
            this.btnTransferSelectedUserControls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpLoadedPlayers
            // 
            this.flpLoadedPlayers.AutoScroll = true;
            this.flpLoadedPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flpLoadedPlayers.Location = new System.Drawing.Point(807, 18);
            this.flpLoadedPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpLoadedPlayers.Name = "flpLoadedPlayers";
            this.flpLoadedPlayers.Size = new System.Drawing.Size(651, 1134);
            this.flpLoadedPlayers.TabIndex = 0;
            // 
            // flpFavoritePlayers
            // 
            this.flpFavoritePlayers.AllowDrop = true;
            this.flpFavoritePlayers.BackColor = System.Drawing.Color.Aqua;
            this.flpFavoritePlayers.Location = new System.Drawing.Point(18, 18);
            this.flpFavoritePlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpFavoritePlayers.Name = "flpFavoritePlayers";
            this.flpFavoritePlayers.Size = new System.Drawing.Size(651, 1134);
            this.flpFavoritePlayers.TabIndex = 1;
            this.flpFavoritePlayers.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpFavoritePlayers_ControlAdded);
            this.flpFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavoritePlayers_DragDrop);
            this.flpFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavoritePlayers_DragEnter);
            // 
            // btnRemoveFavorites
            // 
            this.btnRemoveFavorites.Location = new System.Drawing.Point(678, 608);
            this.btnRemoveFavorites.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveFavorites.Name = "btnRemoveFavorites";
            this.btnRemoveFavorites.Size = new System.Drawing.Size(120, 106);
            this.btnRemoveFavorites.TabIndex = 2;
            this.btnRemoveFavorites.Text = "Remove All Favorites";
            this.btnRemoveFavorites.UseVisualStyleBackColor = true;
            this.btnRemoveFavorites.Click += new System.EventHandler(this.btnRemoveFavorites_Click);
            // 
            // btnTransferSelectedUserControls
            // 
            this.btnTransferSelectedUserControls.Location = new System.Drawing.Point(678, 369);
            this.btnTransferSelectedUserControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransferSelectedUserControls.Name = "btnTransferSelectedUserControls";
            this.btnTransferSelectedUserControls.Size = new System.Drawing.Size(120, 106);
            this.btnTransferSelectedUserControls.TabIndex = 3;
            this.btnTransferSelectedUserControls.Text = "Transfer selected";
            this.btnTransferSelectedUserControls.UseVisualStyleBackColor = true;
            this.btnTransferSelectedUserControls.Click += new System.EventHandler(this.btnTransferSelectedUserControls_Click);
            // 
            // SelectPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1106);
            this.Controls.Add(this.btnTransferSelectedUserControls);
            this.Controls.Add(this.btnRemoveFavorites);
            this.Controls.Add(this.flpFavoritePlayers);
            this.Controls.Add(this.flpLoadedPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectPlayersForm";
            this.Text = "SelectPlayersForm";
            this.Load += new System.EventHandler(this.SelectPlayersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLoadedPlayers;
        private System.Windows.Forms.FlowLayoutPanel flpFavoritePlayers;
        private System.Windows.Forms.Button btnRemoveFavorites;
        private System.Windows.Forms.Button btnTransferSelectedUserControls;
    }
}
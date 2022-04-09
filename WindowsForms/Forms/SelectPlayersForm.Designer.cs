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
            this.SuspendLayout();
            // 
            // flpLoadedPlayers
            // 
            this.flpLoadedPlayers.AutoScroll = true;
            this.flpLoadedPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flpLoadedPlayers.Location = new System.Drawing.Point(538, 12);
            this.flpLoadedPlayers.Name = "flpLoadedPlayers";
            this.flpLoadedPlayers.Size = new System.Drawing.Size(434, 737);
            this.flpLoadedPlayers.TabIndex = 0;
            // 
            // flpFavoritePlayers
            // 
            this.flpFavoritePlayers.AllowDrop = true;
            this.flpFavoritePlayers.BackColor = System.Drawing.Color.Aqua;
            this.flpFavoritePlayers.Location = new System.Drawing.Point(12, 12);
            this.flpFavoritePlayers.Name = "flpFavoritePlayers";
            this.flpFavoritePlayers.Size = new System.Drawing.Size(434, 737);
            this.flpFavoritePlayers.TabIndex = 1;
            this.flpFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavoritePlayers_DragDrop);
            this.flpFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavoritePlayers_DragEnter);
            // 
            // SelectPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.flpFavoritePlayers);
            this.Controls.Add(this.flpLoadedPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectPlayersForm";
            this.Text = "SelectPlayersForm";
            this.Load += new System.EventHandler(this.SelectPlayersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLoadedPlayers;
        private System.Windows.Forms.FlowLayoutPanel flpFavoritePlayers;
    }
}
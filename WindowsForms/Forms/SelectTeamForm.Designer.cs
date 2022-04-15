namespace WindowsForms.Forms
{
    partial class SelectTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTeamForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbAllTeams = new System.Windows.Forms.ComboBox();
            this.btnSaveFavoriteTeam = new System.Windows.Forms.Button();
            this.lblCurrentTeam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLoadingAnimation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi favorit team";
            // 
            // cbAllTeams
            // 
            this.cbAllTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllTeams.FormattingEnabled = true;
            this.cbAllTeams.Location = new System.Drawing.Point(380, 216);
            this.cbAllTeams.Name = "cbAllTeams";
            this.cbAllTeams.Size = new System.Drawing.Size(209, 21);
            this.cbAllTeams.TabIndex = 1;
            // 
            // btnSaveFavoriteTeam
            // 
            this.btnSaveFavoriteTeam.Location = new System.Drawing.Point(380, 297);
            this.btnSaveFavoriteTeam.Name = "btnSaveFavoriteTeam";
            this.btnSaveFavoriteTeam.Size = new System.Drawing.Size(209, 54);
            this.btnSaveFavoriteTeam.TabIndex = 2;
            this.btnSaveFavoriteTeam.Text = "Spremi Odabir";
            this.btnSaveFavoriteTeam.UseVisualStyleBackColor = true;
            this.btnSaveFavoriteTeam.Click += new System.EventHandler(this.btnSaveFavoriteTeam_Click);
            // 
            // lblCurrentTeam
            // 
            this.lblCurrentTeam.AutoSize = true;
            this.lblCurrentTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTeam.Location = new System.Drawing.Point(454, 448);
            this.lblCurrentTeam.Name = "lblCurrentTeam";
            this.lblCurrentTeam.Size = new System.Drawing.Size(76, 25);
            this.lblCurrentTeam.TabIndex = 3;
            this.lblCurrentTeam.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "TRENUTNO ODABRANI TEAM";
            // 
            // pbLoadingAnimation
            // 
            this.pbLoadingAnimation.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingAnimation.Image")));
            this.pbLoadingAnimation.Location = new System.Drawing.Point(380, 194);
            this.pbLoadingAnimation.Name = "pbLoadingAnimation";
            this.pbLoadingAnimation.Size = new System.Drawing.Size(209, 67);
            this.pbLoadingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoadingAnimation.TabIndex = 5;
            this.pbLoadingAnimation.TabStop = false;
            // 
            // SelectTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.pbLoadingAnimation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentTeam);
            this.Controls.Add(this.btnSaveFavoriteTeam);
            this.Controls.Add(this.cbAllTeams);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectTeamForm";
            this.Text = "SelectTeamForm";
            this.Load += new System.EventHandler(this.SelectTeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAllTeams;
        private System.Windows.Forms.Button btnSaveFavoriteTeam;
        private System.Windows.Forms.Label lblCurrentTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLoadingAnimation;
    }
}
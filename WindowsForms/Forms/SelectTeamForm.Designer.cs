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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbAllTeams
            // 
            resources.ApplyResources(this.cbAllTeams, "cbAllTeams");
            this.cbAllTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllTeams.FormattingEnabled = true;
            this.cbAllTeams.Name = "cbAllTeams";
            // 
            // btnSaveFavoriteTeam
            // 
            resources.ApplyResources(this.btnSaveFavoriteTeam, "btnSaveFavoriteTeam");
            this.btnSaveFavoriteTeam.Name = "btnSaveFavoriteTeam";
            this.btnSaveFavoriteTeam.UseVisualStyleBackColor = true;
            this.btnSaveFavoriteTeam.Click += new System.EventHandler(this.btnSaveFavoriteTeam_Click);
            // 
            // lblCurrentTeam
            // 
            resources.ApplyResources(this.lblCurrentTeam, "lblCurrentTeam");
            this.lblCurrentTeam.Name = "lblCurrentTeam";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pbLoadingAnimation
            // 
            resources.ApplyResources(this.pbLoadingAnimation, "pbLoadingAnimation");
            this.pbLoadingAnimation.Name = "pbLoadingAnimation";
            this.pbLoadingAnimation.TabStop = false;
            // 
            // SelectTeamForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLoadingAnimation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentTeam);
            this.Controls.Add(this.btnSaveFavoriteTeam);
            this.Controls.Add(this.cbAllTeams);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectTeamForm";
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
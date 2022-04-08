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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAllTeams = new System.Windows.Forms.ComboBox();
            this.btnSaveFavoriteTeam = new System.Windows.Forms.Button();
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
            // SelectTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btnSaveFavoriteTeam);
            this.Controls.Add(this.cbAllTeams);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectTeamForm";
            this.Text = "SelectTeamForm";
            this.Load += new System.EventHandler(this.SelectTeamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAllTeams;
        private System.Windows.Forms.Button btnSaveFavoriteTeam;
    }
}
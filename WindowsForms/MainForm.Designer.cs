namespace WindowsForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnOpenSetPicutres = new System.Windows.Forms.Button();
            this.btnOpenEventsRang = new System.Windows.Forms.Button();
            this.btnOpenPlayersRang = new System.Windows.Forms.Button();
            this.btnOpenPlayers = new System.Windows.Forms.Button();
            this.btnOpenTeams = new System.Windows.Forms.Button();
            this.btnOpenSettingsForm = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            resources.ApplyResources(this.pnlNavigation, "pnlNavigation");
            this.pnlNavigation.BackColor = System.Drawing.Color.Lime;
            this.pnlNavigation.Controls.Add(this.btnOpenSetPicutres);
            this.pnlNavigation.Controls.Add(this.btnOpenEventsRang);
            this.pnlNavigation.Controls.Add(this.btnOpenPlayersRang);
            this.pnlNavigation.Controls.Add(this.btnOpenPlayers);
            this.pnlNavigation.Controls.Add(this.btnOpenTeams);
            this.pnlNavigation.Controls.Add(this.btnOpenSettingsForm);
            this.pnlNavigation.Name = "pnlNavigation";
            // 
            // btnOpenSetPicutres
            // 
            resources.ApplyResources(this.btnOpenSetPicutres, "btnOpenSetPicutres");
            this.btnOpenSetPicutres.Name = "btnOpenSetPicutres";
            this.btnOpenSetPicutres.UseVisualStyleBackColor = true;
            this.btnOpenSetPicutres.Click += new System.EventHandler(this.btnOpenSetPicutres_Click);
            // 
            // btnOpenEventsRang
            // 
            resources.ApplyResources(this.btnOpenEventsRang, "btnOpenEventsRang");
            this.btnOpenEventsRang.Name = "btnOpenEventsRang";
            this.btnOpenEventsRang.UseVisualStyleBackColor = true;
            this.btnOpenEventsRang.Click += new System.EventHandler(this.btnOpenEventsRang_Click);
            // 
            // btnOpenPlayersRang
            // 
            resources.ApplyResources(this.btnOpenPlayersRang, "btnOpenPlayersRang");
            this.btnOpenPlayersRang.Name = "btnOpenPlayersRang";
            this.btnOpenPlayersRang.UseVisualStyleBackColor = true;
            this.btnOpenPlayersRang.Click += new System.EventHandler(this.btnOpenPlayersRang_Click);
            // 
            // btnOpenPlayers
            // 
            resources.ApplyResources(this.btnOpenPlayers, "btnOpenPlayers");
            this.btnOpenPlayers.Name = "btnOpenPlayers";
            this.btnOpenPlayers.UseVisualStyleBackColor = true;
            this.btnOpenPlayers.Click += new System.EventHandler(this.btnOpenPlayers_Click);
            // 
            // btnOpenTeams
            // 
            resources.ApplyResources(this.btnOpenTeams, "btnOpenTeams");
            this.btnOpenTeams.Name = "btnOpenTeams";
            this.btnOpenTeams.UseVisualStyleBackColor = true;
            this.btnOpenTeams.Click += new System.EventHandler(this.btnOpenTeams_Click);
            // 
            // btnOpenSettingsForm
            // 
            resources.ApplyResources(this.btnOpenSettingsForm, "btnOpenSettingsForm");
            this.btnOpenSettingsForm.Name = "btnOpenSettingsForm";
            this.btnOpenSettingsForm.UseVisualStyleBackColor = true;
            this.btnOpenSettingsForm.Click += new System.EventHandler(this.btnOpenSettingsForm_Click);
            // 
            // pnlMain
            // 
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlMain.Name = "pnlMain";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNavigation);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnOpenSetPicutres;
        private System.Windows.Forms.Button btnOpenEventsRang;
        private System.Windows.Forms.Button btnOpenPlayersRang;
        private System.Windows.Forms.Button btnOpenPlayers;
        private System.Windows.Forms.Button btnOpenTeams;
        private System.Windows.Forms.Button btnOpenSettingsForm;
    }
}


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
            this.pnlNavigation.BackColor = System.Drawing.Color.Lime;
            this.pnlNavigation.Controls.Add(this.btnOpenSetPicutres);
            this.pnlNavigation.Controls.Add(this.btnOpenEventsRang);
            this.pnlNavigation.Controls.Add(this.btnOpenPlayersRang);
            this.pnlNavigation.Controls.Add(this.btnOpenPlayers);
            this.pnlNavigation.Controls.Add(this.btnOpenTeams);
            this.pnlNavigation.Controls.Add(this.btnOpenSettingsForm);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 761);
            this.pnlNavigation.TabIndex = 0;
            // 
            // btnOpenSetPicutres
            // 
            this.btnOpenSetPicutres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenSetPicutres.Location = new System.Drawing.Point(0, 551);
            this.btnOpenSetPicutres.Name = "btnOpenSetPicutres";
            this.btnOpenSetPicutres.Size = new System.Drawing.Size(200, 35);
            this.btnOpenSetPicutres.TabIndex = 5;
            this.btnOpenSetPicutres.Text = "Set Player Pictures";
            this.btnOpenSetPicutres.UseVisualStyleBackColor = true;
            this.btnOpenSetPicutres.Click += new System.EventHandler(this.btnOpenSetPicutres_Click);
            // 
            // btnOpenEventsRang
            // 
            this.btnOpenEventsRang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenEventsRang.Location = new System.Drawing.Point(0, 586);
            this.btnOpenEventsRang.Name = "btnOpenEventsRang";
            this.btnOpenEventsRang.Size = new System.Drawing.Size(200, 35);
            this.btnOpenEventsRang.TabIndex = 4;
            this.btnOpenEventsRang.Text = "Rang Lista Event-a";
            this.btnOpenEventsRang.UseVisualStyleBackColor = true;
            this.btnOpenEventsRang.Click += new System.EventHandler(this.btnOpenEventsRang_Click);
            // 
            // btnOpenPlayersRang
            // 
            this.btnOpenPlayersRang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenPlayersRang.Location = new System.Drawing.Point(0, 621);
            this.btnOpenPlayersRang.Name = "btnOpenPlayersRang";
            this.btnOpenPlayersRang.Size = new System.Drawing.Size(200, 35);
            this.btnOpenPlayersRang.TabIndex = 3;
            this.btnOpenPlayersRang.Text = "Rang Lista Igraca";
            this.btnOpenPlayersRang.UseVisualStyleBackColor = true;
            this.btnOpenPlayersRang.Click += new System.EventHandler(this.btnOpenPlayersRang_Click);
            // 
            // btnOpenPlayers
            // 
            this.btnOpenPlayers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenPlayers.Location = new System.Drawing.Point(0, 656);
            this.btnOpenPlayers.Name = "btnOpenPlayers";
            this.btnOpenPlayers.Size = new System.Drawing.Size(200, 35);
            this.btnOpenPlayers.TabIndex = 2;
            this.btnOpenPlayers.Text = "Odaberi Igrace";
            this.btnOpenPlayers.UseVisualStyleBackColor = true;
            this.btnOpenPlayers.Click += new System.EventHandler(this.btnOpenPlayers_Click);
            // 
            // btnOpenTeams
            // 
            this.btnOpenTeams.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenTeams.Location = new System.Drawing.Point(0, 691);
            this.btnOpenTeams.Name = "btnOpenTeams";
            this.btnOpenTeams.Size = new System.Drawing.Size(200, 35);
            this.btnOpenTeams.TabIndex = 1;
            this.btnOpenTeams.Text = "Odaberi momcad";
            this.btnOpenTeams.UseVisualStyleBackColor = true;
            this.btnOpenTeams.Click += new System.EventHandler(this.btnOpenTeams_Click);
            // 
            // btnOpenSettingsForm
            // 
            this.btnOpenSettingsForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenSettingsForm.Location = new System.Drawing.Point(0, 726);
            this.btnOpenSettingsForm.Name = "btnOpenSettingsForm";
            this.btnOpenSettingsForm.Size = new System.Drawing.Size(200, 35);
            this.btnOpenSettingsForm.TabIndex = 0;
            this.btnOpenSettingsForm.Text = "Postavke";
            this.btnOpenSettingsForm.UseVisualStyleBackColor = true;
            this.btnOpenSettingsForm.Click += new System.EventHandler(this.btnOpenSettingsForm_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(984, 761);
            this.pnlMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNavigation);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Forms";
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


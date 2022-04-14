namespace WindowsForms.Forms
{
    partial class EventRangListForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEventStats = new System.Windows.Forms.DataGridView();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometeamcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayteamcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rang Lista / Event Statisika";
            // 
            // dgvEventStats
            // 
            this.dgvEventStats.AllowUserToAddRows = false;
            this.dgvEventStats.AllowUserToDeleteRows = false;
            this.dgvEventStats.AutoGenerateColumns = false;
            this.dgvEventStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.attendanceDataGridViewTextBoxColumn,
            this.hometeamcountryDataGridViewTextBoxColumn,
            this.awayteamcountryDataGridViewTextBoxColumn});
            this.dgvEventStats.DataSource = this.matchBindingSource;
            this.dgvEventStats.Location = new System.Drawing.Point(18, 263);
            this.dgvEventStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEventStats.Name = "dgvEventStats";
            this.dgvEventStats.ReadOnly = true;
            this.dgvEventStats.RowHeadersWidth = 62;
            this.dgvEventStats.Size = new System.Drawing.Size(1440, 686);
            this.dgvEventStats.TabIndex = 2;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 106;
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "attendance";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            this.attendanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendanceDataGridViewTextBoxColumn.Width = 128;
            // 
            // hometeamcountryDataGridViewTextBoxColumn
            // 
            this.hometeamcountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hometeamcountryDataGridViewTextBoxColumn.DataPropertyName = "home_team_country";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometeamcountryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.hometeamcountryDataGridViewTextBoxColumn.HeaderText = "Home Team Country";
            this.hometeamcountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hometeamcountryDataGridViewTextBoxColumn.Name = "hometeamcountryDataGridViewTextBoxColumn";
            this.hometeamcountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.hometeamcountryDataGridViewTextBoxColumn.Width = 175;
            // 
            // awayteamcountryDataGridViewTextBoxColumn
            // 
            this.awayteamcountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.awayteamcountryDataGridViewTextBoxColumn.DataPropertyName = "away_team_country";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayteamcountryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.awayteamcountryDataGridViewTextBoxColumn.HeaderText = "Away Team Country";
            this.awayteamcountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.awayteamcountryDataGridViewTextBoxColumn.Name = "awayteamcountryDataGridViewTextBoxColumn";
            this.awayteamcountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.awayteamcountryDataGridViewTextBoxColumn.Width = 171;
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(DataAccessLayer.Model.Match);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1228, 134);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(230, 88);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // EventRangListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1106);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvEventStats);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EventRangListForm";
            this.Text = "EventRangListForm";
            this.Load += new System.EventHandler(this.EventRangListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEventStats;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometeamcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayteamcountryDataGridViewTextBoxColumn;
    }
}
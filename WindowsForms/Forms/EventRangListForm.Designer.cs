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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEventStats = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pbLoadingAnim = new System.Windows.Forms.PictureBox();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometeamcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayteamcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
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
            this.dgvEventStats.Location = new System.Drawing.Point(12, 171);
            this.dgvEventStats.Name = "dgvEventStats";
            this.dgvEventStats.ReadOnly = true;
            this.dgvEventStats.RowHeadersWidth = 62;
            this.dgvEventStats.Size = new System.Drawing.Size(960, 446);
            this.dgvEventStats.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(819, 87);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(153, 57);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pbLoadingAnim
            // 
            this.pbLoadingAnim.Image = global::WindowsForms.Properties.Resources.loadingAnimation;
            this.pbLoadingAnim.Location = new System.Drawing.Point(440, 342);
            this.pbLoadingAnim.Name = "pbLoadingAnim";
            this.pbLoadingAnim.Size = new System.Drawing.Size(127, 91);
            this.pbLoadingAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoadingAnim.TabIndex = 4;
            this.pbLoadingAnim.TabStop = false;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 73;
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "attendance";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            this.attendanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendanceDataGridViewTextBoxColumn.Width = 87;
            // 
            // hometeamcountryDataGridViewTextBoxColumn
            // 
            this.hometeamcountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hometeamcountryDataGridViewTextBoxColumn.DataPropertyName = "home_team_country";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometeamcountryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.hometeamcountryDataGridViewTextBoxColumn.HeaderText = "Home Team Country";
            this.hometeamcountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hometeamcountryDataGridViewTextBoxColumn.Name = "hometeamcountryDataGridViewTextBoxColumn";
            this.hometeamcountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.hometeamcountryDataGridViewTextBoxColumn.Width = 118;
            // 
            // awayteamcountryDataGridViewTextBoxColumn
            // 
            this.awayteamcountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.awayteamcountryDataGridViewTextBoxColumn.DataPropertyName = "away_team_country";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayteamcountryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.awayteamcountryDataGridViewTextBoxColumn.HeaderText = "Away Team Country";
            this.awayteamcountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.awayteamcountryDataGridViewTextBoxColumn.Name = "awayteamcountryDataGridViewTextBoxColumn";
            this.awayteamcountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.awayteamcountryDataGridViewTextBoxColumn.Width = 116;
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(DataAccessLayer.Model.Match);
            // 
            // EventRangListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 719);
            this.Controls.Add(this.pbLoadingAnim);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvEventStats);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventRangListForm";
            this.Text = "EventRangListForm";
            this.Load += new System.EventHandler(this.EventRangListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnim)).EndInit();
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
        private System.Windows.Forms.PictureBox pbLoadingAnim;
    }
}
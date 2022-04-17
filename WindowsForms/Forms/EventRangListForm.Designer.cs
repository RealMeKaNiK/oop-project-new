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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventRangListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEventStats = new System.Windows.Forms.DataGridView();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.pbLoadingAnim = new System.Windows.Forms.PictureBox();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometeamcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayteamcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgvEventStats
            // 
            resources.ApplyResources(this.dgvEventStats, "dgvEventStats");
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
            this.dgvEventStats.Name = "dgvEventStats";
            this.dgvEventStats.ReadOnly = true;
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(DataAccessLayer.Model.Match);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pbLoadingAnim
            // 
            resources.ApplyResources(this.pbLoadingAnim, "pbLoadingAnim");
            this.pbLoadingAnim.Image = global::WindowsForms.Properties.Resources.loadingAnimation;
            this.pbLoadingAnim.Name = "pbLoadingAnim";
            this.pbLoadingAnim.TabStop = false;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.locationDataGridViewTextBoxColumn, "locationDataGridViewTextBoxColumn");
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "attendance";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.attendanceDataGridViewTextBoxColumn, "attendanceDataGridViewTextBoxColumn");
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            this.attendanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hometeamcountryDataGridViewTextBoxColumn
            // 
            this.hometeamcountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hometeamcountryDataGridViewTextBoxColumn.DataPropertyName = "home_team_country";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometeamcountryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.hometeamcountryDataGridViewTextBoxColumn, "hometeamcountryDataGridViewTextBoxColumn");
            this.hometeamcountryDataGridViewTextBoxColumn.Name = "hometeamcountryDataGridViewTextBoxColumn";
            this.hometeamcountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // awayteamcountryDataGridViewTextBoxColumn
            // 
            this.awayteamcountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.awayteamcountryDataGridViewTextBoxColumn.DataPropertyName = "away_team_country";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayteamcountryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.awayteamcountryDataGridViewTextBoxColumn, "awayteamcountryDataGridViewTextBoxColumn");
            this.awayteamcountryDataGridViewTextBoxColumn.Name = "awayteamcountryDataGridViewTextBoxColumn";
            this.awayteamcountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EventRangListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLoadingAnim);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvEventStats);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventRangListForm";
            this.Load += new System.EventHandler(this.EventRangListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEventStats;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.PictureBox pbLoadingAnim;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometeamcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayteamcountryDataGridViewTextBoxColumn;
    }
}
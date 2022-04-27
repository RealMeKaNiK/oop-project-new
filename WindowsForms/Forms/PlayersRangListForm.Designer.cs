namespace WindowsForms.Forms
{
    partial class PlayersRangListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersRangListForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPlayerStats = new System.Windows.Forms.DataGridView();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbLoadingAnimation = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shirtnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yellowCardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgvPlayerStats
            // 
            this.dgvPlayerStats.AllowUserToAddRows = false;
            this.dgvPlayerStats.AllowUserToDeleteRows = false;
            this.dgvPlayerStats.AutoGenerateColumns = false;
            this.dgvPlayerStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.shirtnumberDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.goalNumberDataGridViewTextBoxColumn,
            this.yellowCardNumberDataGridViewTextBoxColumn,
            this.Picture});
            this.dgvPlayerStats.DataSource = this.playerBindingSource;
            resources.ApplyResources(this.dgvPlayerStats, "dgvPlayerStats");
            this.dgvPlayerStats.Name = "dgvPlayerStats";
            this.dgvPlayerStats.ReadOnly = true;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(DataAccessLayer.Model.Player);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // pbLoadingAnimation
            // 
            this.pbLoadingAnimation.Image = global::WindowsForms.Properties.Resources.loadingAnimation;
            resources.ApplyResources(this.pbLoadingAnimation, "pbLoadingAnimation");
            this.pbLoadingAnimation.Name = "pbLoadingAnimation";
            this.pbLoadingAnimation.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shirtnumberDataGridViewTextBoxColumn
            // 
            this.shirtnumberDataGridViewTextBoxColumn.DataPropertyName = "shirt_number";
            resources.ApplyResources(this.shirtnumberDataGridViewTextBoxColumn, "shirtnumberDataGridViewTextBoxColumn");
            this.shirtnumberDataGridViewTextBoxColumn.Name = "shirtnumberDataGridViewTextBoxColumn";
            this.shirtnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            resources.ApplyResources(this.positionDataGridViewTextBoxColumn, "positionDataGridViewTextBoxColumn");
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goalNumberDataGridViewTextBoxColumn
            // 
            this.goalNumberDataGridViewTextBoxColumn.DataPropertyName = "GoalNumber";
            resources.ApplyResources(this.goalNumberDataGridViewTextBoxColumn, "goalNumberDataGridViewTextBoxColumn");
            this.goalNumberDataGridViewTextBoxColumn.Name = "goalNumberDataGridViewTextBoxColumn";
            this.goalNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yellowCardNumberDataGridViewTextBoxColumn
            // 
            this.yellowCardNumberDataGridViewTextBoxColumn.DataPropertyName = "YellowCardNumber";
            resources.ApplyResources(this.yellowCardNumberDataGridViewTextBoxColumn, "yellowCardNumberDataGridViewTextBoxColumn");
            this.yellowCardNumberDataGridViewTextBoxColumn.Name = "yellowCardNumberDataGridViewTextBoxColumn";
            this.yellowCardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            resources.ApplyResources(this.Picture, "Picture");
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            // 
            // PlayersRangListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLoadingAnimation);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvPlayerStats);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayersRangListForm";
            this.Load += new System.EventHandler(this.PlayersRangListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPlayerStats;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pbLoadingAnimation;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shirtnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yellowCardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
    }
}
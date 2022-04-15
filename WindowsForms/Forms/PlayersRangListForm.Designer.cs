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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPlayerStats = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shirtnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yellowCardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbLoadingAnimation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rang Lista / Statistika igraca";
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
            this.dgvPlayerStats.Location = new System.Drawing.Point(12, 153);
            this.dgvPlayerStats.Name = "dgvPlayerStats";
            this.dgvPlayerStats.ReadOnly = true;
            this.dgvPlayerStats.RowHeadersWidth = 62;
            this.dgvPlayerStats.Size = new System.Drawing.Size(960, 446);
            this.dgvPlayerStats.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(829, 74);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 49);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // shirtnumberDataGridViewTextBoxColumn
            // 
            this.shirtnumberDataGridViewTextBoxColumn.DataPropertyName = "shirt_number";
            this.shirtnumberDataGridViewTextBoxColumn.HeaderText = "Shirt number";
            this.shirtnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shirtnumberDataGridViewTextBoxColumn.Name = "shirtnumberDataGridViewTextBoxColumn";
            this.shirtnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.shirtnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 150;
            // 
            // goalNumberDataGridViewTextBoxColumn
            // 
            this.goalNumberDataGridViewTextBoxColumn.DataPropertyName = "GoalNumber";
            this.goalNumberDataGridViewTextBoxColumn.HeaderText = "Goal number";
            this.goalNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.goalNumberDataGridViewTextBoxColumn.Name = "goalNumberDataGridViewTextBoxColumn";
            this.goalNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.goalNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // yellowCardNumberDataGridViewTextBoxColumn
            // 
            this.yellowCardNumberDataGridViewTextBoxColumn.DataPropertyName = "YellowCardNumber";
            this.yellowCardNumberDataGridViewTextBoxColumn.HeaderText = "Yellow card number";
            this.yellowCardNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yellowCardNumberDataGridViewTextBoxColumn.Name = "yellowCardNumberDataGridViewTextBoxColumn";
            this.yellowCardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.yellowCardNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(DataAccessLayer.Model.Player);
            // 
            // pbLoadingAnimation
            // 
            this.pbLoadingAnimation.Image = global::WindowsForms.Properties.Resources.loadingAnimation;
            this.pbLoadingAnimation.Location = new System.Drawing.Point(444, 335);
            this.pbLoadingAnimation.Name = "pbLoadingAnimation";
            this.pbLoadingAnimation.Size = new System.Drawing.Size(96, 67);
            this.pbLoadingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoadingAnimation.TabIndex = 3;
            this.pbLoadingAnimation.TabStop = false;
            // 
            // PlayersRangListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 719);
            this.Controls.Add(this.pbLoadingAnimation);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvPlayerStats);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayersRangListForm";
            this.Text = "PlayersRangListForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shirtnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yellowCardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.PictureBox pbLoadingAnimation;
    }
}
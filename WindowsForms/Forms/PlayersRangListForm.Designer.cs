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
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shirtnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yellowCardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
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
            this.yellowCardNumberDataGridViewTextBoxColumn});
            this.dgvPlayerStats.DataSource = this.playerBindingSource;
            this.dgvPlayerStats.Location = new System.Drawing.Point(12, 153);
            this.dgvPlayerStats.Name = "dgvPlayerStats";
            this.dgvPlayerStats.ReadOnly = true;
            this.dgvPlayerStats.Size = new System.Drawing.Size(960, 446);
            this.dgvPlayerStats.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(829, 700);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 49);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(DataAccessLayer.Model.Player);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shirtnumberDataGridViewTextBoxColumn
            // 
            this.shirtnumberDataGridViewTextBoxColumn.DataPropertyName = "shirt_number";
            this.shirtnumberDataGridViewTextBoxColumn.HeaderText = "Shirt number";
            this.shirtnumberDataGridViewTextBoxColumn.Name = "shirtnumberDataGridViewTextBoxColumn";
            this.shirtnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goalNumberDataGridViewTextBoxColumn
            // 
            this.goalNumberDataGridViewTextBoxColumn.DataPropertyName = "GoalNumber";
            this.goalNumberDataGridViewTextBoxColumn.HeaderText = "Goal number";
            this.goalNumberDataGridViewTextBoxColumn.Name = "goalNumberDataGridViewTextBoxColumn";
            this.goalNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yellowCardNumberDataGridViewTextBoxColumn
            // 
            this.yellowCardNumberDataGridViewTextBoxColumn.DataPropertyName = "YellowCardNumber";
            this.yellowCardNumberDataGridViewTextBoxColumn.HeaderText = "Yellow card number";
            this.yellowCardNumberDataGridViewTextBoxColumn.Name = "yellowCardNumberDataGridViewTextBoxColumn";
            this.yellowCardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PlayersRangListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvPlayerStats);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayersRangListForm";
            this.Text = "PlayersRangListForm";
            this.Load += new System.EventHandler(this.PlayersRangListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
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
    }
}
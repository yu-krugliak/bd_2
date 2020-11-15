namespace LAB2
{
    partial class SearchForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxRiver = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wFPHOTODataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.wFRIVERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.riversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wFHEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wFTYPEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.riversDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterfallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterfallsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(46, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(98, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxRiver
            // 
            this.textBoxRiver.Location = new System.Drawing.Point(207, 6);
            this.textBoxRiver.Name = "textBoxRiver";
            this.textBoxRiver.Size = new System.Drawing.Size(107, 20);
            this.textBoxRiver.TabIndex = 1;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(399, 6);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(117, 20);
            this.textBoxHeight.TabIndex = 2;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(592, 6);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(111, 20);
            this.textBoxType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Річка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Висота:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(722, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(636, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wFIDDataGridViewTextBoxColumn,
            this.wFNAMEDataGridViewTextBoxColumn,
            this.wFPHOTODataGridViewImageColumn,
            this.wFRIVERIDDataGridViewTextBoxColumn,
            this.wFHEIGHTDataGridViewTextBoxColumn,
            this.wFTYPEIDDataGridViewTextBoxColumn,
            this.riversDataGridViewTextBoxColumn,
            this.typesDataGridViewTextBoxColumn,
            this.visitsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.waterfallsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1353, 704);
            this.dataGridView1.TabIndex = 9;
            // 
            // wFIDDataGridViewTextBoxColumn
            // 
            this.wFIDDataGridViewTextBoxColumn.DataPropertyName = "WF_ID";
            this.wFIDDataGridViewTextBoxColumn.HeaderText = "WF_ID";
            this.wFIDDataGridViewTextBoxColumn.Name = "wFIDDataGridViewTextBoxColumn";
            // 
            // wFNAMEDataGridViewTextBoxColumn
            // 
            this.wFNAMEDataGridViewTextBoxColumn.DataPropertyName = "WF_NAME";
            this.wFNAMEDataGridViewTextBoxColumn.HeaderText = "WF_NAME";
            this.wFNAMEDataGridViewTextBoxColumn.Name = "wFNAMEDataGridViewTextBoxColumn";
            // 
            // wFPHOTODataGridViewImageColumn
            // 
            this.wFPHOTODataGridViewImageColumn.DataPropertyName = "WF__PHOTO";
            this.wFPHOTODataGridViewImageColumn.HeaderText = "WF__PHOTO";
            this.wFPHOTODataGridViewImageColumn.Name = "wFPHOTODataGridViewImageColumn";
            // 
            // wFRIVERIDDataGridViewTextBoxColumn
            // 
            this.wFRIVERIDDataGridViewTextBoxColumn.DataPropertyName = "WF_RIVER_ID";
            this.wFRIVERIDDataGridViewTextBoxColumn.DataSource = this.riversBindingSource;
            this.wFRIVERIDDataGridViewTextBoxColumn.DisplayMember = "RV_NAME";
            this.wFRIVERIDDataGridViewTextBoxColumn.HeaderText = "WF_RIVER_ID";
            this.wFRIVERIDDataGridViewTextBoxColumn.Name = "wFRIVERIDDataGridViewTextBoxColumn";
            this.wFRIVERIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wFRIVERIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wFRIVERIDDataGridViewTextBoxColumn.ValueMember = "RV_ID";
            // 
            // riversBindingSource
            // 
            this.riversBindingSource.DataSource = typeof(LAB2.Rivers);
            // 
            // wFHEIGHTDataGridViewTextBoxColumn
            // 
            this.wFHEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WF_HEIGHT";
            this.wFHEIGHTDataGridViewTextBoxColumn.HeaderText = "WF_HEIGHT";
            this.wFHEIGHTDataGridViewTextBoxColumn.Name = "wFHEIGHTDataGridViewTextBoxColumn";
            // 
            // wFTYPEIDDataGridViewTextBoxColumn
            // 
            this.wFTYPEIDDataGridViewTextBoxColumn.DataPropertyName = "WF_TYPE_ID";
            this.wFTYPEIDDataGridViewTextBoxColumn.DataSource = this.typesBindingSource;
            this.wFTYPEIDDataGridViewTextBoxColumn.DisplayMember = "TP_NAME";
            this.wFTYPEIDDataGridViewTextBoxColumn.HeaderText = "WF_TYPE_ID";
            this.wFTYPEIDDataGridViewTextBoxColumn.Name = "wFTYPEIDDataGridViewTextBoxColumn";
            this.wFTYPEIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wFTYPEIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wFTYPEIDDataGridViewTextBoxColumn.ValueMember = "TP_ID";
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataSource = typeof(LAB2.Types);
            // 
            // riversDataGridViewTextBoxColumn
            // 
            this.riversDataGridViewTextBoxColumn.DataPropertyName = "Rivers";
            this.riversDataGridViewTextBoxColumn.HeaderText = "Rivers";
            this.riversDataGridViewTextBoxColumn.Name = "riversDataGridViewTextBoxColumn";
            this.riversDataGridViewTextBoxColumn.Visible = false;
            // 
            // typesDataGridViewTextBoxColumn
            // 
            this.typesDataGridViewTextBoxColumn.DataPropertyName = "Types";
            this.typesDataGridViewTextBoxColumn.HeaderText = "Types";
            this.typesDataGridViewTextBoxColumn.Name = "typesDataGridViewTextBoxColumn";
            this.typesDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitsDataGridViewTextBoxColumn
            // 
            this.visitsDataGridViewTextBoxColumn.DataPropertyName = "Visits";
            this.visitsDataGridViewTextBoxColumn.HeaderText = "Visits";
            this.visitsDataGridViewTextBoxColumn.Name = "visitsDataGridViewTextBoxColumn";
            this.visitsDataGridViewTextBoxColumn.Visible = false;
            // 
            // waterfallsBindingSource
            // 
            this.waterfallsBindingSource.DataSource = typeof(LAB2.Waterfalls);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxRiver);
            this.Controls.Add(this.textBoxName);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterfallsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxRiver;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource waterfallsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn wFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn wFPHOTODataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wFRIVERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource riversBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn wFHEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wFTYPEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn riversDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitsDataGridViewTextBoxColumn;
    }
}
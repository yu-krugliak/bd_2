namespace LAB2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewWaterfalls = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.TabWaterfalls = new System.Windows.Forms.TabPage();
            this.TabAnimals = new System.Windows.Forms.TabPage();
            this.dataGridViewAnimals = new System.Windows.Forms.DataGridView();
            this.TabVisits = new System.Windows.Forms.TabPage();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
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
            this.waterfallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNPHOTODataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.aNHEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSIDANIMALSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vSIDWATERFALLSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vSDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterfallsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waterfallsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaterfalls)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.TabWaterfalls.SuspendLayout();
            this.TabAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).BeginInit();
            this.TabVisits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterfallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterfallsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWaterfalls
            // 
            this.dataGridViewWaterfalls.AutoGenerateColumns = false;
            this.dataGridViewWaterfalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWaterfalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wFIDDataGridViewTextBoxColumn,
            this.wFNAMEDataGridViewTextBoxColumn,
            this.wFPHOTODataGridViewImageColumn,
            this.wFRIVERIDDataGridViewTextBoxColumn,
            this.wFHEIGHTDataGridViewTextBoxColumn,
            this.wFTYPEIDDataGridViewTextBoxColumn,
            this.riversDataGridViewTextBoxColumn,
            this.typesDataGridViewTextBoxColumn});
            this.dataGridViewWaterfalls.DataSource = this.waterfallsBindingSource;
            this.dataGridViewWaterfalls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWaterfalls.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWaterfalls.Name = "dataGridViewWaterfalls";
            this.dataGridViewWaterfalls.Size = new System.Drawing.Size(786, 394);
            this.dataGridViewWaterfalls.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemSave,
            this.ItemDelete,
            this.ItemSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ItemDelete
            // 
            this.ItemDelete.Name = "ItemDelete";
            this.ItemDelete.Size = new System.Drawing.Size(52, 20);
            this.ItemDelete.Text = "Delete";
            this.ItemDelete.Click += new System.EventHandler(this.ItemDelete_Click);
            // 
            // ItemSave
            // 
            this.ItemSave.Name = "ItemSave";
            this.ItemSave.Size = new System.Drawing.Size(43, 20);
            this.ItemSave.Text = "Save";
            this.ItemSave.Click += new System.EventHandler(this.ItemSave_Click);
            // 
            // ItemSearch
            // 
            this.ItemSearch.Name = "ItemSearch";
            this.ItemSearch.Size = new System.Drawing.Size(54, 20);
            this.ItemSearch.Text = "Search";
            this.ItemSearch.Click += new System.EventHandler(this.ItemSearch_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.TabWaterfalls);
            this.tabcontrol.Controls.Add(this.TabAnimals);
            this.tabcontrol.Controls.Add(this.TabVisits);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 24);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(800, 426);
            this.tabcontrol.TabIndex = 2;
            // 
            // TabWaterfalls
            // 
            this.TabWaterfalls.Controls.Add(this.dataGridViewWaterfalls);
            this.TabWaterfalls.Location = new System.Drawing.Point(4, 22);
            this.TabWaterfalls.Name = "TabWaterfalls";
            this.TabWaterfalls.Padding = new System.Windows.Forms.Padding(3);
            this.TabWaterfalls.Size = new System.Drawing.Size(792, 400);
            this.TabWaterfalls.TabIndex = 0;
            this.TabWaterfalls.Text = "Waterfalls";
            this.TabWaterfalls.UseVisualStyleBackColor = true;
            // 
            // TabAnimals
            // 
            this.TabAnimals.Controls.Add(this.dataGridViewAnimals);
            this.TabAnimals.Location = new System.Drawing.Point(4, 22);
            this.TabAnimals.Name = "TabAnimals";
            this.TabAnimals.Padding = new System.Windows.Forms.Padding(3);
            this.TabAnimals.Size = new System.Drawing.Size(792, 400);
            this.TabAnimals.TabIndex = 1;
            this.TabAnimals.Text = "Animals";
            this.TabAnimals.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAnimals
            // 
            this.dataGridViewAnimals.AutoGenerateColumns = false;
            this.dataGridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aNIDDataGridViewTextBoxColumn,
            this.aNNAMEDataGridViewTextBoxColumn,
            this.aNPHOTODataGridViewImageColumn,
            this.aNHEIGHTDataGridViewTextBoxColumn,
            this.aNWEIGHTDataGridViewTextBoxColumn});
            this.dataGridViewAnimals.DataSource = this.animalsBindingSource;
            this.dataGridViewAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAnimals.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAnimals.Name = "dataGridViewAnimals";
            this.dataGridViewAnimals.Size = new System.Drawing.Size(786, 394);
            this.dataGridViewAnimals.TabIndex = 0;
            this.dataGridViewAnimals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TabVisits
            // 
            this.TabVisits.Controls.Add(this.dataGridViewVisits);
            this.TabVisits.Location = new System.Drawing.Point(4, 22);
            this.TabVisits.Name = "TabVisits";
            this.TabVisits.Padding = new System.Windows.Forms.Padding(3);
            this.TabVisits.Size = new System.Drawing.Size(792, 400);
            this.TabVisits.TabIndex = 2;
            this.TabVisits.Text = "Visits";
            this.TabVisits.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.AutoGenerateColumns = false;
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vSIDDataGridViewTextBoxColumn,
            this.vSDATEDataGridViewTextBoxColumn,
            this.vSIDANIMALSDataGridViewTextBoxColumn,
            this.vSIDWATERFALLSDataGridViewTextBoxColumn,
            this.vSDESCRIPTIONDataGridViewTextBoxColumn,
            this.animalsDataGridViewTextBoxColumn,
            this.waterfallsDataGridViewTextBoxColumn});
            this.dataGridViewVisits.DataSource = this.visitsBindingSource;
            this.dataGridViewVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVisits.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.Size = new System.Drawing.Size(786, 394);
            this.dataGridViewVisits.TabIndex = 0;
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
            // waterfallsBindingSource
            // 
            this.waterfallsBindingSource.DataSource = typeof(LAB2.Waterfalls);
            // 
            // aNIDDataGridViewTextBoxColumn
            // 
            this.aNIDDataGridViewTextBoxColumn.DataPropertyName = "AN_ID";
            this.aNIDDataGridViewTextBoxColumn.HeaderText = "AN_ID";
            this.aNIDDataGridViewTextBoxColumn.Name = "aNIDDataGridViewTextBoxColumn";
            // 
            // aNNAMEDataGridViewTextBoxColumn
            // 
            this.aNNAMEDataGridViewTextBoxColumn.DataPropertyName = "AN_NAME";
            this.aNNAMEDataGridViewTextBoxColumn.HeaderText = "AN_NAME";
            this.aNNAMEDataGridViewTextBoxColumn.Name = "aNNAMEDataGridViewTextBoxColumn";
            // 
            // aNPHOTODataGridViewImageColumn
            // 
            this.aNPHOTODataGridViewImageColumn.DataPropertyName = "AN_PHOTO";
            this.aNPHOTODataGridViewImageColumn.HeaderText = "AN_PHOTO";
            this.aNPHOTODataGridViewImageColumn.Name = "aNPHOTODataGridViewImageColumn";
            // 
            // aNHEIGHTDataGridViewTextBoxColumn
            // 
            this.aNHEIGHTDataGridViewTextBoxColumn.DataPropertyName = "AN_HEIGHT";
            this.aNHEIGHTDataGridViewTextBoxColumn.HeaderText = "AN_HEIGHT";
            this.aNHEIGHTDataGridViewTextBoxColumn.Name = "aNHEIGHTDataGridViewTextBoxColumn";
            // 
            // aNWEIGHTDataGridViewTextBoxColumn
            // 
            this.aNWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "AN_WEIGHT";
            this.aNWEIGHTDataGridViewTextBoxColumn.HeaderText = "AN_WEIGHT";
            this.aNWEIGHTDataGridViewTextBoxColumn.Name = "aNWEIGHTDataGridViewTextBoxColumn";
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataSource = typeof(LAB2.Animals);
            // 
            // vSIDDataGridViewTextBoxColumn
            // 
            this.vSIDDataGridViewTextBoxColumn.DataPropertyName = "VS_ID";
            this.vSIDDataGridViewTextBoxColumn.HeaderText = "VS_ID";
            this.vSIDDataGridViewTextBoxColumn.Name = "vSIDDataGridViewTextBoxColumn";
            // 
            // vSDATEDataGridViewTextBoxColumn
            // 
            this.vSDATEDataGridViewTextBoxColumn.DataPropertyName = "VS_DATE";
            this.vSDATEDataGridViewTextBoxColumn.HeaderText = "VS_DATE";
            this.vSDATEDataGridViewTextBoxColumn.Name = "vSDATEDataGridViewTextBoxColumn";
            // 
            // vSIDANIMALSDataGridViewTextBoxColumn
            // 
            this.vSIDANIMALSDataGridViewTextBoxColumn.DataPropertyName = "VS_ID_ANIMALS";
            this.vSIDANIMALSDataGridViewTextBoxColumn.DataSource = this.animalsBindingSource;
            this.vSIDANIMALSDataGridViewTextBoxColumn.DisplayMember = "AN_NAME";
            this.vSIDANIMALSDataGridViewTextBoxColumn.HeaderText = "VS_ID_ANIMALS";
            this.vSIDANIMALSDataGridViewTextBoxColumn.Name = "vSIDANIMALSDataGridViewTextBoxColumn";
            this.vSIDANIMALSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vSIDANIMALSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vSIDANIMALSDataGridViewTextBoxColumn.ValueMember = "AN_ID";
            // 
            // vSIDWATERFALLSDataGridViewTextBoxColumn
            // 
            this.vSIDWATERFALLSDataGridViewTextBoxColumn.DataPropertyName = "VS_ID_WATERFALLS";
            this.vSIDWATERFALLSDataGridViewTextBoxColumn.DataSource = this.waterfallsBindingSource;
            this.vSIDWATERFALLSDataGridViewTextBoxColumn.DisplayMember = "WF_NAME";
            this.vSIDWATERFALLSDataGridViewTextBoxColumn.HeaderText = "VS_ID_WATERFALLS";
            this.vSIDWATERFALLSDataGridViewTextBoxColumn.Name = "vSIDWATERFALLSDataGridViewTextBoxColumn";
            this.vSIDWATERFALLSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vSIDWATERFALLSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vSIDWATERFALLSDataGridViewTextBoxColumn.ValueMember = "WF_ID";
            // 
            // vSDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.vSDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "VS_DESCRIPTION";
            this.vSDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "VS_DESCRIPTION";
            this.vSDESCRIPTIONDataGridViewTextBoxColumn.Name = "vSDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // animalsDataGridViewTextBoxColumn
            // 
            this.animalsDataGridViewTextBoxColumn.DataPropertyName = "Animals";
            this.animalsDataGridViewTextBoxColumn.HeaderText = "Animals";
            this.animalsDataGridViewTextBoxColumn.Name = "animalsDataGridViewTextBoxColumn";
            this.animalsDataGridViewTextBoxColumn.Visible = false;
            // 
            // waterfallsDataGridViewTextBoxColumn
            // 
            this.waterfallsDataGridViewTextBoxColumn.DataPropertyName = "Waterfalls";
            this.waterfallsDataGridViewTextBoxColumn.HeaderText = "Waterfalls";
            this.waterfallsDataGridViewTextBoxColumn.Name = "waterfallsDataGridViewTextBoxColumn";
            this.waterfallsDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataSource = typeof(LAB2.Visits);
            // 
            // waterfallsBindingSource1
            // 
            this.waterfallsBindingSource1.DataSource = typeof(LAB2.Waterfalls);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaterfalls)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabcontrol.ResumeLayout(false);
            this.TabWaterfalls.ResumeLayout(false);
            this.TabAnimals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).EndInit();
            this.TabVisits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterfallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterfallsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWaterfalls;
        private System.Windows.Forms.BindingSource waterfallsBindingSource1;
        private System.Windows.Forms.BindingSource waterfallsBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItemSave;
        private System.Windows.Forms.ToolStripMenuItem ItemDelete;
        private System.Windows.Forms.ToolStripMenuItem ItemSearch;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage TabWaterfalls;
        private System.Windows.Forms.TabPage TabAnimals;
        private System.Windows.Forms.DataGridView dataGridViewAnimals;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn aNPHOTODataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNHEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private System.Windows.Forms.TabPage TabVisits;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private System.Windows.Forms.BindingSource visitsBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn vSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vSDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vSIDANIMALSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vSIDWATERFALLSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vSDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterfallsDataGridViewTextBoxColumn;
    }
}


namespace EDG_Tes102
{
	partial class Form1
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cODCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nOMCOMPLETODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nOMUSUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nROCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dSCTIPOCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.database1DataSet = new EDG_Tes102.Database1DataSet();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.cODCLIENTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nOMUSUALDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nOMCOMPLETODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nROCPFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dTEXCLUIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cODTIPOCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tBCLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.viewTableAdapter = new EDG_Tes102.Database1DataSetTableAdapters.ViewTableAdapter();
			this.tB_CLIENTETableAdapter = new EDG_Tes102.Database1DataSetTableAdapters.TB_CLIENTETableAdapter();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBCLIENTEBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(13, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(927, 489);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(919, 460);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "List View";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCLIENTEDataGridViewTextBoxColumn,
            this.nOMCOMPLETODataGridViewTextBoxColumn,
            this.nOMUSUALDataGridViewTextBoxColumn,
            this.nROCPFDataGridViewTextBoxColumn,
            this.dSCTIPOCLIENTEDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.viewBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(7, 7);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(906, 447);
			this.dataGridView1.TabIndex = 0;
			// 
			// cODCLIENTEDataGridViewTextBoxColumn
			// 
			this.cODCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "COD_CLIENTE";
			this.cODCLIENTEDataGridViewTextBoxColumn.HeaderText = "COD_CLIENTE";
			this.cODCLIENTEDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.cODCLIENTEDataGridViewTextBoxColumn.Name = "cODCLIENTEDataGridViewTextBoxColumn";
			this.cODCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
			this.cODCLIENTEDataGridViewTextBoxColumn.Width = 125;
			// 
			// nOMCOMPLETODataGridViewTextBoxColumn
			// 
			this.nOMCOMPLETODataGridViewTextBoxColumn.DataPropertyName = "NOM_COMPLETO";
			this.nOMCOMPLETODataGridViewTextBoxColumn.HeaderText = "NOM_COMPLETO";
			this.nOMCOMPLETODataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nOMCOMPLETODataGridViewTextBoxColumn.Name = "nOMCOMPLETODataGridViewTextBoxColumn";
			this.nOMCOMPLETODataGridViewTextBoxColumn.ReadOnly = true;
			this.nOMCOMPLETODataGridViewTextBoxColumn.Width = 125;
			// 
			// nOMUSUALDataGridViewTextBoxColumn
			// 
			this.nOMUSUALDataGridViewTextBoxColumn.DataPropertyName = "NOM_USUAL";
			this.nOMUSUALDataGridViewTextBoxColumn.HeaderText = "NOM_USUAL";
			this.nOMUSUALDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nOMUSUALDataGridViewTextBoxColumn.Name = "nOMUSUALDataGridViewTextBoxColumn";
			this.nOMUSUALDataGridViewTextBoxColumn.ReadOnly = true;
			this.nOMUSUALDataGridViewTextBoxColumn.Width = 125;
			// 
			// nROCPFDataGridViewTextBoxColumn
			// 
			this.nROCPFDataGridViewTextBoxColumn.DataPropertyName = "NRO_CPF";
			this.nROCPFDataGridViewTextBoxColumn.HeaderText = "NRO_CPF";
			this.nROCPFDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nROCPFDataGridViewTextBoxColumn.Name = "nROCPFDataGridViewTextBoxColumn";
			this.nROCPFDataGridViewTextBoxColumn.ReadOnly = true;
			this.nROCPFDataGridViewTextBoxColumn.Width = 125;
			// 
			// dSCTIPOCLIENTEDataGridViewTextBoxColumn
			// 
			this.dSCTIPOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "DSC_TIPO_CLIENTE";
			this.dSCTIPOCLIENTEDataGridViewTextBoxColumn.HeaderText = "DSC_TIPO_CLIENTE";
			this.dSCTIPOCLIENTEDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dSCTIPOCLIENTEDataGridViewTextBoxColumn.Name = "dSCTIPOCLIENTEDataGridViewTextBoxColumn";
			this.dSCTIPOCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
			this.dSCTIPOCLIENTEDataGridViewTextBoxColumn.Width = 125;
			// 
			// viewBindingSource
			// 
			this.viewBindingSource.DataMember = "View";
			this.viewBindingSource.DataSource = this.database1DataSet;
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(919, 460);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "List Edit / Delete / Insert";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToOrderColumns = true;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCLIENTEDataGridViewTextBoxColumn1,
            this.nOMUSUALDataGridViewTextBoxColumn1,
            this.nOMCOMPLETODataGridViewTextBoxColumn1,
            this.nROCPFDataGridViewTextBoxColumn1,
            this.dTEXCLUIDODataGridViewTextBoxColumn,
            this.cODTIPOCLIENTEDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.tBCLIENTEBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(7, 4);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(906, 450);
			this.dataGridView2.TabIndex = 0;
			// 
			// cODCLIENTEDataGridViewTextBoxColumn1
			// 
			this.cODCLIENTEDataGridViewTextBoxColumn1.DataPropertyName = "COD_CLIENTE";
			this.cODCLIENTEDataGridViewTextBoxColumn1.HeaderText = "COD_CLIENTE";
			this.cODCLIENTEDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.cODCLIENTEDataGridViewTextBoxColumn1.Name = "cODCLIENTEDataGridViewTextBoxColumn1";
			this.cODCLIENTEDataGridViewTextBoxColumn1.ReadOnly = true;
			this.cODCLIENTEDataGridViewTextBoxColumn1.Width = 125;
			// 
			// nOMUSUALDataGridViewTextBoxColumn1
			// 
			this.nOMUSUALDataGridViewTextBoxColumn1.DataPropertyName = "NOM_USUAL";
			this.nOMUSUALDataGridViewTextBoxColumn1.HeaderText = "NOM_USUAL";
			this.nOMUSUALDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.nOMUSUALDataGridViewTextBoxColumn1.Name = "nOMUSUALDataGridViewTextBoxColumn1";
			this.nOMUSUALDataGridViewTextBoxColumn1.Width = 125;
			// 
			// nOMCOMPLETODataGridViewTextBoxColumn1
			// 
			this.nOMCOMPLETODataGridViewTextBoxColumn1.DataPropertyName = "NOM_COMPLETO";
			this.nOMCOMPLETODataGridViewTextBoxColumn1.HeaderText = "NOM_COMPLETO";
			this.nOMCOMPLETODataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.nOMCOMPLETODataGridViewTextBoxColumn1.Name = "nOMCOMPLETODataGridViewTextBoxColumn1";
			this.nOMCOMPLETODataGridViewTextBoxColumn1.Width = 125;
			// 
			// nROCPFDataGridViewTextBoxColumn1
			// 
			this.nROCPFDataGridViewTextBoxColumn1.DataPropertyName = "NRO_CPF";
			this.nROCPFDataGridViewTextBoxColumn1.HeaderText = "NRO_CPF";
			this.nROCPFDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.nROCPFDataGridViewTextBoxColumn1.Name = "nROCPFDataGridViewTextBoxColumn1";
			this.nROCPFDataGridViewTextBoxColumn1.Width = 125;
			// 
			// dTEXCLUIDODataGridViewTextBoxColumn
			// 
			this.dTEXCLUIDODataGridViewTextBoxColumn.DataPropertyName = "DT_EXCLUIDO";
			this.dTEXCLUIDODataGridViewTextBoxColumn.HeaderText = "DT_EXCLUIDO";
			this.dTEXCLUIDODataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dTEXCLUIDODataGridViewTextBoxColumn.Name = "dTEXCLUIDODataGridViewTextBoxColumn";
			this.dTEXCLUIDODataGridViewTextBoxColumn.Width = 125;
			// 
			// cODTIPOCLIENTEDataGridViewTextBoxColumn
			// 
			this.cODTIPOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "COD_TIPO_CLIENTE";
			this.cODTIPOCLIENTEDataGridViewTextBoxColumn.HeaderText = "COD_TIPO_CLIENTE";
			this.cODTIPOCLIENTEDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.cODTIPOCLIENTEDataGridViewTextBoxColumn.Name = "cODTIPOCLIENTEDataGridViewTextBoxColumn";
			this.cODTIPOCLIENTEDataGridViewTextBoxColumn.Width = 125;
			// 
			// tBCLIENTEBindingSource
			// 
			this.tBCLIENTEBindingSource.DataMember = "TB_CLIENTE";
			this.tBCLIENTEBindingSource.DataSource = this.database1DataSet;
			// 
			// viewTableAdapter
			// 
			this.viewTableAdapter.ClearBeforeFill = true;
			// 
			// tB_CLIENTETableAdapter
			// 
			this.tB_CLIENTETableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 514);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form DGM";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBCLIENTEBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabPage tabPage2;
		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource viewBindingSource;
		private Database1DataSetTableAdapters.ViewTableAdapter viewTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn cODCLIENTEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nOMCOMPLETODataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nOMUSUALDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nROCPFDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dSCTIPOCLIENTEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.BindingSource tBCLIENTEBindingSource;
		private Database1DataSetTableAdapters.TB_CLIENTETableAdapter tB_CLIENTETableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn cODCLIENTEDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nOMUSUALDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nOMCOMPLETODataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nROCPFDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dTEXCLUIDODataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cODTIPOCLIENTEDataGridViewTextBoxColumn;
	}
}


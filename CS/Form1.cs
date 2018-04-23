using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;


namespace WindowsApplication409
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAddress;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCity;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCompanyName;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowContactName;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowContactTitle;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCountry;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCustomerID;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFax;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPostalCode;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRegion;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow multiEditorRow1;
        private MultiEditorRowProperties multiEditorRowProperties1;
        private MultiEditorRowProperties multiEditorRowProperties2;
        private nwindDataSet nwindDataSet;
        private BindingSource customersBindingSource;
        private WindowsApplication409.nwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private IContainer components;

		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.multiEditorRowProperties1 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.multiEditorRowProperties2 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WindowsApplication409.nwindDataSet();
            this.rowAddress = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCity = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCompanyName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowContactTitle = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowContactName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCountry = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFax = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.multiEditorRow1 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.rowCustomerID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPostalCode = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRegion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.customersTableAdapter = new WindowsApplication409.nwindDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // multiEditorRowProperties1
            // 
            this.multiEditorRowProperties1.Caption = "Company";
            this.multiEditorRowProperties1.FieldName = "CompanyName";
            // 
            // multiEditorRowProperties2
            // 
            this.multiEditorRowProperties2.Caption = "Phone";
            this.multiEditorRowProperties2.FieldName = "Phone";
            // 
            // vGridControl1
            // 
            this.vGridControl1.DataSource = this.customersBindingSource;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(2, 12);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 127;
            this.vGridControl1.RowHeaderWidth = 73;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowAddress,
            this.rowContactTitle,
            this.rowPostalCode});
            this.vGridControl1.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways;
            this.vGridControl1.Size = new System.Drawing.Size(448, 400);
            this.vGridControl1.TabIndex = 0;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rowAddress
            // 
            this.rowAddress.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowCity});
            this.rowAddress.Height = 16;
            this.rowAddress.Name = "rowAddress";
            this.rowAddress.Properties.Caption = "Address";
            this.rowAddress.Properties.FieldName = "Address";
            // 
            // rowCity
            // 
            this.rowCity.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowCompanyName});
            this.rowCity.Name = "rowCity";
            this.rowCity.Properties.Caption = "City";
            this.rowCity.Properties.FieldName = "City";
            // 
            // rowCompanyName
            // 
            this.rowCompanyName.Name = "rowCompanyName";
            this.rowCompanyName.Properties.Caption = "CompanyName";
            this.rowCompanyName.Properties.FieldName = "CompanyName";
            // 
            // rowContactTitle
            // 
            this.rowContactTitle.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowContactName,
            this.rowCountry,
            this.rowCustomerID});
            this.rowContactTitle.Name = "rowContactTitle";
            this.rowContactTitle.Properties.Caption = "ContactTitle";
            this.rowContactTitle.Properties.FieldName = "ContactTitle";
            // 
            // rowContactName
            // 
            this.rowContactName.Name = "rowContactName";
            this.rowContactName.Properties.Caption = "ContactName";
            this.rowContactName.Properties.FieldName = "ContactName";
            // 
            // rowCountry
            // 
            this.rowCountry.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowFax});
            this.rowCountry.Name = "rowCountry";
            this.rowCountry.Properties.Caption = "Country";
            this.rowCountry.Properties.FieldName = "Country";
            // 
            // rowFax
            // 
            this.rowFax.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.multiEditorRow1});
            this.rowFax.Name = "rowFax";
            this.rowFax.Properties.Caption = "Fax";
            this.rowFax.Properties.FieldName = "Fax";
            // 
            // multiEditorRow1
            // 
            this.multiEditorRow1.Name = "multiEditorRow1";
            this.multiEditorRow1.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.multiEditorRowProperties1,
            this.multiEditorRowProperties2});
            // 
            // rowCustomerID
            // 
            this.rowCustomerID.Name = "rowCustomerID";
            this.rowCustomerID.Properties.Caption = "CustomerID";
            this.rowCustomerID.Properties.FieldName = "CustomerID";
            // 
            // rowPostalCode
            // 
            this.rowPostalCode.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowRegion});
            this.rowPostalCode.Name = "rowPostalCode";
            this.rowPostalCode.Properties.Caption = "PostalCode";
            this.rowPostalCode.Properties.FieldName = "PostalCode";
            // 
            // rowRegion
            // 
            this.rowRegion.Name = "rowRegion";
            this.rowRegion.Properties.Caption = "Region";
            this.rowRegion.Properties.FieldName = "Region";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(160, 424);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "FindRow";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(515, 462);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.vGridControl1);
            this.Name = "Form1";
            this.Text = "How to obtain a row object by FieldName in the XtraVerticalGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);
           
			
		}

		private void simpleButton1_Click(object sender, System.EventArgs e) {
			vGridControl1.RowsIterator.DoOperation(new FindRowByFieldNameOperation("Phone"))        ;
			
		}
	}
	public class FindRowByFieldNameOperation : RowOperation{
		string fieldName;
		bool isRowFound;
		public FindRowByFieldNameOperation (string fieldName) : base () {
			this.fieldName = fieldName;
			isRowFound = false;
		}

		private void FocusRow(BaseRow row){
			row.Grid.MakeRowVisible(row);
			row.Grid.FocusedRow = row;
			isRowFound = true;
		}

		public override void Execute(BaseRow row) {
			if (row is MultiEditorRow)
				if ((row as MultiEditorRow).PropertiesCollection[fieldName] != null) {
					MultiEditorRow mRow = row as MultiEditorRow;
					FocusRow(row);
					row.Grid.FocusedRecordCellIndex = mRow.PropertiesCollection.IndexOf(mRow.PropertiesCollection[fieldName]);
				}
				else        	
					if (row.Properties.FieldName == fieldName) 
					FocusRow(row);				
		}

		public override bool CanContinueIteration(BaseRow row) {
			return !isRowFound;
		}
	}
}

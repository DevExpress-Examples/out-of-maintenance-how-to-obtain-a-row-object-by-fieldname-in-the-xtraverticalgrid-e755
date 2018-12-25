Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows


Namespace WindowsApplication409
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private rowAddress As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCity As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCompanyName As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowContactName As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowContactTitle As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCountry As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCustomerID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowFax As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowPostalCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowRegion As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private multiEditorRow1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private multiEditorRowProperties1 As MultiEditorRowProperties
		Private multiEditorRowProperties2 As MultiEditorRowProperties
		Private nwindDataSet As nwindDataSet
		Private customersBindingSource As BindingSource
        Private customersTableAdapter As nwindDataSetTableAdapters.CustomersTableAdapter
        Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.multiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Me.multiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New nwindDataSet()
            Me.rowAddress = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCity = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCompanyName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowContactTitle = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowContactName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCountry = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowFax = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.multiEditorRow1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
			Me.rowCustomerID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowPostalCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowRegion = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.customersTableAdapter = New nwindDataSetTableAdapters.CustomersTableAdapter()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' multiEditorRowProperties1
			' 
			Me.multiEditorRowProperties1.Caption = "Company"
			Me.multiEditorRowProperties1.FieldName = "CompanyName"
			' 
			' multiEditorRowProperties2
			' 
			Me.multiEditorRowProperties2.Caption = "Phone"
			Me.multiEditorRowProperties2.FieldName = "Phone"
			' 
			' vGridControl1
			' 
			Me.vGridControl1.DataSource = Me.customersBindingSource
			Me.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
			Me.vGridControl1.Location = New System.Drawing.Point(2, 12)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.RecordWidth = 127
			Me.vGridControl1.RowHeaderWidth = 73
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowAddress, Me.rowContactTitle, Me.rowPostalCode})
			Me.vGridControl1.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways
			Me.vGridControl1.Size = New System.Drawing.Size(448, 400)
			Me.vGridControl1.TabIndex = 0
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' rowAddress
			' 
			Me.rowAddress.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowCity})
			Me.rowAddress.Height = 16
			Me.rowAddress.Name = "rowAddress"
			Me.rowAddress.Properties.Caption = "Address"
			Me.rowAddress.Properties.FieldName = "Address"
			' 
			' rowCity
			' 
			Me.rowCity.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowCompanyName})
			Me.rowCity.Name = "rowCity"
			Me.rowCity.Properties.Caption = "City"
			Me.rowCity.Properties.FieldName = "City"
			' 
			' rowCompanyName
			' 
			Me.rowCompanyName.Name = "rowCompanyName"
			Me.rowCompanyName.Properties.Caption = "CompanyName"
			Me.rowCompanyName.Properties.FieldName = "CompanyName"
			' 
			' rowContactTitle
			' 
			Me.rowContactTitle.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowContactName, Me.rowCountry, Me.rowCustomerID})
			Me.rowContactTitle.Name = "rowContactTitle"
			Me.rowContactTitle.Properties.Caption = "ContactTitle"
			Me.rowContactTitle.Properties.FieldName = "ContactTitle"
			' 
			' rowContactName
			' 
			Me.rowContactName.Name = "rowContactName"
			Me.rowContactName.Properties.Caption = "ContactName"
			Me.rowContactName.Properties.FieldName = "ContactName"
			' 
			' rowCountry
			' 
			Me.rowCountry.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowFax})
			Me.rowCountry.Name = "rowCountry"
			Me.rowCountry.Properties.Caption = "Country"
			Me.rowCountry.Properties.FieldName = "Country"
			' 
			' rowFax
			' 
			Me.rowFax.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.multiEditorRow1})
			Me.rowFax.Name = "rowFax"
			Me.rowFax.Properties.Caption = "Fax"
			Me.rowFax.Properties.FieldName = "Fax"
			' 
			' multiEditorRow1
			' 
			Me.multiEditorRow1.Name = "multiEditorRow1"
			Me.multiEditorRow1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() { Me.multiEditorRowProperties1, Me.multiEditorRowProperties2})
			' 
			' rowCustomerID
			' 
			Me.rowCustomerID.Name = "rowCustomerID"
			Me.rowCustomerID.Properties.Caption = "CustomerID"
			Me.rowCustomerID.Properties.FieldName = "CustomerID"
			' 
			' rowPostalCode
			' 
			Me.rowPostalCode.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowRegion})
			Me.rowPostalCode.Name = "rowPostalCode"
			Me.rowPostalCode.Properties.Caption = "PostalCode"
			Me.rowPostalCode.Properties.FieldName = "PostalCode"
			' 
			' rowRegion
			' 
			Me.rowRegion.Name = "rowRegion"
			Me.rowRegion.Properties.Caption = "Region"
			Me.rowRegion.Properties.FieldName = "Region"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(160, 424)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "FindRow"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(515, 462)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.vGridControl1)
			Me.Name = "Form1"
			Me.Text = "How to obtain a row object by FieldName in the XtraVerticalGrid"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)


		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			vGridControl1.RowsIterator.DoOperation(New FindRowByFieldNameOperation("Phone"))

		End Sub
	End Class
	Public Class FindRowByFieldNameOperation
		Inherits RowOperation
		Private fieldName As String
		Private isRowFound As Boolean
		Public Sub New(ByVal fieldName As String)
			MyBase.New()
			Me.fieldName = fieldName
			isRowFound = False
		End Sub

		Private Sub FocusRow(ByVal row As BaseRow)
			row.Grid.MakeRowVisible(row)
			row.Grid.FocusedRow = row
			isRowFound = True
		End Sub

		Public Overrides Sub Execute(ByVal row As BaseRow)
			If TypeOf row Is MultiEditorRow Then
				If (TryCast(row, MultiEditorRow)).PropertiesCollection(fieldName) IsNot Nothing Then
					Dim mRow As MultiEditorRow = TryCast(row, MultiEditorRow)
					FocusRow(row)
					row.Grid.FocusedRecordCellIndex = mRow.PropertiesCollection.IndexOf(mRow.PropertiesCollection(fieldName))
				Else
					If row.Properties.FieldName = fieldName Then
					FocusRow(row)
					End If
				End If
			End If
		End Sub

		Public Overrides Function CanContinueIteration(ByVal row As BaseRow) As Boolean
			Return Not isRowFound
		End Function
	End Class
End Namespace

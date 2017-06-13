namespace GSMForms
{
    partial class frmItemsList
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridVwMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckisActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpUNI = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsUnit = new System.Windows.Forms.BindingSource(this.components);
            this.colVatID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpVAT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsVat = new System.Windows.Forms.BindingSource(this.components);
            this.colCostPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCostPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricce2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricce3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricce4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricce5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemMaxDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlertMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandNameID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckisActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpUNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpVAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnUpdate);
            this.panelControl1.Controls.Add(this.btnInsert);
            this.panelControl1.Controls.Add(this.btnLoad);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(156, 734);
            this.panelControl1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Διαγραφή";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(9, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Μεταβολή";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(9, 107);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(124, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Εισαγωγή";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(8, 77);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Φόρτωση";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(ViewModels.vmItem);
            // 
            // gridMain
            // 
            this.gridMain.DataSource = this.bsMain;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(156, 0);
            this.gridMain.MainView = this.gridVwMain;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpUNI,
            this.repositoryItemCheckisActive,
            this.repositoryItemLookUpVAT});
            this.gridMain.Size = new System.Drawing.Size(1190, 734);
            this.gridMain.TabIndex = 4;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwMain});
            // 
            // gridVwMain
            // 
            this.gridVwMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemID,
            this.colCode,
            this.colDescription,
            this.colisActive,
            this.colItemType,
            this.colUnitID,
            this.colVatID,
            this.colCostPrice,
            this.colLastCostPrice,
            this.colGrossPrice,
            this.colRetailPrice,
            this.colPricce2,
            this.colPricce3,
            this.colPricce4,
            this.colPricce5,
            this.colItemDiscount,
            this.colItemMaxDiscount,
            this.colComments,
            this.colAlertMessage,
            this.colBrandNameID,
            this.colGroupCode,
            this.colRefCode,
            this.colBarcode1,
            this.colBarcode2,
            this.colBarcode3,
            this.colDeleted,
            this.colErrorMessage,
            this.colRowStatus,
            this.colSelected,
            this.colTag,
            this.colUserID});
            this.gridVwMain.GridControl = this.gridMain;
            this.gridVwMain.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridVwMain.Name = "gridVwMain";
            this.gridVwMain.OptionsBehavior.Editable = false;
            this.gridVwMain.OptionsView.ColumnAutoWidth = false;
            this.gridVwMain.OptionsView.EnableAppearanceOddRow = true;
            // 
            // colItemID
            // 
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.Width = 78;
            // 
            // colCode
            // 
            this.colCode.Caption = "Κωδικός";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Περιγραφή";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 128;
            // 
            // colisActive
            // 
            this.colisActive.Caption = "Ενεργό";
            this.colisActive.ColumnEdit = this.repositoryItemCheckisActive;
            this.colisActive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisActive.FieldName = "isActive";
            this.colisActive.Name = "colisActive";
            this.colisActive.Visible = true;
            this.colisActive.VisibleIndex = 2;
            this.colisActive.Width = 107;
            // 
            // repositoryItemCheckisActive
            // 
            this.repositoryItemCheckisActive.AutoHeight = false;
            this.repositoryItemCheckisActive.Name = "repositoryItemCheckisActive";
            // 
            // colItemType
            // 
            this.colItemType.Caption = "Τύπος Είδους";
            this.colItemType.FieldName = "ItemType";
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 3;
            this.colItemType.Width = 83;
            // 
            // colUnitID
            // 
            this.colUnitID.Caption = "Μονάδα Μέτρησης";
            this.colUnitID.ColumnEdit = this.repositoryItemLookUpUNI;
            this.colUnitID.FieldName = "UnitID";
            this.colUnitID.Name = "colUnitID";
            this.colUnitID.OptionsColumn.ReadOnly = true;
            this.colUnitID.Visible = true;
            this.colUnitID.VisibleIndex = 4;
            this.colUnitID.Width = 150;
            // 
            // repositoryItemLookUpUNI
            // 
            this.repositoryItemLookUpUNI.AutoHeight = false;
            this.repositoryItemLookUpUNI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpUNI.DataSource = this.bsUnit;
            this.repositoryItemLookUpUNI.DisplayMember = "Description";
            this.repositoryItemLookUpUNI.Name = "repositoryItemLookUpUNI";
            this.repositoryItemLookUpUNI.ValueMember = "UnitID";
            // 
            // bsUnit
            // 
            this.bsUnit.DataSource = typeof(ViewModels.vmUnit);
            // 
            // colVatID
            // 
            this.colVatID.Caption = "Κατ. ΦΠΑ";
            this.colVatID.ColumnEdit = this.repositoryItemLookUpVAT;
            this.colVatID.FieldName = "VatID";
            this.colVatID.Name = "colVatID";
            this.colVatID.Visible = true;
            this.colVatID.VisibleIndex = 5;
            this.colVatID.Width = 113;
            // 
            // repositoryItemLookUpVAT
            // 
            this.repositoryItemLookUpVAT.AutoHeight = false;
            this.repositoryItemLookUpVAT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpVAT.DataSource = this.bsVat;
            this.repositoryItemLookUpVAT.DisplayMember = "Description";
            this.repositoryItemLookUpVAT.Name = "repositoryItemLookUpVAT";
            this.repositoryItemLookUpVAT.ValueMember = "VatID";
            // 
            // bsVat
            // 
            this.bsVat.DataSource = typeof(ViewModels.vmVat);
            // 
            // colCostPrice
            // 
            this.colCostPrice.Caption = "Πρότυπο Κόσατος";
            this.colCostPrice.FieldName = "CostPrice";
            this.colCostPrice.Name = "colCostPrice";
            this.colCostPrice.Width = 68;
            // 
            // colLastCostPrice
            // 
            this.colLastCostPrice.Caption = "Τιμή Αγοράς";
            this.colLastCostPrice.FieldName = "LastCostPrice";
            this.colLastCostPrice.Name = "colLastCostPrice";
            this.colLastCostPrice.Width = 91;
            // 
            // colGrossPrice
            // 
            this.colGrossPrice.Caption = "Τιιμή Χονδρικής";
            this.colGrossPrice.FieldName = "GrossPrice";
            this.colGrossPrice.Name = "colGrossPrice";
            this.colGrossPrice.Visible = true;
            this.colGrossPrice.VisibleIndex = 6;
            this.colGrossPrice.Width = 94;
            // 
            // colRetailPrice
            // 
            this.colRetailPrice.Caption = "Τιμή Λιανικής";
            this.colRetailPrice.FieldName = "RetailPrice";
            this.colRetailPrice.Name = "colRetailPrice";
            this.colRetailPrice.Visible = true;
            this.colRetailPrice.VisibleIndex = 7;
            this.colRetailPrice.Width = 83;
            // 
            // colPricce2
            // 
            this.colPricce2.Caption = "Τιμή 2";
            this.colPricce2.FieldName = "Pricce2";
            this.colPricce2.Name = "colPricce2";
            this.colPricce2.Width = 54;
            // 
            // colPricce3
            // 
            this.colPricce3.Caption = "Τιμή 3";
            this.colPricce3.FieldName = "Pricce3";
            this.colPricce3.Name = "colPricce3";
            this.colPricce3.Width = 54;
            // 
            // colPricce4
            // 
            this.colPricce4.Caption = "Τιμή 4";
            this.colPricce4.FieldName = "Pricce4";
            this.colPricce4.Name = "colPricce4";
            this.colPricce4.Width = 54;
            // 
            // colPricce5
            // 
            this.colPricce5.Caption = "Τιμή 5";
            this.colPricce5.FieldName = "Pricce5";
            this.colPricce5.Name = "colPricce5";
            this.colPricce5.Width = 54;
            // 
            // colItemDiscount
            // 
            this.colItemDiscount.Caption = "Εκπτωση Είδους";
            this.colItemDiscount.FieldName = "ItemDiscount";
            this.colItemDiscount.Name = "colItemDiscount";
            this.colItemDiscount.Width = 86;
            // 
            // colItemMaxDiscount
            // 
            this.colItemMaxDiscount.Caption = "Μέγιστη Εκπτωση Είδους";
            this.colItemMaxDiscount.FieldName = "ItemMaxDiscount";
            this.colItemMaxDiscount.Name = "colItemMaxDiscount";
            this.colItemMaxDiscount.Width = 109;
            // 
            // colComments
            // 
            this.colComments.Caption = "Σχόλια";
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
            this.colComments.Width = 70;
            // 
            // colAlertMessage
            // 
            this.colAlertMessage.Caption = "Μύνημα Τιμολόγησης";
            this.colAlertMessage.FieldName = "AlertMessage";
            this.colAlertMessage.Name = "colAlertMessage";
            this.colAlertMessage.Width = 88;
            // 
            // colBrandNameID
            // 
            this.colBrandNameID.Caption = "Οίκος";
            this.colBrandNameID.FieldName = "BrandNameID";
            this.colBrandNameID.Name = "colBrandNameID";
            this.colBrandNameID.Visible = true;
            this.colBrandNameID.VisibleIndex = 8;
            this.colBrandNameID.Width = 92;
            // 
            // colGroupCode
            // 
            this.colGroupCode.Caption = "Κωδικός Ομαδοποιήσης";
            this.colGroupCode.FieldName = "GroupCode";
            this.colGroupCode.Name = "colGroupCode";
            this.colGroupCode.Visible = true;
            this.colGroupCode.VisibleIndex = 9;
            this.colGroupCode.Width = 131;
            // 
            // colRefCode
            // 
            this.colRefCode.Caption = "Κωδικός Αναφοράς";
            this.colRefCode.FieldName = "RefCode";
            this.colRefCode.Name = "colRefCode";
            this.colRefCode.Visible = true;
            this.colRefCode.VisibleIndex = 10;
            this.colRefCode.Width = 112;
            // 
            // colBarcode1
            // 
            this.colBarcode1.Caption = "Barcode 1";
            this.colBarcode1.FieldName = "Barcode1";
            this.colBarcode1.Name = "colBarcode1";
            this.colBarcode1.Visible = true;
            this.colBarcode1.VisibleIndex = 11;
            this.colBarcode1.Width = 68;
            // 
            // colBarcode2
            // 
            this.colBarcode2.Caption = "Barcode 2";
            this.colBarcode2.FieldName = "Barcode2";
            this.colBarcode2.Name = "colBarcode2";
            this.colBarcode2.Visible = true;
            this.colBarcode2.VisibleIndex = 12;
            this.colBarcode2.Width = 68;
            // 
            // colBarcode3
            // 
            this.colBarcode3.Caption = "Barcode 3";
            this.colBarcode3.FieldName = "Barcode3";
            this.colBarcode3.Name = "colBarcode3";
            this.colBarcode3.Visible = true;
            this.colBarcode3.VisibleIndex = 13;
            this.colBarcode3.Width = 68;
            // 
            // colDeleted
            // 
            this.colDeleted.FieldName = "Deleted";
            this.colDeleted.Name = "colDeleted";
            this.colDeleted.Width = 57;
            // 
            // colErrorMessage
            // 
            this.colErrorMessage.FieldName = "ErrorMessage";
            this.colErrorMessage.Name = "colErrorMessage";
            this.colErrorMessage.Width = 89;
            // 
            // colRowStatus
            // 
            this.colRowStatus.FieldName = "RowStatus";
            this.colRowStatus.Name = "colRowStatus";
            // 
            // colSelected
            // 
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Width = 61;
            // 
            // colTag
            // 
            this.colTag.FieldName = "Tag";
            this.colTag.Name = "colTag";
            this.colTag.Width = 38;
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            // 
            // frmItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 734);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmItemsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Είδη - Λίστα";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckisActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpUNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpVAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.BindingSource bsMain;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colisActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckisActive;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpUNI;
        private DevExpress.XtraGrid.Columns.GridColumn colVatID;
        private DevExpress.XtraGrid.Columns.GridColumn colCostPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCostPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPricce2;
        private DevExpress.XtraGrid.Columns.GridColumn colPricce3;
        private DevExpress.XtraGrid.Columns.GridColumn colPricce4;
        private DevExpress.XtraGrid.Columns.GridColumn colPricce5;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colItemMaxDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colAlertMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandNameID;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupCode;
        private DevExpress.XtraGrid.Columns.GridColumn colRefCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode1;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode2;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode3;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colRowStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colTag;
        private System.Windows.Forms.BindingSource bsUnit;
        private System.Windows.Forms.BindingSource bsVat;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
    }
}
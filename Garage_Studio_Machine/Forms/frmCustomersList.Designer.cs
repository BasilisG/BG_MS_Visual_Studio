namespace GSMForms
{
    partial class frmCustomersList
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
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.gridVwMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProffesionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpProffesion = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsProffesion = new System.Windows.Forms.BindingSource(this.components);
            this.colAdrStreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdrNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdrCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdrDistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdrZipCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdrPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdrPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdrPhone3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdrFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdrEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlertMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTag = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpProffesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProffesion)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(156, 761);
            this.panelControl1.TabIndex = 4;
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
            // gridMain
            // 
            this.gridMain.DataSource = this.bsMain;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(156, 0);
            this.gridMain.MainView = this.gridVwMain;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpProffesion});
            this.gridMain.Size = new System.Drawing.Size(1108, 761);
            this.gridMain.TabIndex = 5;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwMain});
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(ViewModels.vmCustomer);
            // 
            // gridVwMain
            // 
            this.gridVwMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colCode,
            this.colTaxName,
            this.colTaxNumber,
            this.colFirstName,
            this.colLastName,
            this.colProffesionID,
            this.colAdrStreet,
            this.colAdrNumber,
            this.colAdrCity,
            this.colAdrDistrict,
            this.colAdrZipCode,
            this.colAdrPhone1,
            this.colAdrPhone2,
            this.colAdrPhone3,
            this.colAdrFax,
            this.colAdrEmail,
            this.colComment,
            this.colAlertMessage,
            this.colUserID,
            this.colDeleted,
            this.colErrorMessage,
            this.colRowStatus,
            this.colSelected,
            this.colTag});
            this.gridVwMain.GridControl = this.gridMain;
            this.gridVwMain.Name = "gridVwMain";
            this.gridVwMain.OptionsBehavior.ReadOnly = true;
            this.gridVwMain.OptionsView.ColumnAutoWidth = false;
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
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
            // colTaxName
            // 
            this.colTaxName.Caption = "Φορολογική Επων.";
            this.colTaxName.FieldName = "TaxName";
            this.colTaxName.Name = "colTaxName";
            this.colTaxName.Visible = true;
            this.colTaxName.VisibleIndex = 1;
            this.colTaxName.Width = 161;
            // 
            // colTaxNumber
            // 
            this.colTaxNumber.Caption = "ΑΦΜ";
            this.colTaxNumber.FieldName = "TaxNumber";
            this.colTaxNumber.Name = "colTaxNumber";
            this.colTaxNumber.Visible = true;
            this.colTaxNumber.VisibleIndex = 2;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Όνομα";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 4;
            this.colFirstName.Width = 145;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Επώνυμο";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 3;
            this.colLastName.Width = 253;
            // 
            // colProffesionID
            // 
            this.colProffesionID.Caption = "Επάγγελμα";
            this.colProffesionID.ColumnEdit = this.repositoryItemLookUpProffesion;
            this.colProffesionID.FieldName = "ProffesionID";
            this.colProffesionID.Name = "colProffesionID";
            this.colProffesionID.Visible = true;
            this.colProffesionID.VisibleIndex = 5;
            this.colProffesionID.Width = 166;
            // 
            // repositoryItemLookUpProffesion
            // 
            this.repositoryItemLookUpProffesion.AutoHeight = false;
            this.repositoryItemLookUpProffesion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpProffesion.DataSource = this.bsProffesion;
            this.repositoryItemLookUpProffesion.DisplayMember = "Description";
            this.repositoryItemLookUpProffesion.Name = "repositoryItemLookUpProffesion";
            this.repositoryItemLookUpProffesion.ValueMember = "ProffesionID";
            // 
            // bsProffesion
            // 
            this.bsProffesion.DataSource = typeof(ViewModels.vmProffesion);
            // 
            // colAdrStreet
            // 
            this.colAdrStreet.Caption = "Οδός";
            this.colAdrStreet.FieldName = "AdrStreet";
            this.colAdrStreet.Name = "colAdrStreet";
            this.colAdrStreet.Visible = true;
            this.colAdrStreet.VisibleIndex = 6;
            this.colAdrStreet.Width = 178;
            // 
            // colAdrNumber
            // 
            this.colAdrNumber.Caption = "Αριθμός";
            this.colAdrNumber.FieldName = "AdrNumber";
            this.colAdrNumber.Name = "colAdrNumber";
            this.colAdrNumber.Visible = true;
            this.colAdrNumber.VisibleIndex = 7;
            // 
            // colAdrCity
            // 
            this.colAdrCity.Caption = "Πόλη";
            this.colAdrCity.FieldName = "AdrCity";
            this.colAdrCity.Name = "colAdrCity";
            this.colAdrCity.Visible = true;
            this.colAdrCity.VisibleIndex = 8;
            // 
            // colAdrDistrict
            // 
            this.colAdrDistrict.Caption = "Περιοχή";
            this.colAdrDistrict.FieldName = "AdrDistrict";
            this.colAdrDistrict.Name = "colAdrDistrict";
            this.colAdrDistrict.Visible = true;
            this.colAdrDistrict.VisibleIndex = 9;
            // 
            // colAdrZipCode
            // 
            this.colAdrZipCode.Caption = "ΤΚ";
            this.colAdrZipCode.FieldName = "AdrZipCode";
            this.colAdrZipCode.Name = "colAdrZipCode";
            this.colAdrZipCode.Visible = true;
            this.colAdrZipCode.VisibleIndex = 10;
            // 
            // colAdrPhone1
            // 
            this.colAdrPhone1.Caption = "Τηλέφωνο 1";
            this.colAdrPhone1.FieldName = "AdrPhone1";
            this.colAdrPhone1.Name = "colAdrPhone1";
            this.colAdrPhone1.Visible = true;
            this.colAdrPhone1.VisibleIndex = 11;
            // 
            // colAdrPhone2
            // 
            this.colAdrPhone2.Caption = "Τηλέφωνο 2";
            this.colAdrPhone2.FieldName = "AdrPhone2";
            this.colAdrPhone2.Name = "colAdrPhone2";
            this.colAdrPhone2.Visible = true;
            this.colAdrPhone2.VisibleIndex = 12;
            // 
            // colAdrPhone3
            // 
            this.colAdrPhone3.Caption = "Τηλέφωνο 3";
            this.colAdrPhone3.FieldName = "AdrPhone3";
            this.colAdrPhone3.Name = "colAdrPhone3";
            this.colAdrPhone3.Visible = true;
            this.colAdrPhone3.VisibleIndex = 13;
            // 
            // colAdrFax
            // 
            this.colAdrFax.Caption = "FAX";
            this.colAdrFax.FieldName = "AdrFax";
            this.colAdrFax.Name = "colAdrFax";
            this.colAdrFax.Visible = true;
            this.colAdrFax.VisibleIndex = 14;
            // 
            // colAdrEmail
            // 
            this.colAdrEmail.Caption = "Email";
            this.colAdrEmail.FieldName = "AdrEmail";
            this.colAdrEmail.Name = "colAdrEmail";
            this.colAdrEmail.Visible = true;
            this.colAdrEmail.VisibleIndex = 15;
            // 
            // colComment
            // 
            this.colComment.Caption = "Σχόλια";
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            // 
            // colAlertMessage
            // 
            this.colAlertMessage.Caption = "Μήνυμα Κινήσεων";
            this.colAlertMessage.FieldName = "AlertMessage";
            this.colAlertMessage.Name = "colAlertMessage";
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            // 
            // colDeleted
            // 
            this.colDeleted.FieldName = "Deleted";
            this.colDeleted.Name = "colDeleted";
            // 
            // colErrorMessage
            // 
            this.colErrorMessage.FieldName = "ErrorMessage";
            this.colErrorMessage.Name = "colErrorMessage";
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
            // 
            // colTag
            // 
            this.colTag.FieldName = "Tag";
            this.colTag.Name = "colTag";
            // 
            // frmCustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCustomersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Πελάτες - Λίστα";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpProffesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProffesion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwMain;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsProffesion;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxName;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colProffesionID;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrStreet;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrCity;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrDistrict;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrZipCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrPhone3;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrFax;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
        private DevExpress.XtraGrid.Columns.GridColumn colAlertMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colRowStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colTag;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpProffesion;
    }
}
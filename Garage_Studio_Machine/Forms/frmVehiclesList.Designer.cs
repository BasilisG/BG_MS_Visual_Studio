namespace GSMForms
{
    partial class frmVehiclesList
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
            this.colVehicleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberPlate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicleTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpVEHICLETYPE = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsVehicleType = new System.Windows.Forms.BindingSource(this.components);
            this.colColorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpCOLOR = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsColor = new System.Windows.Forms.BindingSource(this.components);
            this.colModelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEngineCubic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberDoors = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberChassis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberEngine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpVEHICLETYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpCOLOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColor)).BeginInit();
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
            this.panelControl1.TabIndex = 5;
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
            this.repositoryItemLookUpCOLOR,
            this.repositoryItemLookUpVEHICLETYPE});
            this.gridMain.Size = new System.Drawing.Size(1108, 761);
            this.gridMain.TabIndex = 6;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwMain});
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(ViewModels.vmVehicle);
            // 
            // gridVwMain
            // 
            this.gridVwMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVehicleID,
            this.colNumberPlate,
            this.colDescription,
            this.colVehicleTypeID,
            this.colColorID,
            this.colModelID,
            this.colEngineCubic,
            this.colFirstDate,
            this.colNumberDoors,
            this.colNumberChassis,
            this.colNumberEngine,
            this.colComments,
            this.colUserID,
            this.colDeleted,
            this.colErrorMessage,
            this.colRowStatus,
            this.colSelected,
            this.colTag});
            this.gridVwMain.GridControl = this.gridMain;
            this.gridVwMain.Name = "gridVwMain";
            this.gridVwMain.OptionsBehavior.Editable = false;
            this.gridVwMain.OptionsBehavior.ReadOnly = true;
            // 
            // colVehicleID
            // 
            this.colVehicleID.FieldName = "VehicleID";
            this.colVehicleID.Name = "colVehicleID";
            // 
            // colNumberPlate
            // 
            this.colNumberPlate.Caption = "Αριθμός Πινακίδας";
            this.colNumberPlate.FieldName = "NumberPlate";
            this.colNumberPlate.Name = "colNumberPlate";
            this.colNumberPlate.Visible = true;
            this.colNumberPlate.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Περιγραφή";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colVehicleTypeID
            // 
            this.colVehicleTypeID.Caption = "Τύπος";
            this.colVehicleTypeID.ColumnEdit = this.repositoryItemLookUpVEHICLETYPE;
            this.colVehicleTypeID.FieldName = "VehicleTypeID";
            this.colVehicleTypeID.Name = "colVehicleTypeID";
            this.colVehicleTypeID.Visible = true;
            this.colVehicleTypeID.VisibleIndex = 2;
            // 
            // repositoryItemLookUpVEHICLETYPE
            // 
            this.repositoryItemLookUpVEHICLETYPE.AutoHeight = false;
            this.repositoryItemLookUpVEHICLETYPE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpVEHICLETYPE.DataSource = this.bsVehicleType;
            this.repositoryItemLookUpVEHICLETYPE.DisplayMember = "Description";
            this.repositoryItemLookUpVEHICLETYPE.Name = "repositoryItemLookUpVEHICLETYPE";
            this.repositoryItemLookUpVEHICLETYPE.ValueMember = "VehicleTypeID";
            // 
            // bsVehicleType
            // 
            this.bsVehicleType.DataSource = typeof(ViewModels.vmVehicleType);
            // 
            // colColorID
            // 
            this.colColorID.Caption = "Χρώμα";
            this.colColorID.ColumnEdit = this.repositoryItemLookUpCOLOR;
            this.colColorID.FieldName = "ColorID";
            this.colColorID.Name = "colColorID";
            this.colColorID.Visible = true;
            this.colColorID.VisibleIndex = 3;
            // 
            // repositoryItemLookUpCOLOR
            // 
            this.repositoryItemLookUpCOLOR.AutoHeight = false;
            this.repositoryItemLookUpCOLOR.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpCOLOR.DataSource = this.bsColor;
            this.repositoryItemLookUpCOLOR.DisplayMember = "Description";
            this.repositoryItemLookUpCOLOR.Name = "repositoryItemLookUpCOLOR";
            this.repositoryItemLookUpCOLOR.ValueMember = "ColorID";
            // 
            // bsColor
            // 
            this.bsColor.DataSource = typeof(ViewModels.vmColor);
            // 
            // colModelID
            // 
            this.colModelID.Caption = "Μοντέλο";
            this.colModelID.FieldName = "ModelID";
            this.colModelID.Name = "colModelID";
            this.colModelID.Visible = true;
            this.colModelID.VisibleIndex = 4;
            // 
            // colEngineCubic
            // 
            this.colEngineCubic.Caption = "Κυβισμός  Μηχανής";
            this.colEngineCubic.FieldName = "EngineCubic";
            this.colEngineCubic.Name = "colEngineCubic";
            this.colEngineCubic.Visible = true;
            this.colEngineCubic.VisibleIndex = 5;
            // 
            // colFirstDate
            // 
            this.colFirstDate.Caption = "Πρώτη Ημερομηνία Κυκλοφορίας";
            this.colFirstDate.FieldName = "FirstDate";
            this.colFirstDate.Name = "colFirstDate";
            this.colFirstDate.Visible = true;
            this.colFirstDate.VisibleIndex = 6;
            // 
            // colNumberDoors
            // 
            this.colNumberDoors.Caption = "Αριθμός Θηρών";
            this.colNumberDoors.FieldName = "NumberDoors";
            this.colNumberDoors.Name = "colNumberDoors";
            this.colNumberDoors.Visible = true;
            this.colNumberDoors.VisibleIndex = 7;
            // 
            // colNumberChassis
            // 
            this.colNumberChassis.Caption = "Αριθμός Πλαισίου";
            this.colNumberChassis.FieldName = "NumberChassis";
            this.colNumberChassis.Name = "colNumberChassis";
            this.colNumberChassis.Visible = true;
            this.colNumberChassis.VisibleIndex = 8;
            // 
            // colNumberEngine
            // 
            this.colNumberEngine.Caption = "Αριθμός Μηχανής";
            this.colNumberEngine.FieldName = "NumberEngine";
            this.colNumberEngine.Name = "colNumberEngine";
            this.colNumberEngine.Visible = true;
            this.colNumberEngine.VisibleIndex = 9;
            // 
            // colComments
            // 
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
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
            // frmVehiclesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmVehiclesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Οχήματα - Λίστα";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpVEHICLETYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpCOLOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColor)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleID;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberPlate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colColorID;
        private DevExpress.XtraGrid.Columns.GridColumn colModelID;
        private DevExpress.XtraGrid.Columns.GridColumn colEngineCubic;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberDoors;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberChassis;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberEngine;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colRowStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colTag;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpCOLOR;
        private System.Windows.Forms.BindingSource bsColor;
        private System.Windows.Forms.BindingSource bsVehicleType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpVEHICLETYPE;
    }
}
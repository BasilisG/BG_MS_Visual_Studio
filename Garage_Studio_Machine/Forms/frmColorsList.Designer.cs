namespace GSMForms
{
    partial class frmColorsList
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
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridVwMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colColorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTag = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMain)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(ViewModels.vmColor);
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
            this.panelControl1.Size = new System.Drawing.Size(143, 461);
            this.panelControl1.TabIndex = 1;
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
            this.gridMain.Location = new System.Drawing.Point(143, 0);
            this.gridMain.MainView = this.gridVwMain;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(441, 461);
            this.gridMain.TabIndex = 2;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwMain});
            // 
            // gridVwMain
            // 
            this.gridVwMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colColorID,
            this.colDescription,
            this.colDeleted,
            this.colErrorMessage,
            this.colRowStatus,
            this.colSelected,
            this.colTag});
            this.gridVwMain.GridControl = this.gridMain;
            this.gridVwMain.Name = "gridVwMain";
            // 
            // colColorID
            // 
            this.colColorID.FieldName = "ColorID";
            this.colColorID.Name = "colColorID";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Χρώμα";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
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
            // frmColorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmColorsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Χρώματα - Λίστα";
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMain;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colColorID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colRowStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colTag;
    }
}
namespace GSMForms
{
    partial class frmVehicleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleDetails));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit6 = new DevExpress.XtraEditors.DateEdit();
            this.textEdit10 = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit4 = new DevExpress.XtraEditors.LookUpEdit();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.bsColor = new System.Windows.Forms.BindingSource(this.components);
            this.bsVehicleType = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleType)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 521);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(484, 40);
            this.panelControl1.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(236, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Ακύρωση";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(353, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Αποθήκευση";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "NumberPlate", true));
            this.txtCode.Location = new System.Drawing.Point(105, 45);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(194, 20);
            this.txtCode.TabIndex = 40;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(22, 48);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 13);
            this.lblCode.TabIndex = 39;
            this.lblCode.Text = "Πινακίδα";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "Description", true));
            this.textEdit1.Location = new System.Drawing.Point(105, 82);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(353, 20);
            this.textEdit1.TabIndex = 42;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Περιγραφή";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Χρώμα";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 159);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Τύπος";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 196);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "Μοντέλο";
            // 
            // textEdit5
            // 
            this.textEdit5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "EngineCubic", true));
            this.textEdit5.Location = new System.Drawing.Point(204, 231);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(254, 20);
            this.textEdit5.TabIndex = 50;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 234);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 13);
            this.labelControl5.TabIndex = 49;
            this.labelControl5.Text = "Κυβισμός Μηχανής";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 271);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(157, 13);
            this.labelControl6.TabIndex = 51;
            this.labelControl6.Text = "Πρώτη Ημερομηνία Κυκλοφορίας";
            // 
            // textEdit7
            // 
            this.textEdit7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "NumberDoors", true));
            this.textEdit7.Location = new System.Drawing.Point(204, 306);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(254, 20);
            this.textEdit7.TabIndex = 54;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(22, 309);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 13);
            this.labelControl7.TabIndex = 53;
            this.labelControl7.Text = "Αριθμός Θηρών";
            // 
            // textEdit8
            // 
            this.textEdit8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit8.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "NumberChassis", true));
            this.textEdit8.Location = new System.Drawing.Point(115, 343);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Size = new System.Drawing.Size(343, 20);
            this.textEdit8.TabIndex = 56;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(22, 346);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(82, 13);
            this.labelControl8.TabIndex = 55;
            this.labelControl8.Text = "Αριθμός Πλαισίου";
            // 
            // textEdit9
            // 
            this.textEdit9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit9.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "NumberEngine", true));
            this.textEdit9.Location = new System.Drawing.Point(115, 376);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Size = new System.Drawing.Size(343, 20);
            this.textEdit9.TabIndex = 58;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(22, 379);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 13);
            this.labelControl9.TabIndex = 57;
            this.labelControl9.Text = "Αριθμός Μηχανής";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(22, 412);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(32, 13);
            this.labelControl10.TabIndex = 59;
            this.labelControl10.Text = "Σχόλια";
            // 
            // textEdit6
            // 
            this.textEdit6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "FirstDate", true));
            this.textEdit6.EditValue = null;
            this.textEdit6.Location = new System.Drawing.Point(204, 268);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit6.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit6.Properties.EditFormat.FormatString = "";
            this.textEdit6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.textEdit6.Size = new System.Drawing.Size(254, 20);
            this.textEdit6.TabIndex = 52;
            // 
            // textEdit10
            // 
            this.textEdit10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit10.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "Comments", true));
            this.textEdit10.Location = new System.Drawing.Point(86, 409);
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Size = new System.Drawing.Size(372, 106);
            this.textEdit10.TabIndex = 60;
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "ColorID", true));
            this.textEdit2.Location = new System.Drawing.Point(105, 119);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.textEdit2.Properties.DataSource = this.bsColor;
            this.textEdit2.Properties.DisplayMember = "Description";
            this.textEdit2.Properties.NullText = "";
            this.textEdit2.Properties.ValueMember = "ColorID";
            this.textEdit2.Size = new System.Drawing.Size(353, 20);
            this.textEdit2.TabIndex = 44;
            // 
            // textEdit3
            // 
            this.textEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "VehicleTypeID", true));
            this.textEdit3.Location = new System.Drawing.Point(105, 156);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.textEdit3.Properties.DataSource = this.bsVehicleType;
            this.textEdit3.Properties.DisplayMember = "Description";
            this.textEdit3.Properties.NullText = "";
            this.textEdit3.Properties.ValueMember = "VehicleTypeID";
            this.textEdit3.Size = new System.Drawing.Size(353, 20);
            this.textEdit3.TabIndex = 46;
            // 
            // textEdit4
            // 
            this.textEdit4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "ModelID", true));
            this.textEdit4.Enabled = false;
            this.textEdit4.Location = new System.Drawing.Point(105, 193);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.textEdit4.Properties.DataSource = this.bsVehicleType;
            this.textEdit4.Properties.DisplayMember = "Description";
            this.textEdit4.Properties.NullText = "";
            this.textEdit4.Properties.ValueMember = "VehicleTypeID";
            this.textEdit4.Size = new System.Drawing.Size(353, 20);
            this.textEdit4.TabIndex = 48;
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(ViewModels.vmVehicle);
            // 
            // bsColor
            // 
            this.bsColor.DataSource = typeof(ViewModels.vmColor);
            // 
            // bsVehicleType
            // 
            this.bsVehicleType.DataSource = typeof(ViewModels.vmVehicleType);
            // 
            // frmVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.textEdit9);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.textEdit8);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.textEdit10);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit4);
            this.Name = "frmVehicleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Όχημα";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource bsMain;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit textEdit6;
        private DevExpress.XtraEditors.MemoEdit textEdit10;
        private DevExpress.XtraEditors.LookUpEdit textEdit2;
        private DevExpress.XtraEditors.LookUpEdit textEdit3;
        private DevExpress.XtraEditors.LookUpEdit textEdit4;
        private System.Windows.Forms.BindingSource bsColor;
        private System.Windows.Forms.BindingSource bsVehicleType;
    }
}
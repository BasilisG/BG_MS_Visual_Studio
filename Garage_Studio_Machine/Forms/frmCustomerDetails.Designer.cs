namespace GSMForms
{
    partial class frmCustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerDetails));
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.bsProffesion = new System.Windows.Forms.BindingSource(this.components);
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit12 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit13 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit14 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit15 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit17 = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit16 = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit5 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProffesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit14.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit17.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(Controllers.CustomerControllers);
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "Code", true));
            this.txtCode.Location = new System.Drawing.Point(114, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(160, 20);
            this.txtCode.TabIndex = 6;
            // 
            // bsProffesion
            // 
            this.bsProffesion.DataSource = typeof(ViewModels.vmProffesion);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(12, 45);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(39, 13);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Κωδικός";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Φορολογική Επων.";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 152);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Όνομα";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 188);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Επώνυμο";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 223);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Επάγγελμα";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "TaxName", true));
            this.textEdit1.Location = new System.Drawing.Point(114, 77);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(342, 20);
            this.textEdit1.TabIndex = 14;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "TaxNumber", true));
            this.textEdit2.Location = new System.Drawing.Point(114, 112);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(160, 20);
            this.textEdit2.TabIndex = 15;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "FirstName", true));
            this.textEdit3.Location = new System.Drawing.Point(114, 148);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(342, 20);
            this.textEdit3.TabIndex = 16;
            // 
            // textEdit4
            // 
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "LastName", true));
            this.textEdit4.Location = new System.Drawing.Point(114, 183);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(342, 20);
            this.textEdit4.TabIndex = 17;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 115);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(23, 13);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "ΑΦΜ";
            // 
            // textEdit11
            // 
            this.textEdit11.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AdrPhone1", true));
            this.textEdit11.Location = new System.Drawing.Point(118, 22);
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Size = new System.Drawing.Size(160, 20);
            this.textEdit11.TabIndex = 28;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(16, 25);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(60, 13);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "Τηλέφωνο 1";
            // 
            // textEdit12
            // 
            this.textEdit12.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AdrPhone2", true));
            this.textEdit12.Location = new System.Drawing.Point(118, 54);
            this.textEdit12.Name = "textEdit12";
            this.textEdit12.Size = new System.Drawing.Size(160, 20);
            this.textEdit12.TabIndex = 30;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(16, 57);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(60, 13);
            this.labelControl12.TabIndex = 29;
            this.labelControl12.Text = "Τηλέφωνο 2";
            // 
            // textEdit13
            // 
            this.textEdit13.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AdrPhone3", true));
            this.textEdit13.Location = new System.Drawing.Point(118, 90);
            this.textEdit13.Name = "textEdit13";
            this.textEdit13.Size = new System.Drawing.Size(160, 20);
            this.textEdit13.TabIndex = 32;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(16, 93);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(60, 13);
            this.labelControl13.TabIndex = 31;
            this.labelControl13.Text = "Τηλέφωνο 3";
            // 
            // textEdit14
            // 
            this.textEdit14.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AdrFax", true));
            this.textEdit14.Location = new System.Drawing.Point(118, 123);
            this.textEdit14.Name = "textEdit14";
            this.textEdit14.Size = new System.Drawing.Size(160, 20);
            this.textEdit14.TabIndex = 34;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(16, 126);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(19, 13);
            this.labelControl14.TabIndex = 33;
            this.labelControl14.Text = "FAX";
            // 
            // textEdit15
            // 
            this.textEdit15.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AdrEmail", true));
            this.textEdit15.Location = new System.Drawing.Point(118, 154);
            this.textEdit15.Name = "textEdit15";
            this.textEdit15.Size = new System.Drawing.Size(335, 20);
            this.textEdit15.TabIndex = 36;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(16, 157);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(24, 13);
            this.labelControl15.TabIndex = 35;
            this.labelControl15.Text = "Email";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 571);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(584, 40);
            this.panelControl1.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(336, 2);
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
            this.btnSave.Location = new System.Drawing.Point(453, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Αποθήκευση";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 266);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(582, 311);
            this.xtraTabControl1.TabIndex = 38;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.textEdit10);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.textEdit9);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.textEdit8);
            this.xtraTabPage1.Controls.Add(this.textEdit7);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.textEdit6);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(576, 283);
            this.xtraTabPage1.Text = "Διεύθυνση";
            // 
            // textEdit10
            // 
            this.textEdit10.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AdrZipCode", true));
            this.textEdit10.Location = new System.Drawing.Point(84, 180);
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Size = new System.Drawing.Size(160, 20);
            this.textEdit10.TabIndex = 34;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(24, 183);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(12, 13);
            this.labelControl10.TabIndex = 33;
            this.labelControl10.Text = "ΤΚ";
            // 
            // textEdit9
            // 
            this.textEdit9.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AdrDistrict", true));
            this.textEdit9.Location = new System.Drawing.Point(84, 142);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Size = new System.Drawing.Size(342, 20);
            this.textEdit9.TabIndex = 32;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 145);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 13);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "Περιοχή";
            // 
            // textEdit8
            // 
            this.textEdit8.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AdrCity", true));
            this.textEdit8.Location = new System.Drawing.Point(84, 103);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Size = new System.Drawing.Size(342, 20);
            this.textEdit8.TabIndex = 30;
            // 
            // textEdit7
            // 
            this.textEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AdrNumber", true));
            this.textEdit7.Location = new System.Drawing.Point(84, 69);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(160, 20);
            this.textEdit7.TabIndex = 29;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(24, 72);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 13);
            this.labelControl7.TabIndex = 28;
            this.labelControl7.Text = "Αριθμός";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 106);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Πόλη";
            // 
            // textEdit6
            // 
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AdrStreet", true));
            this.textEdit6.Location = new System.Drawing.Point(84, 35);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(342, 20);
            this.textEdit6.TabIndex = 21;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 13);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Οδός";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.textEdit11);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.textEdit15);
            this.xtraTabPage2.Controls.Add(this.labelControl12);
            this.xtraTabPage2.Controls.Add(this.labelControl15);
            this.xtraTabPage2.Controls.Add(this.textEdit12);
            this.xtraTabPage2.Controls.Add(this.textEdit14);
            this.xtraTabPage2.Controls.Add(this.labelControl14);
            this.xtraTabPage2.Controls.Add(this.labelControl13);
            this.xtraTabPage2.Controls.Add(this.textEdit13);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(576, 283);
            this.xtraTabPage2.Text = "Επικοινωνία";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.labelControl16);
            this.xtraTabPage3.Controls.Add(this.labelControl17);
            this.xtraTabPage3.Controls.Add(this.textEdit17);
            this.xtraTabPage3.Controls.Add(this.textEdit16);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(576, 283);
            this.xtraTabPage3.Text = "Λοιπά";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(28, 191);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(86, 13);
            this.labelControl16.TabIndex = 39;
            this.labelControl16.Text = "Μήνυμα Κινήσεων";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(28, 25);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(32, 13);
            this.labelControl17.TabIndex = 37;
            this.labelControl17.Text = "Σχόλια";
            // 
            // textEdit17
            // 
            this.textEdit17.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "Comment", true));
            this.textEdit17.Location = new System.Drawing.Point(130, 22);
            this.textEdit17.Name = "textEdit17";
            this.textEdit17.Size = new System.Drawing.Size(394, 145);
            this.textEdit17.TabIndex = 38;
            // 
            // textEdit16
            // 
            this.textEdit16.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "AlertMessage", true));
            this.textEdit16.Location = new System.Drawing.Point(130, 188);
            this.textEdit16.Name = "textEdit16";
            this.textEdit16.Size = new System.Drawing.Size(394, 90);
            this.textEdit16.TabIndex = 40;
            // 
            // textEdit5
            // 
            this.textEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsProffesion, "ProffesionID", true));
            this.textEdit5.Location = new System.Drawing.Point(114, 220);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit5.Properties.DataSource = this.bsProffesion;
            this.textEdit5.Properties.DisplayMember = "Description";
            this.textEdit5.Properties.NullText = "";
            this.textEdit5.Properties.ValueMember = "ProffesionID";
            this.textEdit5.Size = new System.Drawing.Size(342, 20);
            this.textEdit5.TabIndex = 18;
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.textEdit5);
            this.Name = "frmCustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Πελάτες";
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProffesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit14.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit17.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMain;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private System.Windows.Forms.BindingSource bsProffesion;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit11;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit textEdit12;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit textEdit13;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit textEdit14;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit textEdit15;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.MemoEdit textEdit17;
        private DevExpress.XtraEditors.MemoEdit textEdit16;
        private DevExpress.XtraEditors.LookUpEdit textEdit5;
    }
}
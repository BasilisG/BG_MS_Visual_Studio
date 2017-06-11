namespace GSMForms
{
    partial class frmVatDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatDetails));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblDescr = new DevExpress.XtraEditors.LabelControl();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblVatNormal = new DevExpress.XtraEditors.LabelControl();
            this.lblVatReduced = new DevExpress.XtraEditors.LabelControl();
            this.lblVatOther = new DevExpress.XtraEditors.LabelControl();
            this.txtVatNormal = new DevExpress.XtraEditors.TextEdit();
            this.txtVatReduced = new DevExpress.XtraEditors.TextEdit();
            this.txtVatOther = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVatNormal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVatReduced.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVatOther.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 225);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(384, 40);
            this.panelControl1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(136, 2);
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
            this.btnSave.Location = new System.Drawing.Point(253, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Αποθήκευση";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescr
            // 
            this.lblDescr.Location = new System.Drawing.Point(12, 74);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(52, 13);
            this.lblDescr.TabIndex = 9;
            this.lblDescr.Text = "Περιγραφή";
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(12, 45);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(39, 13);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "Κωδικός";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(103, 67);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(204, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(ViewModels.vmVat);
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "Code", true));
            this.txtCode.Location = new System.Drawing.Point(103, 38);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 10;
            // 
            // lblVatNormal
            // 
            this.lblVatNormal.Location = new System.Drawing.Point(12, 107);
            this.lblVatNormal.Name = "lblVatNormal";
            this.lblVatNormal.Size = new System.Drawing.Size(69, 13);
            this.lblVatNormal.TabIndex = 12;
            this.lblVatNormal.Text = "Κανονικό ΦΠΑ";
            // 
            // lblVatReduced
            // 
            this.lblVatReduced.Location = new System.Drawing.Point(12, 138);
            this.lblVatReduced.Name = "lblVatReduced";
            this.lblVatReduced.Size = new System.Drawing.Size(63, 13);
            this.lblVatReduced.TabIndex = 13;
            this.lblVatReduced.Text = "Μειμένο ΦΠΑ";
            // 
            // lblVatOther
            // 
            this.lblVatOther.Location = new System.Drawing.Point(12, 166);
            this.lblVatOther.Name = "lblVatOther";
            this.lblVatOther.Size = new System.Drawing.Size(51, 13);
            this.lblVatOther.TabIndex = 14;
            this.lblVatOther.Text = "Άλλο ΦΠΑ";
            // 
            // txtVatNormal
            // 
            this.txtVatNormal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "VatRate_1", true));
            this.txtVatNormal.Location = new System.Drawing.Point(103, 100);
            this.txtVatNormal.Name = "txtVatNormal";
            this.txtVatNormal.Size = new System.Drawing.Size(62, 20);
            this.txtVatNormal.TabIndex = 15;
            // 
            // txtVatReduced
            // 
            this.txtVatReduced.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "VatRate_2", true));
            this.txtVatReduced.Location = new System.Drawing.Point(103, 131);
            this.txtVatReduced.Name = "txtVatReduced";
            this.txtVatReduced.Size = new System.Drawing.Size(62, 20);
            this.txtVatReduced.TabIndex = 16;
            // 
            // txtVatOther
            // 
            this.txtVatOther.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMain, "VatRate_3", true));
            this.txtVatOther.Location = new System.Drawing.Point(103, 159);
            this.txtVatOther.Name = "txtVatOther";
            this.txtVatOther.Size = new System.Drawing.Size(62, 20);
            this.txtVatOther.TabIndex = 17;
            // 
            // frmVatDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 265);
            this.Controls.Add(this.txtVatOther);
            this.Controls.Add(this.txtVatReduced);
            this.Controls.Add(this.txtVatNormal);
            this.Controls.Add(this.lblVatOther);
            this.Controls.Add(this.lblVatReduced);
            this.Controls.Add(this.lblVatNormal);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmVatDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Κατηγορία ΦΠΑ";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVatNormal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVatReduced.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVatOther.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource bsMain;
        private DevExpress.XtraEditors.LabelControl lblDescr;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblVatNormal;
        private DevExpress.XtraEditors.LabelControl lblVatReduced;
        private DevExpress.XtraEditors.LabelControl lblVatOther;
        private DevExpress.XtraEditors.TextEdit txtVatNormal;
        private DevExpress.XtraEditors.TextEdit txtVatReduced;
        private DevExpress.XtraEditors.TextEdit txtVatOther;
    }
}
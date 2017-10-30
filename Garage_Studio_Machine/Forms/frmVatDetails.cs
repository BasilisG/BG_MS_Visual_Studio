using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using ViewModels;
using Controllers;

namespace GSMForms
{
    public partial class frmVatDetails : DevExpress.XtraEditors.XtraForm
    {
        public vmVat RecMain { get; set; }
        public RecordMode RecMode { get; set; }
        public CancellationTokenSource cts = new CancellationTokenSource();

        public frmVatDetails()
        {
            InitializeComponent();
        }

        //________________________________________________________________________________________
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitValues();
            InitDataSources();
            // luPortOffices.Focus();
        }

                //________________________________________________________________________________________
        private void InitValues()
        {
            if (RecMode != RecordMode.Added)
                if (!LoadData()) { this.Close(); return; }
            switch (RecMode)
            {
                case RecordMode.Added:
                    this.Text = "Καταχώρη Κατηγορίας ΦΠΑ";
                    RecMain = new vmVat { VatID = Guid.NewGuid() };
                    //tabMain.Enabled = false;
                    break;
                case RecordMode.Modified:
                    this.Text = "Μεταβολή Κατηγορίας ΦΠΑ";
                    break;
                case RecordMode.Deleted:

                    btnSave.Text = "Διαγραφή";
                    this.Text = "Διαγραφή Κατηγορίας ΦΠΑ";
                    
                    break;
                case RecordMode.ViewOnly:
                    this.Text = "Προβολή Κατηγορίας ΦΠΑ";
                    /*
                    buttonCancel.Visible = false;
                    */
                    break;
            }
            //vOwners.ActiveFilterString = "[RowStatus] <> 'Deleted'";
        }

        //________________________________________________________________________________________
        private void InitDataSources()
        {
            bsMain.DataSource = RecMain;
            bsMain.ResetBindings(false);
            
            if (RecMode == RecordMode.Added) return;            
        }

        //________________________________________________________________________________________
        private bool LoadData()
        {
            int x = 1;
            
            var ans = new VatControllers();

            if (ans == null) return false;
            
            RecMain = ans.GetVatDetails(RecMain.VatID.ToString());
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (RecMode == RecordMode.Unchanged || RecMode == RecordMode.ViewOnly)
                DialogResult = DialogResult.OK;
            bsMain.EndEdit();
            //if (!CheckData()) return;
            if (!SaveChanges()) return;
            DialogResult = DialogResult.OK;
        }

        //________________________________________________________________________________________
        private bool SaveChanges()
        {
            RecMain.RowStatus = RecMode;
            var ans = new VatControllers();
            return ans.UpdateVat(RecMain);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            DialogResult=  DialogResult.Cancel;
        }
    }
}
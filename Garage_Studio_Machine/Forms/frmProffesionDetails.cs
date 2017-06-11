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
    public partial class frmProffesionDetails : DevExpress.XtraEditors.XtraForm
    {

        public vmProffesion RecMain { get; set; }
        public RecordMode RecMode { get; set; }
        public CancellationTokenSource ctc = new CancellationTokenSource();

        public frmProffesionDetails()
        {
            InitializeComponent();
        }

        //________________________________________________________________________________________
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitValues();
            InitDataSources();
        }

        //________________________________________________________________________________________
        private void InitValues()
        {
            if (RecMode != RecordMode.Added)
                if (!LoadData()) { this.Close(); return; }
            switch (RecMode)
            {
                case RecordMode.Added:
                    this.Text = "Καταχώρη Επαγγέλματος";
                    RecMain = new vmProffesion { ProffesionID = Guid.NewGuid() };
                    //tabMain.Enabled = false;
                    break;
                case RecordMode.Modified:
                    this.Text = "Μεταβολή Επαγγέλματος";
                    break;
                case RecordMode.Deleted:

                    btnSave.Text = "Διαγραφή";
                    this.Text = "Διαγραφή Επαγγέλματος";
                    break;
                case RecordMode.ViewOnly:
                    this.Text = "Προβολή Επαγγέλματος";
                    break;
            }
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
            var ans = new ProffesionControllers();

            if (ans == null) return false;

            RecMain = ans.GetProffesionDetails(RecMain.ProffesionID.ToString());
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
            var ans = new ProffesionControllers();
            return ans.UpdateProffesion(RecMain);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            DialogResult = DialogResult.Cancel;
        }

    }
}
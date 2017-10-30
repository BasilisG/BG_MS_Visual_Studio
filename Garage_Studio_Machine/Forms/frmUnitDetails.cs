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
    public partial class frmUnitDetails : DevExpress.XtraEditors.XtraForm
    {

        public vmUnit RecMain { get; set; }
        public RecordMode RecMode { get; set; }
        public CancellationTokenSource cts = new CancellationTokenSource();

        public frmUnitDetails()
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
                    this.Text = "Καταχώρη Μονάδας Μέτρησης";
                    RecMain = new vmUnit { UnitID = Guid.NewGuid() };
                    //tabMain.Enabled = false;
                    break;
                case RecordMode.Modified:
                    this.Text = "Μεταβολή Μονάδας Μέτρησης";
                    break;
                case RecordMode.Deleted:

                    btnSave.Text = "Διαγραφή";
                    this.Text = "Διαγραφή Μονάδας Μέτρησης";
                    /*
                    Common.Global.SetControlsReadOnly(panelMain);
                    Common.Global.SetGridViewReadOnly(vOwners);
                    Common.Global.SetGridViewReadOnly(vBridgeActivities);
                    Common.Global.SetGridViewReadOnly(vShipActivities);
                     * */
                    break;
                case RecordMode.ViewOnly:
                    this.Text = "Προβολή Μονάδας Μέτρησης";
                    /*
                    buttonCancel.Visible = false;
                    Common.Global.SetControlsReadOnly(panelMain);
                    Common.Global.SetGridViewReadOnly(vOwners);
                    Common.Global.SetGridViewReadOnly(vBridgeActivities);
                    Common.Global.SetGridViewReadOnly(vShipActivities);
                     * */
                    break;
            }
            //vOwners.ActiveFilterString = "[RowStatus] <> 'Deleted'";
        }

        //________________________________________________________________________________________
        private void InitDataSources()
        {
            /*
            bsUser.DataSource = Common.Lookups.luUsers;
            bsShipCategory.DataSource = Common.Lookups.luShipCategories;
            bsBridgeCategory.DataSource = Common.Lookups.luBridgeCategories;
            bsPortOffice.DataSource = Common.Lookups.luPortOffices;
            bsCountries.DataSource = Common.Lookups.luCountries;
             */
            bsMain.DataSource = RecMain;
            bsMain.ResetBindings(false);
            /*
            luBridgeCategory.Properties.DropDownRows = Common.Lookups.luBridgeCategories.Count;
            luShipCategory.Properties.DropDownRows = (Common.Lookups.luShipCategories.Count < 12) ? Common.Lookups.luShipCategories.Count : 12;
            */
            if (RecMode == RecordMode.Added) return;
            /*
            await LoadShipOwners();
            await LoadShipActivities();
            await LoadBridgeActivities();
            await LoadImageThumbnail();
              */
        }

        private bool LoadData()
        {
            int x = 1;
            
            var ans = new UnitControllers();

            if (ans == null) return false;
            
            RecMain = ans.GetUnitDetails(RecMain.UnitID.ToString());
            return true;
        }

        private void frmUnitDetails_Load(object sender, EventArgs e)
        {

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
            var ans = new UnitControllers();
            return ans.UpdateUnit(RecMain);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            DialogResult = DialogResult.Cancel;
        }

        private void txtDescription_EditValueChanged(object sender, EventArgs e)
        {

        }

    }
}
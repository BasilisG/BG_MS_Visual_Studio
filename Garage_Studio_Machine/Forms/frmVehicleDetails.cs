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
    public partial class frmVehicleDetails : DevExpress.XtraEditors.XtraForm
    {
        public vmVehicle RecMain { get; set; }
        public RecordMode RecMode { get; set; }
        public CancellationTokenSource cts = new CancellationTokenSource();

        public frmVehicleDetails()
        {
            InitializeComponent();
        }

        //________________________________________________________________________________________
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitValues();
            InitDataSources();

            var VehicleTypeList = new VehicleControllers();
            bsVehicleType.DataSource = VehicleTypeList.GetVehiclesList();

            var ColorList = new ColorControllers();
            bsColor.DataSource = ColorList.GetColorsList();

        }

        //________________________________________________________________________________________
        private void InitValues()
        {
            if (RecMode != RecordMode.Added)
                if (!LoadData()) { this.Close(); return; }
            switch (RecMode)
            {
                case RecordMode.Added:
                    this.Text = "Καταχώρη Οχήματος";
                    RecMain = new vmVehicle { VehicleID = Guid.NewGuid() };
                    //tabMain.Enabled = false;
                    break;
                case RecordMode.Modified:
                    this.Text = "Μεταβολή Οχήματος";
                    break;
                case RecordMode.Deleted:

                    btnSave.Text = "Διαγραφή";
                    this.Text = "Διαγραφή Οχήματος";
                    break;

                case RecordMode.ViewOnly:
                    this.Text = "Προβολή Πελάτη";
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

        private bool LoadData()
        {
            int x = 1;
            //TODO  1111
            var ans = new VehicleControllers();

            if (ans == null) return false;

            RecMain = ans.GetVehicleDetails(RecMain.VehicleID.ToString());
            return true;
        }

        private void frmVehicleDetails_Load(object sender, EventArgs e)
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
            var ans = new VehicleControllers();
            return ans.UpdateVehicle(RecMain);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            DialogResult = DialogResult.Cancel;
        }

    }
}
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
    public partial class frmItemDetails : DevExpress.XtraEditors.XtraForm
    {

        public vmItem RecMain { get; set; }
        public RecordMode RecMode { get; set; }
        public CancellationTokenSource cts = new CancellationTokenSource();

        public frmItemDetails()
        {
            InitializeComponent();
        }

        //________________________________________________________________________________________
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitValues();
            InitDataSources();
            var VatList = new VatControllers();
            bsVat.DataSource = VatList.GetVatsList();
            var UnitList = new UnitControllers();
            bsUnit.DataSource = UnitList.GetUnitsList();
            var ItemTypeList = new ItemTypeControllers();
            bsItemType.DataSource = ItemTypeList.GetItemTypesList();
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
                    RecMain = new vmItem { ItemID = Guid.NewGuid(), isActive = true };
                    //tabMain.Enabled = false;
                    break;
                case RecordMode.Modified:
                    this.Text = "Μεταβολή Μονάδας Μέτρησης";
                    break;
                case RecordMode.Deleted:

                    btnSave.Text = "Διαγραφή";
                    this.Text = "Διαγραφή Μονάδας Μέτρησης";
                    break;

                case RecordMode.ViewOnly:
                    this.Text = "Προβολή Μονάδας Μέτρησης";
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
            var ans = new ItemControllers();

            if (ans == null) return false;
            
            RecMain = ans.GetItemDetails(RecMain.ItemID.ToString());
            return true;
        }

        private void frmItemDetails_Load(object sender, EventArgs e)
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
            var ans = new ItemControllers();
            return ans.UpdateItem(RecMain);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            DialogResult = DialogResult.Cancel;
        }




    }
}
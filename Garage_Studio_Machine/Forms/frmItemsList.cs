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
using ViewModels;
using Controllers;

namespace GSMForms
{
    public partial class frmItemsList : DevExpress.XtraEditors.XtraForm
    {

        public bool SelectMode { get; set; }
        public vmItem SelectedRecord { get; set; }

        public frmItemsList()
        {
            InitializeComponent();
        }

        //________________________________________________________________________________________
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitValues();

            // Fill Lookups with Data
            var VatList = new VatControllers();
            bsVat.DataSource = VatList.GetVatsList();
            var UnitList = new UnitControllers();
            bsUnit.DataSource = UnitList.GetUnitsList();
        }

        //________________________________________________________________________________________
        private void InitValues()
        {
            gridMain.BeginInit();
            if (colSelected.Visible) colSelected.Visible = !SelectMode;
            gridMain.ForceInitialize();
            gridMain.EndInit();
        }  

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (frmItemDetails frm = new frmItemDetails { RecMode = RecordMode.Added })
                if (frm.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        bsMain.Add(frm.RecMain);
                        bsMain.ResetBindings(false);
                        //TODO how do i refresh grid
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        //TODO What is the error message and how do i solved it
                        bsMain.ResetBindings(false);
                        LoadData();
                        // throw ex;
                    }
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridVwMain.GetFocusedRow() == null) return;
            vmItem vm = gridVwMain.GetFocusedRow() as vmItem;

            using (frmItemDetails frm = new frmItemDetails { RecMain = new vmItem { ItemID = vm.ItemID }, RecMode = RecordMode.Modified })
                if (frm.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        bsMain.Remove(vm);
                        bsMain.Add(frm.RecMain);
                        bsMain.ResetBindings(false);
                        gridVwMain.FocusedRowHandle = gridVwMain.LocateByValue("ItemID", frm.RecMain.ItemID);
                        LoadData();
                    }
                    catch (Exception)
                    {

                        bsMain.ResetBindings(false);
                        gridVwMain.FocusedRowHandle = gridVwMain.LocateByValue("ItemID", frm.RecMain.ItemID);
                        LoadData();
                    }
                }    

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridVwMain.GetFocusedRow() == null) return;
            vmItem vm = gridVwMain.GetFocusedRow() as vmItem;

            using (frmItemDetails frm = new frmItemDetails { RecMain = new vmItem { ItemID = vm.ItemID }, RecMode = RecordMode.Deleted })
                if (frm.ShowDialog() == DialogResult.Cancel) return;

            try
            {
                bsMain.Remove(vm);
                bsMain.ResetBindings(false);
                LoadData();
            }
            catch (Exception)
            {
                bsMain.ResetBindings(false);
                LoadData();
                // throw ex;
            }

        }

        private void LoadData()
        {
            gridMain.BeginInit();
            var ans = new ItemControllers();
            bsMain.DataSource = ans.GetItemsList();
            bsMain.ResetBindings(false);
            gridMain.EndInit();
        }
    }
}
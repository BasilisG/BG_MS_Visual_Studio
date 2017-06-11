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
    public partial class frmVatsList : DevExpress.XtraEditors.XtraForm
    {

        public bool SelectMode { get; set; }
        public vmVat SelectedRecord { get; set; }

        public frmVatsList()
        {
            InitializeComponent();
        }


        //________________________________________________________________________________________
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitValues();
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
            using (frmVatDetails frm = new frmVatDetails { RecMode = RecordMode.Added })
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
            vmVat vm = gridVwMain.GetFocusedRow() as vmVat;

            using (frmVatDetails frm = new frmVatDetails { RecMain = new vmVat { VatID = vm.VatID }, RecMode = RecordMode.Modified })
                if (frm.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        bsMain.Remove(vm);
                        bsMain.Add(frm.RecMain);
                        bsMain.ResetBindings(false);
                        gridVwMain.FocusedRowHandle = gridVwMain.LocateByValue("VatID", frm.RecMain.VatID);
                        LoadData();
                    }
                    catch (Exception)
                    {

                        bsMain.ResetBindings(false);
                        gridVwMain.FocusedRowHandle = gridVwMain.LocateByValue("VatID", frm.RecMain.VatID);
                        LoadData();
                    }
                }    
        }

        private void LoadData()
        {
            gridMain.BeginInit();
            var ans = new VatControllers();
            bsMain.DataSource = ans.GetVatsList();
            bsMain.ResetBindings(false);
            gridMain.EndInit();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridVwMain.GetFocusedRow() == null) return;
            vmVat vm = gridVwMain.GetFocusedRow() as vmVat;

            using (frmVatDetails frm = new frmVatDetails { RecMain = new vmVat { VatID = vm.VatID }, RecMode = RecordMode.Deleted })
                if (frm.ShowDialog() == DialogResult.Cancel) return;

            try
            {
                bsMain.Remove(vm);
                bsMain.ResetBindings(false);
                LoadData();
            }
            catch (Exception ex)
            {
                bsMain.ResetBindings(false);
                LoadData();
                // throw ex;
            }
        }
    }
}
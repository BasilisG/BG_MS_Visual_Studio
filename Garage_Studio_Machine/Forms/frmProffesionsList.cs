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
    public partial class frmProffesionsList : DevExpress.XtraEditors.XtraForm
    {

        public bool SelectMode { get; set; }
        public vmProffesion SelectedRecord { get; set; }

        public frmProffesionsList()
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
            // bsCountry.DataSource = Lookups.luCountries;

            gridMain.BeginInit();
            //string mainLayoutFile = Common.Global.LayoutsFolder.Name + @"\" + this.Name + @".gMain.vMain.xml";

            if (colSelected.Visible) colSelected.Visible = !SelectMode;
            /*
            buttonLayout.Visible = !SelectMode;
            buttonExport.Visible = !SelectMode;
            buttonActions.Visible = colSelected.Visible;
            buttonSelect.Visible = SelectMode;
            
            if (!SelectMode)
            {
                buttonLayout.Tag = vMain; ViewListButtons.CreateLayoutsMenu(buttonLayout, mainLayoutFile);
                buttonExport.Tag = vMain; ViewListButtons.CreateExportMenu(buttonExport);
                buttonActions.Tag = vMain; ViewListButtons.CreateActionsMenu(buttonActions);
            }
             */
            gridMain.ForceInitialize();
            /*
            if (File.Exists(mainLayoutFile)) vMain.RestoreLayoutFromXml(mainLayoutFile);

            foreach (DevExpress.XtraGrid.Columns.GridColumn c in vMain.Columns)
                c.CustomizationCaption = c.Caption;
             */
            gridMain.EndInit();
        }





        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (frmProffesionDetails frm = new frmProffesionDetails { RecMode = RecordMode.Added })
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
                        //throw ex;
                    }

                }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridVwMain.GetFocusedRow() == null) return;
            vmProffesion vm = gridVwMain.GetFocusedRow() as vmProffesion;

            using (frmProffesionDetails frm = new frmProffesionDetails { RecMain = new vmProffesion { ProffesionID = vm.ProffesionID }, RecMode = RecordMode.Modified })
                if (frm.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        bsMain.Remove(vm);
                        bsMain.Add(frm.RecMain);
                        bsMain.ResetBindings(false);
                        gridVwMain.FocusedRowHandle = gridVwMain.LocateByValue("ProffesiontID", frm.RecMain.ProffesionID);
                        LoadData();
                    }
                    catch (Exception ex)
                    {

                        bsMain.ResetBindings(false);
                        gridVwMain.FocusedRowHandle = gridVwMain.LocateByValue("ProffesiontID", frm.RecMain.ProffesionID);
                        LoadData();
                    }
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridVwMain.GetFocusedRow() == null) return;
            vmProffesion vm = gridVwMain.GetFocusedRow() as vmProffesion;

            using (frmProffesionDetails frm = new frmProffesionDetails { RecMain = new vmProffesion { ProffesionID = vm.ProffesionID }, RecMode = RecordMode.Deleted })
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

        private void LoadData()
        {
            gridMain.BeginInit();
            var ans = new ProffesionControllers();
            bsMain.DataSource = ans.GetProffesionsList();
            bsMain.ResetBindings(false);
            gridMain.EndInit();

        }


    }
}
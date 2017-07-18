using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSMForms;

namespace ViewModels
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void αρχείαToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void μονάδεςΜέτρησηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnitsList unitList_form = new frmUnitsList();
            unitList_form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void κατηγορίεςΦΠΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVatsList vatList_form = new frmVatsList();
            vatList_form.ShowDialog();
        }

        private void επαγγέλματαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProffesionsList proffesionList_form = new frmProffesionsList();
            proffesionList_form.ShowDialog();
        }


        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {
            frmItemsList itemList_frm = new frmItemsList();
            itemList_frm.ShowDialog();
        }

        private void πελάτεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersList customerList_frm = new frmCustomersList();
            customerList_frm.ShowDialog();
        }

        private void τύποιΟχημάτωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicleTypesList vehicleTypeList_frm = new frmVehicleTypesList();
            vehicleTypeList_frm.ShowDialog();
        }

        private void εξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit Application Code
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }





    }
}

// Robert McCormick
// Frameworks
// term 3
// RobertMccormick_CE04

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformTutorial.Models;

namespace WinformTutorial
{
    public partial class InputForm : Form
    {

        // user EventHandle 
        public event EventHandler<CustomEventArgs> SaveDataEventHandle;


        //custom event when this form close (to re-count total Input form)
        public event Action CloseForm;

        public InputForm()
        {
            InitializeComponent();

            //init custom event for 2 butons
            btnSave.Click += BtnSave_Click;
            btnClear.Click += BtnClear_Click;
            this.FormClosed += InputForm_FormClosed;

        }

        public InputForm(InputModel model)
        {
            InitializeComponent();
            if (model != null)
            {
                //init custom event for 2 butons
                btnSave.Click += BtnSave_Click;
                btnClear.Click += BtnClear_Click;
                this.FormClosed += InputForm_FormClosed;

                //init data
                txtName.Text = model.Name;
                numQuantity.Value = model.Quantity;
                ckbActive.Checked = model.IsActive;
                dtpImport.Value = model.ImportDate;
            }
        }

        //event when form close
        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //calling custom event 
            if (CloseForm != null)
            {
                CloseForm();
            }
        }

        //event when user clicks Clear button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //clear all input
            txtName.Text = String.Empty;
            numQuantity.Value = 0;
            ckbActive.Checked = false;
            dtpImport.Value = DateTime.Now;
        }

        //event when user clicks Save button
        private void BtnSave_Click(object sender, EventArgs e)
        {

            //calling custom event handle for save object (using EventHandle)
            if (SaveDataEventHandle != null)
            {
                //collect input data
                InputModel model = new InputModel();
               
                model.Name = txtName.Text;
                model.Quantity = numQuantity.Value;
                model.IsActive = ckbActive.Checked;
                model.ImportDate = dtpImport.Value;
                SaveDataEventHandle(this, new CustomEventArgs(model));
            }

            //clear data
            BtnClear_Click(null, null);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnSave_Click(null, null);
        }

         
        private void SelectionChangedHandler(object sender, EventArgs e)                                    
        {                                                                                                   
            ListForm lvf = sender as ListForm;                                                              
            InputModel iM = new InputModel();
            iM = lvf.SelectedObject;
        }
       


    }
}

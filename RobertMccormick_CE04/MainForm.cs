
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
    public partial class MainForm : Form
    {
        #region properties
        private int totalInputForm;
        private bool isListFormShown;

        //save data 
        private List<InputModel> StoredObjects;

        //custom event when New Obj saved
        public event Action<InputModel> SaveDataToListForm;

        //custom event when user clicks Clear data
        public event Action ClearData;
        #endregion

        #region constructor
        public MainForm()
        {
            InitializeComponent();

            isListFormShown = false;

            totalInputForm = 0;

            lblTotalInputForm.Text = totalInputForm.ToString();

            StoredObjects = new List<InputModel>();
        }
        #endregion

        #region events
        private void btnOpenInputForm_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();

            //regise 2 custom events of Input form
            inputForm.CloseForm += InputForm_CloseForm;
            //using eventHandle
            inputForm.SaveDataEventHandle += InputForm_SaveDataEventHandle;

            inputForm.Show();

            //re- calculate total Input form
            totalInputForm++;
            lblTotalInputForm.Text = totalInputForm.ToString();
        }

        private void InputForm_SaveDataEventHandle(object sender, CustomEventArgs e)
        {
            //save it first
            StoredObjects.Add(e.Model);

            //at this step, we need to trigger ListForm know it need to add this obj to it.
            //so we need to call another custom event
            if (SaveDataToListForm != null)
            {
                SaveDataToListForm(e.Model);
            }

            //re- calculate total item
            lblTotalItem.Text = StoredObjects.Count.ToString();
        }

        //this method trigged when user close InputForm
        private void InputForm_CloseForm()
        {
            //re- calculate total Input form
            totalInputForm--;
            lblTotalInputForm.Text = totalInputForm.ToString();
        }

        private void btnOpenListForm_Click(object sender, EventArgs e)
        {
            if (!isListFormShown)
            {
                ListForm listform = new ListForm(this, StoredObjects);

                //regise custom events of List form
                listform.CloseForm += Listform_CloseForm;
                listform.ClearData += Listform_ClearData;
                listform.ListViewDoubleClick += Listform_ListViewDoubleClick;

                listform.Show();

                //disable btnOpenListForm
                btnOpenListForm.Enabled = false;
                isListFormShown = true;
            }
        }

        private void Listform_ListViewDoubleClick(int index)
        {
            //get selected object
            var selectedItem = StoredObjects[index];

            //create new Input  Form
            InputForm inputForm = new InputForm(selectedItem);

            //regise 2 custom events of Input form
            inputForm.CloseForm += InputForm_CloseForm;
            //using eventHandle
            inputForm.SaveDataEventHandle += InputForm_SaveDataEventHandle;

            inputForm.Show();

            //re- calculate total Input form
            totalInputForm++;
            lblTotalInputForm.Text = totalInputForm.ToString();
        }

        private void Listform_ClearData()
        {
            StoredObjects.Clear();
            lblTotalItem.Text = "0";
        }

        //this method trigged when user close ListForm
        private void Listform_CloseForm()
        {
            isListFormShown = false;
            btnOpenListForm.Enabled = true;
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            StoredObjects.Clear();
            lblTotalItem.Text = "0";

            if (ClearData != null)
            {
                //calling custom event
                ClearData();
            }
        }
        #endregion

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isListFormShown)
            {
                ListForm listform = new ListForm(this, StoredObjects);

                //regise custom events of List form
                listform.CloseForm += Listform_CloseForm;

                listform.Show();

                //disable btnOpenListForm
                btnOpenListForm.Enabled = false;
                isListFormShown = true;
            }
        }
    }
}

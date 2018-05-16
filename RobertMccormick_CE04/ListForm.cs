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
    public partial class ListForm : Form
    {
        //custom event when this form close (to re-enable btnOpenListForm)
        public event Action CloseForm;

        public event Action ClearData;

        public event Action<int> ListViewDoubleClick;

        private MainForm mainForm;


        public ListForm(MainForm mainForm, List<InputModel> storedObj)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.FormClosed += ListForm_FormClosed;

            InitData(storedObj);

            mainForm.SaveDataToListForm += MainForm_SaveDataToListForm;
            mainForm.ClearData += MainForm_ClearData;
        }

        //this method trigger when user clicks Mainform.Clear data button
        private void MainForm_ClearData()
        {
            InitData(null);
        }

        //this method trigger when MainForm.SaveData triggered
        private void MainForm_SaveDataToListForm(InputModel obj)
        {
            //add obj to listview
            var lvItem = listView1.Items.Add(obj.ToString());
            lvItem.ImageIndex = 0;

            //re-count total data
            lblTotalObject.Text = listView1.Items.Count.ToString();
        }

        private void InitData(List<InputModel> storedObj)
        {
            if (storedObj == null)
            {
                listView1.Items.Clear();
                lblTotalObject.Text = "0";
                return;
            }

            foreach (var item in storedObj)
            {
                var lvItem = listView1.Items.Add(item.ToString());
                lvItem.ImageIndex = 0;
            }

            //re-count total data
            lblTotalObject.Text = listView1.Items.Count.ToString();
        }

        private void ListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //undo custom event
            mainForm.SaveDataToListForm -= MainForm_SaveDataToListForm;
            mainForm.ClearData -= MainForm_ClearData;


            if (CloseForm != null)
            {
                CloseForm();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitData(null);

            if (ClearData != null)
                ClearData();
        }


 
        public InputModel SelectedObject
        {
            get
            {

                if (listView1.SelectedItems.Count > 0)
                {
                    return listView1.SelectedItems[0].Tag as InputModel;
                }
                else
                {
                    return new InputModel();
                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //you need to override this event
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //when double click on listview item -> send index of it to mainform
            //mainform will take correct item from StoreObject to create a new Inputform
            if (ListViewDoubleClick != null)
                ListViewDoubleClick(listView1.SelectedIndices[0]);
        }
    }
}

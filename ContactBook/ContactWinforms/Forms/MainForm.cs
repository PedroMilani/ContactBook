using ContactWinforms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactWinforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListForm_Click(object sender, EventArgs e)
        {
            ContactsList formList = new ContactsList();
            formList.Show();
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            AddContacts formAdd = new AddContacts();
            formAdd.Show();
        }

        private void btnSearchForm_Click(object sender, EventArgs e)
        {
            SearchContacts formSearch = new SearchContacts();
            formSearch.Show();
        }
    }
}

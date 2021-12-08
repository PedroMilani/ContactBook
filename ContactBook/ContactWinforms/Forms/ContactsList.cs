using Business;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactWinforms.Forms
{
    public partial class ContactsList : Form
    {
        public ContactsList()
        {
            InitializeComponent();
            dataGridView1.DataSource = ListarContatos();
        }
        public List<ContatoDTO> ListarContatos()
        {
            ContatoBusiness contatoBusiness = new ContatoBusiness();
            return contatoBusiness.ObterTodosContatos();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

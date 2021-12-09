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
    public partial class AddContacts : Form
    {
        public AddContacts()
        {
            InitializeComponent();
        }

        private void btnAddBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContatoDTO contatoDTO = new ContatoDTO();
            if (!string.IsNullOrEmpty(txtNomeAdd.Text))
            {
                contatoDTO.Nome = txtNomeAdd.Text;
            }
            if (!string.IsNullOrEmpty(txtEnderecoAdd.Text))
            {
                contatoDTO.Endereco = txtEnderecoAdd.Text;
            }
            if (!string.IsNullOrEmpty(txtTelAdd.Text))
            {
                contatoDTO.Telefone = txtTelAdd.Text;
            }
            if (!string.IsNullOrEmpty(txtEmailAdd.Text))
            {
                contatoDTO.Email = txtEmailAdd.Text;
            }
            if (!string.IsNullOrEmpty(txtCpfAdd.Text))
            {
                contatoDTO.CPF = txtCpfAdd.Text;
            }
            string msg = string.Empty;
            ContatoBusiness contatoBusiness = new ContatoBusiness();

            msg = contatoBusiness.AdicionarContato(contatoDTO);

            txtNomeAdd.Text = string.Empty;
            txtEnderecoAdd.Text = string.Empty;
            txtEmailAdd.Text = string.Empty;
            txtTelAdd.Text = string.Empty;
            txtCpfAdd.Text = string.Empty;

            MessageBox.Show(msg);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            int id = 0;
            bool parseId = Int32.TryParse(txtIdUpdate.Text, out id);
            if(!string.IsNullOrEmpty(txtIdUpdate.Text) || parseId)
            {
                ContatoDTO contatoDTO = new ContatoDTO();
                if (!string.IsNullOrEmpty(txtNomeAdd.Text))
                {
                    contatoDTO.Nome = txtNomeAdd.Text;
                }
                if (!string.IsNullOrEmpty(txtEnderecoAdd.Text))
                {
                    contatoDTO.Endereco = txtEnderecoAdd.Text;
                }
                if (!string.IsNullOrEmpty(txtTelAdd.Text))
                {
                    contatoDTO.Telefone = txtTelAdd.Text;
                }
                if (!string.IsNullOrEmpty(txtEmailAdd.Text))
                {
                    contatoDTO.Email = txtEmailAdd.Text;
                }
                if (!string.IsNullOrEmpty(txtCpfAdd.Text))
                {
                    contatoDTO.CPF = txtCpfAdd.Text;
                }
                ContatoBusiness contatoBusiness = new ContatoBusiness();

                msg = contatoBusiness.UpdateContato(contatoDTO, id);
            }
            else
            {
                msg = "Insira ID para atualizar.";
            }
            txtNomeAdd.Text = string.Empty;
            txtEnderecoAdd.Text = string.Empty;
            txtEmailAdd.Text = string.Empty;
            txtTelAdd.Text = string.Empty;
            txtCpfAdd.Text = string.Empty;
            MessageBox.Show(msg);
        }
    }
}

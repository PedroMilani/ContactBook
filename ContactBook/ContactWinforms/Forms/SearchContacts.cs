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
    public partial class SearchContacts : Form
    {
        public SearchContacts()
        {
            InitializeComponent();
            txtFill.ForeColor = Color.LightGray;
            txtFill.Text = "Escreva nome, endereço ou ID para pesquisar";
            this.txtFill.Leave += new System.EventHandler(this.txtFill_Leave);
            this.txtFill.Enter += new System.EventHandler(this.txtFill_Enter);
        }
        private void txtFill_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFill.Text))
            {
                txtFill.Text = "Escreva nome, endereço ou ID para pesquisar";
                txtFill.ForeColor = Color.Gray;
            }
        }

        private void txtFill_Enter(object sender, EventArgs e)
        {
            if (txtFill.Text == "Escreva nome, endereço ou ID para pesquisar")
            {
                txtFill.Text = string.Empty;
                txtFill.ForeColor = Color.Black;
            }
        }
        string contatoId = string.Empty;
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFill.Text))
            {
                ContatoBusiness contatoBusiness = new ContatoBusiness();
                ContatoDTO contatoDTO = contatoBusiness.PesquisarContato(txtFill.Text);

                if (contatoDTO != null)
                {
                    txtNome.Text = contatoDTO.Nome;
                    txtEndereco.Text = contatoDTO.Endereco;
                    txtEmail.Text = contatoDTO.Email;
                    maskedTxtTel.Text = contatoDTO.Telefone;
                    maskedTxtCpf.Text = contatoDTO.CPF;
                    txtId.Text = contatoDTO.Id;
                }
                else
                {
                    MessageBox.Show("Nenhum contato foi encontrado");
                }
            }

        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int id = 0;
            string txtIdGet = txtId.Text;
            bool success = Int32.TryParse(txtIdGet, out id);
            string msg = string.Empty;

            if (!string.IsNullOrEmpty(txtIdGet) && success)
            {

                ContatoBusiness contatoBusiness = new ContatoBusiness();
                msg = contatoBusiness.DeletarContato(id);

                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;
                maskedTxtTel.Text = string.Empty;
                maskedTxtCpf.Text = string.Empty;
                txtId.Text = string.Empty;


                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Nada deletado.");
            }
        }

        private void btnPesqEnd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFill.Text))
            {
                ContatoBusiness contatoBusiness = new ContatoBusiness();
                ContatoDTO contatoDTO = contatoBusiness.PesquisarContato(txtFill.Text);

                if (contatoDTO != null)
                {
                    txtNome.Text = contatoDTO.Nome;
                    txtEndereco.Text = contatoDTO.Endereco;
                    txtEmail.Text = contatoDTO.Email;
                    maskedTxtTel.Text = contatoDTO.Telefone;
                    maskedTxtCpf.Text = contatoDTO.CPF;
                    txtId.Text = contatoDTO.Id;
                }
                else
                {
                    MessageBox.Show("Nenhum contato foi encontrado");
                }
            }
        }

        private void btnVoltarPesq_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtEmail.Text = string.Empty;
            maskedTxtTel.Text = string.Empty;
            maskedTxtCpf.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void btnPesqId_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFill.Text))
            {
                ContatoBusiness contatoBusiness = new ContatoBusiness();
                ContatoDTO contatoDTO = contatoBusiness.PesquisarContatoId(txtFill.Text);

                if (contatoDTO != null)
                {
                    txtNome.Text = contatoDTO.Nome;
                    txtEndereco.Text = contatoDTO.Endereco;
                    txtEmail.Text = contatoDTO.Email;
                    maskedTxtTel.Text = contatoDTO.Telefone;
                    maskedTxtCpf.Text = contatoDTO.CPF;
                    txtId.Text = contatoDTO.Id;
                }
                else
                {
                    MessageBox.Show("Nenhum contato foi encontrado");
                }
            }

        }
    }
}

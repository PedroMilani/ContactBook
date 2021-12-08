
namespace ContactWinforms.Forms
{
    partial class SearchContacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFill = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.maskedTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnPesqEnd = new System.Windows.Forms.Button();
            this.btnVoltarPesq = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesqId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFill
            // 
            this.txtFill.Location = new System.Drawing.Point(123, 80);
            this.txtFill.Name = "txtFill";
            this.txtFill.Size = new System.Drawing.Size(394, 23);
            this.txtFill.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNome.Location = new System.Drawing.Point(212, 206);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(235, 23);
            this.txtNome.TabIndex = 14;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEndereco.Location = new System.Drawing.Point(212, 250);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(235, 23);
            this.txtEndereco.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEmail.Location = new System.Drawing.Point(212, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(235, 23);
            this.txtEmail.TabIndex = 16;
            // 
            // maskedTxtTel
            // 
            this.maskedTxtTel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maskedTxtTel.Location = new System.Drawing.Point(212, 294);
            this.maskedTxtTel.Mask = "(99) 00000-0000";
            this.maskedTxtTel.Name = "maskedTxtTel";
            this.maskedTxtTel.ReadOnly = true;
            this.maskedTxtTel.Size = new System.Drawing.Size(235, 23);
            this.maskedTxtTel.TabIndex = 17;
            // 
            // maskedTxtCpf
            // 
            this.maskedTxtCpf.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maskedTxtCpf.Location = new System.Drawing.Point(212, 381);
            this.maskedTxtCpf.Mask = "000.000.000-00";
            this.maskedTxtCpf.Name = "maskedTxtCpf";
            this.maskedTxtCpf.ReadOnly = true;
            this.maskedTxtCpf.Size = new System.Drawing.Size(235, 23);
            this.maskedTxtCpf.TabIndex = 18;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Location = new System.Drawing.Point(123, 123);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 49);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "PESQUISAR POR NOME";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnPesqEnd
            // 
            this.btnPesqEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqEnd.Location = new System.Drawing.Point(280, 123);
            this.btnPesqEnd.Name = "btnPesqEnd";
            this.btnPesqEnd.Size = new System.Drawing.Size(108, 49);
            this.btnPesqEnd.TabIndex = 20;
            this.btnPesqEnd.Text = "PESQUISAR POR ENDEREÇO";
            this.btnPesqEnd.UseVisualStyleBackColor = true;
            this.btnPesqEnd.Click += new System.EventHandler(this.btnPesqEnd_Click);
            // 
            // btnVoltarPesq
            // 
            this.btnVoltarPesq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarPesq.Location = new System.Drawing.Point(520, 209);
            this.btnVoltarPesq.Name = "btnVoltarPesq";
            this.btnVoltarPesq.Size = new System.Drawing.Size(105, 59);
            this.btnVoltarPesq.TabIndex = 21;
            this.btnVoltarPesq.Text = "VOLTAR";
            this.btnVoltarPesq.UseVisualStyleBackColor = true;
            this.btnVoltarPesq.Click += new System.EventHandler(this.btnVoltarPesq_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(520, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 58);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "DELETAR";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Location = new System.Drawing.Point(641, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 23);
            this.txtId.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(261, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 28);
            this.label7.TabIndex = 30;
            this.label7.Text = "PESQUISAR CONTATO";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(593, 123);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 49);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "LIMPAR CAMPOS";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesqId
            // 
            this.btnPesqId.Location = new System.Drawing.Point(431, 123);
            this.btnPesqId.Name = "btnPesqId";
            this.btnPesqId.Size = new System.Drawing.Size(108, 49);
            this.btnPesqId.TabIndex = 32;
            this.btnPesqId.Text = "PESQUISAR POR ID";
            this.btnPesqId.UseVisualStyleBackColor = true;
            this.btnPesqId.Click += new System.EventHandler(this.btnPesqId_Click);
            // 
            // SearchContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesqId);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVoltarPesq);
            this.Controls.Add(this.btnPesqEnd);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.maskedTxtCpf);
            this.Controls.Add(this.maskedTxtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtFill);
            this.Name = "SearchContacts";
            this.Text = "SearchContacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFill;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox maskedTxtTel;
        private System.Windows.Forms.MaskedTextBox maskedTxtCpf;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnPesqEnd;
        private System.Windows.Forms.Button btnVoltarPesq;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesqId;
    }
}
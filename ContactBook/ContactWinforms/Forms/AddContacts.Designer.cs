
namespace ContactWinforms.Forms
{
    partial class AddContacts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeAdd = new System.Windows.Forms.TextBox();
            this.txtEnderecoAdd = new System.Windows.Forms.TextBox();
            this.txtTelAdd = new System.Windows.Forms.TextBox();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.txtCpfAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtIdUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF";
            // 
            // txtNomeAdd
            // 
            this.txtNomeAdd.Location = new System.Drawing.Point(249, 92);
            this.txtNomeAdd.Name = "txtNomeAdd";
            this.txtNomeAdd.Size = new System.Drawing.Size(307, 23);
            this.txtNomeAdd.TabIndex = 5;
            // 
            // txtEnderecoAdd
            // 
            this.txtEnderecoAdd.Location = new System.Drawing.Point(249, 138);
            this.txtEnderecoAdd.Name = "txtEnderecoAdd";
            this.txtEnderecoAdd.Size = new System.Drawing.Size(307, 23);
            this.txtEnderecoAdd.TabIndex = 6;
            // 
            // txtTelAdd
            // 
            this.txtTelAdd.Location = new System.Drawing.Point(249, 184);
            this.txtTelAdd.Name = "txtTelAdd";
            this.txtTelAdd.Size = new System.Drawing.Size(307, 23);
            this.txtTelAdd.TabIndex = 7;
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Location = new System.Drawing.Point(249, 230);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(307, 23);
            this.txtEmailAdd.TabIndex = 8;
            // 
            // txtCpfAdd
            // 
            this.txtCpfAdd.Location = new System.Drawing.Point(249, 274);
            this.txtCpfAdd.Name = "txtCpfAdd";
            this.txtCpfAdd.Size = new System.Drawing.Size(307, 23);
            this.txtCpfAdd.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(211, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "ADICIONAR OU ATUALIZAR CONTATO";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(304, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 52);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADICIONAR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddBack
            // 
            this.btnAddBack.Location = new System.Drawing.Point(445, 324);
            this.btnAddBack.Name = "btnAddBack";
            this.btnAddBack.Size = new System.Drawing.Size(111, 52);
            this.btnAddBack.TabIndex = 12;
            this.btnAddBack.Text = "VOLTAR";
            this.btnAddBack.UseVisualStyleBackColor = true;
            this.btnAddBack.Click += new System.EventHandler(this.btnAddBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(167, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 51);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "ATUALIZAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtIdUpdate
            // 
            this.txtIdUpdate.Location = new System.Drawing.Point(98, 340);
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.Size = new System.Drawing.Size(50, 23);
            this.txtIdUpdate.TabIndex = 15;
            // 
            // AddContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.txtIdUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCpfAdd);
            this.Controls.Add(this.txtEmailAdd);
            this.Controls.Add(this.txtTelAdd);
            this.Controls.Add(this.txtEnderecoAdd);
            this.Controls.Add(this.txtNomeAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddContacts";
            this.Text = "AddContacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeAdd;
        private System.Windows.Forms.TextBox txtEnderecoAdd;
        private System.Windows.Forms.TextBox txtTelAdd;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.TextBox txtCpfAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtIdUpdate;
    }
}
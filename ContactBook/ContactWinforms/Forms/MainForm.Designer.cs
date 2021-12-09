
namespace ContactWinforms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddForm = new System.Windows.Forms.Button();
            this.btnSearchForm = new System.Windows.Forms.Button();
            this.btnListForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddForm.Location = new System.Drawing.Point(262, 174);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(150, 120);
            this.btnAddForm.TabIndex = 1;
            this.btnAddForm.Text = "ADICIONAR / ATUALIZAR CONTATO";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // btnSearchForm
            // 
            this.btnSearchForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchForm.Location = new System.Drawing.Point(455, 174);
            this.btnSearchForm.Name = "btnSearchForm";
            this.btnSearchForm.Size = new System.Drawing.Size(150, 120);
            this.btnSearchForm.TabIndex = 2;
            this.btnSearchForm.Text = "PESQUISAR / DELETAR CONTATO";
            this.btnSearchForm.UseVisualStyleBackColor = true;
            this.btnSearchForm.Click += new System.EventHandler(this.btnSearchForm_Click);
            // 
            // btnListForm
            // 
            this.btnListForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListForm.Location = new System.Drawing.Point(70, 174);
            this.btnListForm.Name = "btnListForm";
            this.btnListForm.Size = new System.Drawing.Size(150, 120);
            this.btnListForm.TabIndex = 4;
            this.btnListForm.Text = "LISTAR TODOS OS CONTATO";
            this.btnListForm.UseVisualStyleBackColor = true;
            this.btnListForm.Click += new System.EventHandler(this.btnListForm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "AGENDA DE CONTATOS (CRUD)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListForm);
            this.Controls.Add(this.btnSearchForm);
            this.Controls.Add(this.btnAddForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.Button btnSearchForm;
        private System.Windows.Forms.Button btnListForm;
        private System.Windows.Forms.Label label1;
    }
}


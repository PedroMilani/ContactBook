
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
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Location = new System.Drawing.Point(348, 171);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(75, 23);
            this.btnAddForm.TabIndex = 1;
            this.btnAddForm.Text = "Add";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // btnSearchForm
            // 
            this.btnSearchForm.Location = new System.Drawing.Point(562, 171);
            this.btnSearchForm.Name = "btnSearchForm";
            this.btnSearchForm.Size = new System.Drawing.Size(75, 23);
            this.btnSearchForm.TabIndex = 2;
            this.btnSearchForm.Text = "Search";
            this.btnSearchForm.UseVisualStyleBackColor = true;
            this.btnSearchForm.Click += new System.EventHandler(this.btnSearchForm_Click);
            // 
            // btnListForm
            // 
            this.btnListForm.Location = new System.Drawing.Point(149, 170);
            this.btnListForm.Name = "btnListForm";
            this.btnListForm.Size = new System.Drawing.Size(75, 23);
            this.btnListForm.TabIndex = 4;
            this.btnListForm.Text = "List";
            this.btnListForm.UseVisualStyleBackColor = true;
            this.btnListForm.Click += new System.EventHandler(this.btnListForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListForm);
            this.Controls.Add(this.btnSearchForm);
            this.Controls.Add(this.btnAddForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.Button btnSearchForm;
        private System.Windows.Forms.Button btnListForm;
    }
}


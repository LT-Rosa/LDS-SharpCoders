namespace Application
{
    partial class FormMain
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
            btnOpen = new System.Windows.Forms.Button();
            btnSubmit = new System.Windows.Forms.Button();
            btnBeforePage = new System.Windows.Forms.Button();
            btnNextPage = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            lblPages = new System.Windows.Forms.Label();
            txtBoxRevenue = new System.Windows.Forms.TextBox();
            lblRevenue = new System.Windows.Forms.Label();
            lblExpenses = new System.Windows.Forms.Label();
            txtBoxExpenses = new System.Windows.Forms.TextBox();
            btnAnalisar = new System.Windows.Forms.Button();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new System.Drawing.Point(12, 22);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(121, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Abrir Ficheiro";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += BtnOpen_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(12, 214);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(121, 23);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submeter";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Visible = false;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // btnBeforePage
            // 
            btnBeforePage.Enabled = false;
            btnBeforePage.Location = new System.Drawing.Point(12, 450);
            btnBeforePage.Name = "btnBeforePage";
            btnBeforePage.Size = new System.Drawing.Size(121, 23);
            btnBeforePage.TabIndex = 2;
            btnBeforePage.Text = "Pagina Anterior";
            btnBeforePage.UseVisualStyleBackColor = true;
            btnBeforePage.Click += BtnBeforePage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Enabled = false;
            btnNextPage.Location = new System.Drawing.Point(12, 499);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new System.Drawing.Size(121, 23);
            btnNextPage.TabIndex = 3;
            btnNextPage.Text = "Pagina Seguinte";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += BtnNextPage_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new System.Drawing.Point(154, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(649, 525);
            dataGridView1.TabIndex = 4;
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Location = new System.Drawing.Point(43, 328);
            lblPages.Name = "lblPages";
            lblPages.Size = new System.Drawing.Size(48, 15);
            lblPages.TabIndex = 5;
            lblPages.Text = "Páginas";
            // 
            // txtBoxRevenue
            // 
            txtBoxRevenue.Location = new System.Drawing.Point(12, 126);
            txtBoxRevenue.Name = "txtBoxRevenue";
            txtBoxRevenue.Size = new System.Drawing.Size(121, 23);
            txtBoxRevenue.TabIndex = 6;
            txtBoxRevenue.Visible = false;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Location = new System.Drawing.Point(12, 99);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new System.Drawing.Size(92, 15);
            lblRevenue.TabIndex = 7;
            lblRevenue.Text = "Previsão Receita";
            lblRevenue.Visible = false;
            // 
            // lblExpenses
            // 
            lblExpenses.AutoSize = true;
            lblExpenses.Location = new System.Drawing.Point(12, 155);
            lblExpenses.Name = "lblExpenses";
            lblExpenses.Size = new System.Drawing.Size(97, 15);
            lblExpenses.TabIndex = 8;
            lblExpenses.Text = "Previsão Despesa";
            lblExpenses.Visible = false;
            // 
            // txtBoxExpenses
            // 
            txtBoxExpenses.Location = new System.Drawing.Point(12, 178);
            txtBoxExpenses.Name = "txtBoxExpenses";
            txtBoxExpenses.Size = new System.Drawing.Size(121, 23);
            txtBoxExpenses.TabIndex = 9;
            txtBoxExpenses.Visible = false;
            // 
            // btnAnalisar
            // 
            btnAnalisar.Location = new System.Drawing.Point(12, 62);
            btnAnalisar.Name = "btnAnalisar";
            btnAnalisar.Size = new System.Drawing.Size(121, 23);
            btnAnalisar.TabIndex = 10;
            btnAnalisar.Text = "Analisar";
            btnAnalisar.UseVisualStyleBackColor = true;
            btnAnalisar.Click += BtnAnalisar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(12, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(121, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(824, 574);
            Controls.Add(btnCancel);
            Controls.Add(btnAnalisar);
            Controls.Add(txtBoxExpenses);
            Controls.Add(lblExpenses);
            Controls.Add(lblRevenue);
            Controls.Add(txtBoxRevenue);
            Controls.Add(lblPages);
            Controls.Add(dataGridView1);
            Controls.Add(btnNextPage);
            Controls.Add(btnBeforePage);
            Controls.Add(btnSubmit);
            Controls.Add(btnOpen);
            Name = "FormMain";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.Button btnSubmit;
        public System.Windows.Forms.Button btnBeforePage;
        public System.Windows.Forms.Button btnNextPage;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtBoxRevenue;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.TextBox txtBoxExpenses;
        public System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button btnCancel;
    }
}
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
            btnOpen.Click += button1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(12, 62);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(121, 23);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Enviar Ficheiro";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnBeforePage
            // 
            btnBeforePage.Location = new System.Drawing.Point(12, 363);
            btnBeforePage.Name = "btnBeforePage";
            btnBeforePage.Size = new System.Drawing.Size(121, 23);
            btnBeforePage.TabIndex = 2;
            btnBeforePage.Text = "Pagina Anterior";
            btnBeforePage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new System.Drawing.Point(12, 403);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new System.Drawing.Size(121, 23);
            btnNextPage.TabIndex = 3;
            btnNextPage.Text = "Pagina Seguinte";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(139, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(649, 416);
            dataGridView1.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(824, 459);
            Controls.Add(dataGridView1);
            Controls.Add(btnNextPage);
            Controls.Add(btnBeforePage);
            Controls.Add(btnSubmit);
            Controls.Add(btnOpen);
            Name = "FormMain";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBeforePage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
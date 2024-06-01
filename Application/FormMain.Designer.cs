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
            BtnOpen = new System.Windows.Forms.Button();
            BtnSubmit = new System.Windows.Forms.Button();
            BtnBeforePage = new System.Windows.Forms.Button();
            BtnNextPage = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnOpen
            // 
            BtnOpen.Location = new System.Drawing.Point(12, 22);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new System.Drawing.Size(121, 23);
            BtnOpen.TabIndex = 0;
            BtnOpen.Text = "Abrir Ficheiro";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new System.Drawing.Point(12, 62);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new System.Drawing.Size(121, 23);
            BtnSubmit.TabIndex = 1;
            BtnSubmit.Text = "Enviar Ficheiro";
            BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // BtnBeforePage
            // 
            BtnBeforePage.Location = new System.Drawing.Point(12, 363);
            BtnBeforePage.Name = "BtnBeforePage";
            BtnBeforePage.Size = new System.Drawing.Size(121, 23);
            BtnBeforePage.TabIndex = 2;
            BtnBeforePage.Text = "Pagina Anterior";
            BtnBeforePage.UseVisualStyleBackColor = true;
            // 
            // BtnNextPage
            // 
            BtnNextPage.Location = new System.Drawing.Point(12, 403);
            BtnNextPage.Name = "BtnNextPage";
            BtnNextPage.Size = new System.Drawing.Size(121, 23);
            BtnNextPage.TabIndex = 3;
            BtnNextPage.Text = "Pagina Seguinte";
            BtnNextPage.UseVisualStyleBackColor = true;
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
            Controls.Add(BtnNextPage);
            Controls.Add(BtnBeforePage);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnOpen);
            Name = "FormMain";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnBeforePage;
        private System.Windows.Forms.Button BtnNextPage;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
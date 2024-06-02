namespace Application
{
    partial class FormLog
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
            textBoxLog = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new System.Drawing.Point(12, 12);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxLog.Size = new System.Drawing.Size(776, 368);
            textBoxLog.TabIndex = 0;
            // 
            // FormLog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 393);
            Controls.Add(textBoxLog);
            Name = "FormLog";
            Text = "Registo de erros detetados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.TextBox textBoxLog;
    }
}
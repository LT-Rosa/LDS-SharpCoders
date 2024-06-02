namespace Application
{
    partial class FormWaiting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWaiting));
            lblMessage = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new System.Drawing.Point(50, 9);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(290, 15);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Por favor aguarde, estamos processado a informação.";
            // 
            // FormWaiting
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(398, 110);
            Controls.Add(lblMessage);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormWaiting";
            Text = "FormWaiting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
    }
}
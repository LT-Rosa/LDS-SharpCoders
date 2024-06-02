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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblMessage.Location = new System.Drawing.Point(12, 9);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(380, 21);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Por favor aguarde, estamos à processar a informação.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gear;
            pictureBox1.Location = new System.Drawing.Point(149, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(67, 65);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormWaiting
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(398, 110);
            Controls.Add(pictureBox1);
            Controls.Add(lblMessage);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormWaiting";
            Text = "FormWaiting";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
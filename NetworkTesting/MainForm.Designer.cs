namespace NetworkTesting
{
    partial class MainForm
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
            this.Connect_Button = new System.Windows.Forms.Button();
            this.StartServer_Button = new System.Windows.Forms.Button();
            this.Console_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(12, 12);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(133, 66);
            this.Connect_Button.TabIndex = 0;
            this.Connect_Button.Text = "Connect as client";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // StartServer_Button
            // 
            this.StartServer_Button.Location = new System.Drawing.Point(160, 12);
            this.StartServer_Button.Name = "StartServer_Button";
            this.StartServer_Button.Size = new System.Drawing.Size(140, 66);
            this.StartServer_Button.TabIndex = 1;
            this.StartServer_Button.Text = "Start Server";
            this.StartServer_Button.UseVisualStyleBackColor = true;
            this.StartServer_Button.Click += new System.EventHandler(this.StartServer_Button_Click);
            // 
            // Console_TextBox
            // 
            this.Console_TextBox.Location = new System.Drawing.Point(63, 146);
            this.Console_TextBox.Name = "Console_TextBox";
            this.Console_TextBox.ReadOnly = true;
            this.Console_TextBox.Size = new System.Drawing.Size(656, 275);
            this.Console_TextBox.TabIndex = 2;
            this.Console_TextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Console_TextBox);
            this.Controls.Add(this.StartServer_Button);
            this.Controls.Add(this.Connect_Button);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Button StartServer_Button;
        private System.Windows.Forms.RichTextBox Console_TextBox;
    }
}


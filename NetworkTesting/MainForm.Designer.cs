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
            this.StartInstance_Button = new System.Windows.Forms.Button();
            this.SystemSelection_TabControl = new System.Windows.Forms.TabControl();
            this.BasicConnect_TabPage = new System.Windows.Forms.TabPage();
            this.NATHolePunch_TabPage = new System.Windows.Forms.TabPage();
            this.BottomHorizontal_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.Vertical_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.Console_TextBox = new System.Windows.Forms.RichTextBox();
            this.SystemSelection_TabControl.SuspendLayout();
            this.BasicConnect_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomHorizontal_SplitContainer)).BeginInit();
            this.BottomHorizontal_SplitContainer.Panel1.SuspendLayout();
            this.BottomHorizontal_SplitContainer.Panel2.SuspendLayout();
            this.BottomHorizontal_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical_SplitContainer)).BeginInit();
            this.Vertical_SplitContainer.Panel1.SuspendLayout();
            this.Vertical_SplitContainer.Panel2.SuspendLayout();
            this.Vertical_SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(6, 6);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(133, 66);
            this.Connect_Button.TabIndex = 0;
            this.Connect_Button.Text = "Connect as client";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // StartServer_Button
            // 
            this.StartServer_Button.Location = new System.Drawing.Point(145, 6);
            this.StartServer_Button.Name = "StartServer_Button";
            this.StartServer_Button.Size = new System.Drawing.Size(140, 66);
            this.StartServer_Button.TabIndex = 1;
            this.StartServer_Button.Text = "Start Server";
            this.StartServer_Button.UseVisualStyleBackColor = true;
            this.StartServer_Button.Click += new System.EventHandler(this.StartServer_Button_Click);
            // 
            // StartInstance_Button
            // 
            this.StartInstance_Button.AutoSize = true;
            this.StartInstance_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartInstance_Button.Location = new System.Drawing.Point(10, 10);
            this.StartInstance_Button.Name = "StartInstance_Button";
            this.StartInstance_Button.Size = new System.Drawing.Size(155, 30);
            this.StartInstance_Button.TabIndex = 3;
            this.StartInstance_Button.Text = "Start New Instance";
            this.StartInstance_Button.UseVisualStyleBackColor = true;
            this.StartInstance_Button.Click += new System.EventHandler(this.StartInstance_Button_Click);
            // 
            // SystemSelection_TabControl
            // 
            this.SystemSelection_TabControl.Controls.Add(this.BasicConnect_TabPage);
            this.SystemSelection_TabControl.Controls.Add(this.NATHolePunch_TabPage);
            this.SystemSelection_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemSelection_TabControl.Location = new System.Drawing.Point(10, 10);
            this.SystemSelection_TabControl.Name = "SystemSelection_TabControl";
            this.SystemSelection_TabControl.SelectedIndex = 0;
            this.SystemSelection_TabControl.Size = new System.Drawing.Size(671, 187);
            this.SystemSelection_TabControl.TabIndex = 4;
            // 
            // BasicConnect_TabPage
            // 
            this.BasicConnect_TabPage.BackColor = System.Drawing.Color.White;
            this.BasicConnect_TabPage.Controls.Add(this.Connect_Button);
            this.BasicConnect_TabPage.Controls.Add(this.StartServer_Button);
            this.BasicConnect_TabPage.Location = new System.Drawing.Point(4, 29);
            this.BasicConnect_TabPage.Name = "BasicConnect_TabPage";
            this.BasicConnect_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BasicConnect_TabPage.Size = new System.Drawing.Size(663, 154);
            this.BasicConnect_TabPage.TabIndex = 0;
            this.BasicConnect_TabPage.Text = "Basic Connect";
            // 
            // NATHolePunch_TabPage
            // 
            this.NATHolePunch_TabPage.Location = new System.Drawing.Point(4, 29);
            this.NATHolePunch_TabPage.Name = "NATHolePunch_TabPage";
            this.NATHolePunch_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NATHolePunch_TabPage.Size = new System.Drawing.Size(1006, 305);
            this.NATHolePunch_TabPage.TabIndex = 1;
            this.NATHolePunch_TabPage.Text = "NatHolePunch";
            this.NATHolePunch_TabPage.UseVisualStyleBackColor = true;
            // 
            // BottomHorizontal_SplitContainer
            // 
            this.BottomHorizontal_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomHorizontal_SplitContainer.Location = new System.Drawing.Point(10, 10);
            this.BottomHorizontal_SplitContainer.Name = "BottomHorizontal_SplitContainer";
            // 
            // BottomHorizontal_SplitContainer.Panel1
            // 
            this.BottomHorizontal_SplitContainer.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.BottomHorizontal_SplitContainer.Panel1.Controls.Add(this.SystemSelection_TabControl);
            this.BottomHorizontal_SplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // BottomHorizontal_SplitContainer.Panel2
            // 
            this.BottomHorizontal_SplitContainer.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.BottomHorizontal_SplitContainer.Panel2.Controls.Add(this.StartInstance_Button);
            this.BottomHorizontal_SplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.BottomHorizontal_SplitContainer.Size = new System.Drawing.Size(873, 207);
            this.BottomHorizontal_SplitContainer.SplitterDistance = 691;
            this.BottomHorizontal_SplitContainer.SplitterWidth = 5;
            this.BottomHorizontal_SplitContainer.TabIndex = 1;
            // 
            // Vertical_SplitContainer
            // 
            this.Vertical_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vertical_SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.Vertical_SplitContainer.Name = "Vertical_SplitContainer";
            this.Vertical_SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Vertical_SplitContainer.Panel1
            // 
            this.Vertical_SplitContainer.Panel1.BackColor = System.Drawing.Color.DimGray;
            this.Vertical_SplitContainer.Panel1.Controls.Add(this.BottomHorizontal_SplitContainer);
            this.Vertical_SplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // Vertical_SplitContainer.Panel2
            // 
            this.Vertical_SplitContainer.Panel2.BackColor = System.Drawing.Color.DimGray;
            this.Vertical_SplitContainer.Panel2.Controls.Add(this.Console_TextBox);
            this.Vertical_SplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.Vertical_SplitContainer.Size = new System.Drawing.Size(893, 763);
            this.Vertical_SplitContainer.SplitterDistance = 227;
            this.Vertical_SplitContainer.SplitterWidth = 5;
            this.Vertical_SplitContainer.TabIndex = 0;
            // 
            // Console_TextBox
            // 
            this.Console_TextBox.BackColor = System.Drawing.Color.Cornsilk;
            this.Console_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Console_TextBox.Location = new System.Drawing.Point(10, 10);
            this.Console_TextBox.Name = "Console_TextBox";
            this.Console_TextBox.ReadOnly = true;
            this.Console_TextBox.Size = new System.Drawing.Size(873, 511);
            this.Console_TextBox.TabIndex = 2;
            this.Console_TextBox.Text = "Test\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 763);
            this.Controls.Add(this.Vertical_SplitContainer);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.SystemSelection_TabControl.ResumeLayout(false);
            this.BasicConnect_TabPage.ResumeLayout(false);
            this.BottomHorizontal_SplitContainer.Panel1.ResumeLayout(false);
            this.BottomHorizontal_SplitContainer.Panel2.ResumeLayout(false);
            this.BottomHorizontal_SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomHorizontal_SplitContainer)).EndInit();
            this.BottomHorizontal_SplitContainer.ResumeLayout(false);
            this.Vertical_SplitContainer.Panel1.ResumeLayout(false);
            this.Vertical_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Vertical_SplitContainer)).EndInit();
            this.Vertical_SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Button StartServer_Button;
        private System.Windows.Forms.Button StartInstance_Button;
        private System.Windows.Forms.TabControl SystemSelection_TabControl;
        private System.Windows.Forms.TabPage BasicConnect_TabPage;
        private System.Windows.Forms.TabPage NATHolePunch_TabPage;
        private System.Windows.Forms.SplitContainer BottomHorizontal_SplitContainer;
        private System.Windows.Forms.SplitContainer Vertical_SplitContainer;
        private System.Windows.Forms.RichTextBox Console_TextBox;
    }
}


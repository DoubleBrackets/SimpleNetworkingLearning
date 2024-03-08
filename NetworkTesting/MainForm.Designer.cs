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
            this.BasicTCPConnect_Button = new System.Windows.Forms.Button();
            this.BasicTCPStartServer_Button = new System.Windows.Forms.Button();
            this.StartInstance_Button = new System.Windows.Forms.Button();
            this.SystemSelection_TabControl = new System.Windows.Forms.TabControl();
            this.BasicConnect_TabPage = new System.Windows.Forms.TabPage();
            this.BasicTCPMessage_Label = new System.Windows.Forms.Label();
            this.BasicTCPMessage_TextBox = new System.Windows.Forms.TextBox();
            this.IPField_Label = new System.Windows.Forms.Label();
            this.BasicTCPIPAddress_TextBox = new System.Windows.Forms.TextBox();
            this.BasicUDP_TabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.BasicUDPIP_Textbox = new System.Windows.Forms.TextBox();
            this.BasicUDPConnect_Button = new System.Windows.Forms.Button();
            this.BasicUDPStartListening_Button = new System.Windows.Forms.Button();
            this.NATHolePunch_TabPage = new System.Windows.Forms.TabPage();
            this.BottomHorizontal_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ShowIpInfo_Button = new System.Windows.Forms.Button();
            this.Vertical_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.Console_TextBox = new System.Windows.Forms.RichTextBox();
            this.SystemSelection_TabControl.SuspendLayout();
            this.BasicConnect_TabPage.SuspendLayout();
            this.BasicUDP_TabPage.SuspendLayout();
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
            // BasicTCPConnect_Button
            // 
            this.BasicTCPConnect_Button.Location = new System.Drawing.Point(6, 6);
            this.BasicTCPConnect_Button.Name = "BasicTCPConnect_Button";
            this.BasicTCPConnect_Button.Size = new System.Drawing.Size(133, 66);
            this.BasicTCPConnect_Button.TabIndex = 0;
            this.BasicTCPConnect_Button.Text = "Connect as client";
            this.BasicTCPConnect_Button.UseVisualStyleBackColor = true;
            this.BasicTCPConnect_Button.Click += new System.EventHandler(this.BasicTCPConnect_Button_Click);
            // 
            // BasicTCPStartServer_Button
            // 
            this.BasicTCPStartServer_Button.Location = new System.Drawing.Point(6, 78);
            this.BasicTCPStartServer_Button.Name = "BasicTCPStartServer_Button";
            this.BasicTCPStartServer_Button.Size = new System.Drawing.Size(133, 66);
            this.BasicTCPStartServer_Button.TabIndex = 1;
            this.BasicTCPStartServer_Button.Text = "Start Server";
            this.BasicTCPStartServer_Button.UseVisualStyleBackColor = true;
            this.BasicTCPStartServer_Button.Click += new System.EventHandler(this.BasicTCPStartServer_Button_Click);
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
            this.SystemSelection_TabControl.Controls.Add(this.BasicUDP_TabPage);
            this.SystemSelection_TabControl.Controls.Add(this.NATHolePunch_TabPage);
            this.SystemSelection_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemSelection_TabControl.Location = new System.Drawing.Point(10, 10);
            this.SystemSelection_TabControl.Name = "SystemSelection_TabControl";
            this.SystemSelection_TabControl.SelectedIndex = 0;
            this.SystemSelection_TabControl.Size = new System.Drawing.Size(675, 187);
            this.SystemSelection_TabControl.TabIndex = 4;
            // 
            // BasicConnect_TabPage
            // 
            this.BasicConnect_TabPage.BackColor = System.Drawing.Color.White;
            this.BasicConnect_TabPage.Controls.Add(this.BasicTCPMessage_Label);
            this.BasicConnect_TabPage.Controls.Add(this.BasicTCPMessage_TextBox);
            this.BasicConnect_TabPage.Controls.Add(this.IPField_Label);
            this.BasicConnect_TabPage.Controls.Add(this.BasicTCPIPAddress_TextBox);
            this.BasicConnect_TabPage.Controls.Add(this.BasicTCPConnect_Button);
            this.BasicConnect_TabPage.Controls.Add(this.BasicTCPStartServer_Button);
            this.BasicConnect_TabPage.Location = new System.Drawing.Point(4, 29);
            this.BasicConnect_TabPage.Name = "BasicConnect_TabPage";
            this.BasicConnect_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BasicConnect_TabPage.Size = new System.Drawing.Size(667, 154);
            this.BasicConnect_TabPage.TabIndex = 0;
            this.BasicConnect_TabPage.Text = "Basic TCP";
            // 
            // BasicTCPMessage_Label
            // 
            this.BasicTCPMessage_Label.AutoSize = true;
            this.BasicTCPMessage_Label.Location = new System.Drawing.Point(145, 40);
            this.BasicTCPMessage_Label.Name = "BasicTCPMessage_Label";
            this.BasicTCPMessage_Label.Size = new System.Drawing.Size(118, 20);
            this.BasicTCPMessage_Label.TabIndex = 5;
            this.BasicTCPMessage_Label.Text = "Client Message";
            // 
            // BasicTCPMessage_TextBox
            // 
            this.BasicTCPMessage_TextBox.Location = new System.Drawing.Point(269, 37);
            this.BasicTCPMessage_TextBox.Name = "BasicTCPMessage_TextBox";
            this.BasicTCPMessage_TextBox.Size = new System.Drawing.Size(371, 26);
            this.BasicTCPMessage_TextBox.TabIndex = 4;
            this.BasicTCPMessage_TextBox.TextChanged += new System.EventHandler(this.BasicTCPMessage_TextBox_TextChanged);
            // 
            // IPField_Label
            // 
            this.IPField_Label.AutoSize = true;
            this.IPField_Label.Location = new System.Drawing.Point(145, 9);
            this.IPField_Label.Name = "IPField_Label";
            this.IPField_Label.Size = new System.Drawing.Size(24, 20);
            this.IPField_Label.TabIndex = 3;
            this.IPField_Label.Text = "IP";
            // 
            // BasicTCPIPAddress_TextBox
            // 
            this.BasicTCPIPAddress_TextBox.Location = new System.Drawing.Point(175, 6);
            this.BasicTCPIPAddress_TextBox.Name = "BasicTCPIPAddress_TextBox";
            this.BasicTCPIPAddress_TextBox.Size = new System.Drawing.Size(465, 26);
            this.BasicTCPIPAddress_TextBox.TabIndex = 2;
            this.BasicTCPIPAddress_TextBox.Text = "24.199.77.221";
            this.BasicTCPIPAddress_TextBox.TextChanged += new System.EventHandler(this.BasicTCPIPAddress_TextBox_TextChanged);
            // 
            // BasicUDP_TabPage
            // 
            this.BasicUDP_TabPage.Controls.Add(this.label1);
            this.BasicUDP_TabPage.Controls.Add(this.BasicUDPIP_Textbox);
            this.BasicUDP_TabPage.Controls.Add(this.BasicUDPConnect_Button);
            this.BasicUDP_TabPage.Controls.Add(this.BasicUDPStartListening_Button);
            this.BasicUDP_TabPage.Location = new System.Drawing.Point(4, 29);
            this.BasicUDP_TabPage.Name = "BasicUDP_TabPage";
            this.BasicUDP_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BasicUDP_TabPage.Size = new System.Drawing.Size(667, 154);
            this.BasicUDP_TabPage.TabIndex = 2;
            this.BasicUDP_TabPage.Text = "Basic UDP";
            this.BasicUDP_TabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP";
            // 
            // BasicUDPIP_Textbox
            // 
            this.BasicUDPIP_Textbox.Location = new System.Drawing.Point(392, 7);
            this.BasicUDPIP_Textbox.Name = "BasicUDPIP_Textbox";
            this.BasicUDPIP_Textbox.Size = new System.Drawing.Size(265, 26);
            this.BasicUDPIP_Textbox.TabIndex = 6;
            this.BasicUDPIP_Textbox.TextChanged += new System.EventHandler(this.BasicUDPIP_Textbox_TextChanged);
            // 
            // BasicUDPConnect_Button
            // 
            this.BasicUDPConnect_Button.Location = new System.Drawing.Point(6, 7);
            this.BasicUDPConnect_Button.Name = "BasicUDPConnect_Button";
            this.BasicUDPConnect_Button.Size = new System.Drawing.Size(133, 66);
            this.BasicUDPConnect_Button.TabIndex = 4;
            this.BasicUDPConnect_Button.Text = "Send Packets";
            this.BasicUDPConnect_Button.UseVisualStyleBackColor = true;
            this.BasicUDPConnect_Button.Click += new System.EventHandler(this.BasicUDPConnect_Button_Click);
            // 
            // BasicUDPStartListening_Button
            // 
            this.BasicUDPStartListening_Button.Location = new System.Drawing.Point(145, 7);
            this.BasicUDPStartListening_Button.Name = "BasicUDPStartListening_Button";
            this.BasicUDPStartListening_Button.Size = new System.Drawing.Size(140, 66);
            this.BasicUDPStartListening_Button.TabIndex = 5;
            this.BasicUDPStartListening_Button.Text = "Start Listening";
            this.BasicUDPStartListening_Button.UseVisualStyleBackColor = true;
            this.BasicUDPStartListening_Button.Click += new System.EventHandler(this.BasicUDPStartListening_Button_Click);
            // 
            // NATHolePunch_TabPage
            // 
            this.NATHolePunch_TabPage.Location = new System.Drawing.Point(4, 29);
            this.NATHolePunch_TabPage.Name = "NATHolePunch_TabPage";
            this.NATHolePunch_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NATHolePunch_TabPage.Size = new System.Drawing.Size(667, 154);
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
            this.BottomHorizontal_SplitContainer.Panel2.Controls.Add(this.ShowIpInfo_Button);
            this.BottomHorizontal_SplitContainer.Panel2.Controls.Add(this.StartInstance_Button);
            this.BottomHorizontal_SplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.BottomHorizontal_SplitContainer.Size = new System.Drawing.Size(873, 207);
            this.BottomHorizontal_SplitContainer.SplitterDistance = 695;
            this.BottomHorizontal_SplitContainer.SplitterWidth = 5;
            this.BottomHorizontal_SplitContainer.TabIndex = 1;
            // 
            // ShowIpInfo_Button
            // 
            this.ShowIpInfo_Button.AutoSize = true;
            this.ShowIpInfo_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowIpInfo_Button.Location = new System.Drawing.Point(9, 46);
            this.ShowIpInfo_Button.Name = "ShowIpInfo_Button";
            this.ShowIpInfo_Button.Size = new System.Drawing.Size(110, 30);
            this.ShowIpInfo_Button.TabIndex = 4;
            this.ShowIpInfo_Button.Text = "Show IP Info";
            this.ShowIpInfo_Button.UseVisualStyleBackColor = true;
            this.ShowIpInfo_Button.Click += new System.EventHandler(this.ShowIpInfo_Button_Click);
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
            this.BasicConnect_TabPage.PerformLayout();
            this.BasicUDP_TabPage.ResumeLayout(false);
            this.BasicUDP_TabPage.PerformLayout();
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

        private System.Windows.Forms.Button BasicTCPConnect_Button;
        private System.Windows.Forms.Button BasicTCPStartServer_Button;
        private System.Windows.Forms.Button StartInstance_Button;
        private System.Windows.Forms.TabControl SystemSelection_TabControl;
        private System.Windows.Forms.TabPage BasicConnect_TabPage;
        private System.Windows.Forms.TabPage NATHolePunch_TabPage;
        private System.Windows.Forms.SplitContainer BottomHorizontal_SplitContainer;
        private System.Windows.Forms.SplitContainer Vertical_SplitContainer;
        private System.Windows.Forms.RichTextBox Console_TextBox;
        private System.Windows.Forms.TextBox BasicTCPIPAddress_TextBox;
        private System.Windows.Forms.Button ShowIpInfo_Button;
        private System.Windows.Forms.Label IPField_Label;
        private System.Windows.Forms.TabPage BasicUDP_TabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BasicUDPIP_Textbox;
        private System.Windows.Forms.Button BasicUDPConnect_Button;
        private System.Windows.Forms.Button BasicUDPStartListening_Button;
        private System.Windows.Forms.Label BasicTCPMessage_Label;
        private System.Windows.Forms.TextBox BasicTCPMessage_TextBox;
    }
}


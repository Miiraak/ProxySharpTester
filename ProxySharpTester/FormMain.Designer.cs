namespace ProxySharpTester
{
    partial class FormMain
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
            buttonGetProxies = new Button();
            buttonGetUsedProxies = new Button();
            buttonGetSingleProxy = new Button();
            buttonGetSingleRandomProxy = new Button();
            buttonRenewQueue = new Button();
            buttonGetIndex = new Button();
            buttonPopProxy = new Button();
            buttonAddProxy = new Button();
            buttonRenewFilteredProxies = new Button();
            richTextBoxProxies = new RichTextBox();
            buttonClearLog = new Button();
            textBoxCountryCode = new TextBox();
            label3 = new Label();
            textBoxAddProxyIP = new TextBox();
            textBoxGetIndex = new TextBox();
            label4 = new Label();
            checkBoxRenewFilteredProxies = new CheckBox();
            textBoxAddProxyPort = new TextBox();
            SuspendLayout();
            // 
            // buttonGetProxies
            // 
            buttonGetProxies.Location = new Point(12, 12);
            buttonGetProxies.Name = "buttonGetProxies";
            buttonGetProxies.Size = new Size(148, 30);
            buttonGetProxies.TabIndex = 0;
            buttonGetProxies.Text = "GetProxies";
            buttonGetProxies.UseVisualStyleBackColor = true;
            buttonGetProxies.Click += ButtonGetProxies_Click;
            // 
            // buttonGetUsedProxies
            // 
            buttonGetUsedProxies.Location = new Point(12, 192);
            buttonGetUsedProxies.Name = "buttonGetUsedProxies";
            buttonGetUsedProxies.Size = new Size(148, 30);
            buttonGetUsedProxies.TabIndex = 1;
            buttonGetUsedProxies.Text = "GetUsedProxies";
            buttonGetUsedProxies.UseVisualStyleBackColor = true;
            buttonGetUsedProxies.Click += ButtonGetUsedProxies_Click;
            // 
            // buttonGetSingleProxy
            // 
            buttonGetSingleProxy.Location = new Point(12, 72);
            buttonGetSingleProxy.Name = "buttonGetSingleProxy";
            buttonGetSingleProxy.Size = new Size(148, 30);
            buttonGetSingleProxy.TabIndex = 2;
            buttonGetSingleProxy.Text = "GetSingleProxy";
            buttonGetSingleProxy.UseVisualStyleBackColor = true;
            buttonGetSingleProxy.Click += ButtonGetSingleProxy_Click;
            // 
            // buttonGetSingleRandomProxy
            // 
            buttonGetSingleRandomProxy.Location = new Point(12, 132);
            buttonGetSingleRandomProxy.Name = "buttonGetSingleRandomProxy";
            buttonGetSingleRandomProxy.Size = new Size(148, 30);
            buttonGetSingleRandomProxy.TabIndex = 3;
            buttonGetSingleRandomProxy.Text = "GetSingleRandomProxy";
            buttonGetSingleRandomProxy.UseVisualStyleBackColor = true;
            buttonGetSingleRandomProxy.Click += ButtonGetSingleRandomProxy_Click;
            // 
            // buttonRenewQueue
            // 
            buttonRenewQueue.Location = new Point(12, 252);
            buttonRenewQueue.Name = "buttonRenewQueue";
            buttonRenewQueue.Size = new Size(148, 30);
            buttonRenewQueue.TabIndex = 4;
            buttonRenewQueue.Text = "RenewQueue";
            buttonRenewQueue.UseVisualStyleBackColor = true;
            buttonRenewQueue.Click += ButtonRenewQueue_Click;
            // 
            // buttonGetIndex
            // 
            buttonGetIndex.Location = new Point(12, 484);
            buttonGetIndex.Name = "buttonGetIndex";
            buttonGetIndex.Size = new Size(148, 30);
            buttonGetIndex.TabIndex = 5;
            buttonGetIndex.Text = "GetIndex";
            buttonGetIndex.UseVisualStyleBackColor = true;
            buttonGetIndex.Click += ButtonGetIndex_Click;
            // 
            // buttonPopProxy
            // 
            buttonPopProxy.Location = new Point(12, 312);
            buttonPopProxy.Name = "buttonPopProxy";
            buttonPopProxy.Size = new Size(148, 30);
            buttonPopProxy.TabIndex = 6;
            buttonPopProxy.Text = "PopProxy";
            buttonPopProxy.UseVisualStyleBackColor = true;
            buttonPopProxy.Click += ButtonPopProxy_Click;
            // 
            // buttonAddProxy
            // 
            buttonAddProxy.Location = new Point(12, 520);
            buttonAddProxy.Name = "buttonAddProxy";
            buttonAddProxy.Size = new Size(148, 30);
            buttonAddProxy.TabIndex = 7;
            buttonAddProxy.Text = "AddProxy";
            buttonAddProxy.UseVisualStyleBackColor = true;
            buttonAddProxy.Click += ButtonAddProxy_Click;
            // 
            // buttonRenewFilteredProxies
            // 
            buttonRenewFilteredProxies.Location = new Point(12, 448);
            buttonRenewFilteredProxies.Name = "buttonRenewFilteredProxies";
            buttonRenewFilteredProxies.Size = new Size(148, 30);
            buttonRenewFilteredProxies.TabIndex = 8;
            buttonRenewFilteredProxies.Text = "RenewFilteredProxies";
            buttonRenewFilteredProxies.UseVisualStyleBackColor = true;
            buttonRenewFilteredProxies.Click += ButtonRenewFilteredProxies_Click;
            // 
            // richTextBoxProxies
            // 
            richTextBoxProxies.Location = new Point(166, 28);
            richTextBoxProxies.Name = "richTextBoxProxies";
            richTextBoxProxies.ReadOnly = true;
            richTextBoxProxies.Size = new Size(278, 381);
            richTextBoxProxies.TabIndex = 9;
            richTextBoxProxies.Text = "";
            // 
            // buttonClearLog
            // 
            buttonClearLog.Location = new Point(12, 372);
            buttonClearLog.Name = "buttonClearLog";
            buttonClearLog.Size = new Size(148, 30);
            buttonClearLog.TabIndex = 10;
            buttonClearLog.Text = "Clear Log";
            buttonClearLog.UseVisualStyleBackColor = true;
            buttonClearLog.Click += ButtonClearLog_Click;
            // 
            // textBoxCountryCode
            // 
            textBoxCountryCode.Location = new Point(166, 454);
            textBoxCountryCode.Name = "textBoxCountryCode";
            textBoxCountryCode.PlaceholderText = "Country Code (e.g : US)";
            textBoxCountryCode.Size = new Size(139, 23);
            textBoxCountryCode.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 9);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 15;
            label3.Text = "Log :";
            // 
            // textBoxAddProxyIP
            // 
            textBoxAddProxyIP.Location = new Point(166, 525);
            textBoxAddProxyIP.Name = "textBoxAddProxyIP";
            textBoxAddProxyIP.PlaceholderText = "IP (e.g : 10.20.30.40)";
            textBoxAddProxyIP.Size = new Size(129, 23);
            textBoxAddProxyIP.TabIndex = 17;
            // 
            // textBoxGetIndex
            // 
            textBoxGetIndex.Location = new Point(166, 489);
            textBoxGetIndex.Name = "textBoxGetIndex";
            textBoxGetIndex.PlaceholderText = "Proxy in queue (e.g : 10.20.30.40:80)";
            textBoxGetIndex.Size = new Size(278, 23);
            textBoxGetIndex.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 412);
            label4.Name = "label4";
            label4.Size = new Size(432, 15);
            label4.TabIndex = 19;
            label4.Text = "_____________________________________________________________________________________";
            // 
            // checkBoxRenewFilteredProxies
            // 
            checkBoxRenewFilteredProxies.AutoSize = true;
            checkBoxRenewFilteredProxies.Location = new Point(315, 456);
            checkBoxRenewFilteredProxies.Name = "checkBoxRenewFilteredProxies";
            checkBoxRenewFilteredProxies.Size = new Size(139, 19);
            checkBoxRenewFilteredProxies.TabIndex = 20;
            checkBoxRenewFilteredProxies.Text = "Exclude the country ?";
            checkBoxRenewFilteredProxies.UseVisualStyleBackColor = true;
            // 
            // textBoxAddProxyPort
            // 
            textBoxAddProxyPort.Location = new Point(315, 525);
            textBoxAddProxyPort.Name = "textBoxAddProxyPort";
            textBoxAddProxyPort.PlaceholderText = "Port (e.g : 80)";
            textBoxAddProxyPort.Size = new Size(129, 23);
            textBoxAddProxyPort.TabIndex = 21;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(456, 562);
            Controls.Add(textBoxAddProxyPort);
            Controls.Add(checkBoxRenewFilteredProxies);
            Controls.Add(label4);
            Controls.Add(textBoxGetIndex);
            Controls.Add(textBoxAddProxyIP);
            Controls.Add(label3);
            Controls.Add(textBoxCountryCode);
            Controls.Add(buttonClearLog);
            Controls.Add(richTextBoxProxies);
            Controls.Add(buttonRenewFilteredProxies);
            Controls.Add(buttonAddProxy);
            Controls.Add(buttonPopProxy);
            Controls.Add(buttonGetIndex);
            Controls.Add(buttonRenewQueue);
            Controls.Add(buttonGetSingleRandomProxy);
            Controls.Add(buttonGetSingleProxy);
            Controls.Add(buttonGetUsedProxies);
            Controls.Add(buttonGetProxies);
            Cursor = Cursors.Cross;
            Name = "FormMain";
            Text = "ProxySharp Tester";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGetProxies;
        private Button buttonGetUsedProxies;
        private Button buttonGetSingleProxy;
        private Button buttonGetSingleRandomProxy;
        private Button buttonRenewQueue;
        private Button buttonGetIndex;
        private Button buttonPopProxy;
        private Button buttonAddProxy;
        private Button buttonRenewFilteredProxies;
        private RichTextBox richTextBoxProxies;
        private Button buttonClearLog;
        private TextBox textBoxCountryCode;
        private Label label3;
        private TextBox textBoxAddProxyIP;
        private TextBox textBoxGetIndex;
        private Label label4;
        private CheckBox checkBoxRenewFilteredProxies;
        private TextBox textBoxAddProxyPort;
    }
}

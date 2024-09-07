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
            buttonFilterCountry = new Button();
            richTextBoxProxies = new RichTextBox();
            buttonClearLog = new Button();
            textBoxCountry = new TextBox();
            label3 = new Label();
            textBoxAddProxyIP = new TextBox();
            textBoxGetIndex = new TextBox();
            label4 = new Label();
            checkBoxCountry = new CheckBox();
            textBoxAddProxyPort = new TextBox();
            checkBoxPort = new CheckBox();
            textBoxValuePort = new TextBox();
            buttonFilterPort = new Button();
            checkBoxHttps = new CheckBox();
            buttonFilterHttps = new Button();
            checkBoxAnonymity = new CheckBox();
            textBoxAnonyminty = new TextBox();
            buttonFilterAnonymity = new Button();
            checkBoxHttpsIsSupported = new CheckBox();
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
            buttonGetIndex.Location = new Point(520, 47);
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
            buttonAddProxy.Location = new Point(520, 93);
            buttonAddProxy.Name = "buttonAddProxy";
            buttonAddProxy.Size = new Size(148, 30);
            buttonAddProxy.TabIndex = 7;
            buttonAddProxy.Text = "AddProxy";
            buttonAddProxy.UseVisualStyleBackColor = true;
            buttonAddProxy.Click += ButtonAddProxy_Click;
            // 
            // buttonFilterCountry
            // 
            buttonFilterCountry.Location = new Point(520, 146);
            buttonFilterCountry.Name = "buttonFilterCountry";
            buttonFilterCountry.Size = new Size(148, 30);
            buttonFilterCountry.TabIndex = 8;
            buttonFilterCountry.Text = "FilterByCountry";
            buttonFilterCountry.UseVisualStyleBackColor = true;
            buttonFilterCountry.Click += buttonFilterCountry_Click;
            // 
            // richTextBoxProxies
            // 
            richTextBoxProxies.Location = new Point(178, 28);
            richTextBoxProxies.Name = "richTextBoxProxies";
            richTextBoxProxies.ReadOnly = true;
            richTextBoxProxies.Size = new Size(321, 381);
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
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(674, 150);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.PlaceholderText = "Value";
            textBoxCountry.Size = new Size(130, 23);
            textBoxCountry.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 9);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 15;
            label3.Text = "Log :";
            // 
            // textBoxAddProxyIP
            // 
            textBoxAddProxyIP.Location = new Point(674, 98);
            textBoxAddProxyIP.Name = "textBoxAddProxyIP";
            textBoxAddProxyIP.PlaceholderText = "IP (e.g : 10.20.30.40)";
            textBoxAddProxyIP.Size = new Size(130, 23);
            textBoxAddProxyIP.TabIndex = 17;
            // 
            // textBoxGetIndex
            // 
            textBoxGetIndex.Location = new Point(674, 52);
            textBoxGetIndex.Name = "textBoxGetIndex";
            textBoxGetIndex.PlaceholderText = "Proxy in queue (e.g : 10.20.30.40:80)";
            textBoxGetIndex.Size = new Size(234, 23);
            textBoxGetIndex.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 412);
            label4.Name = "label4";
            label4.Size = new Size(897, 15);
            label4.TabIndex = 19;
            label4.Text = "__________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // checkBoxCountry
            // 
            checkBoxCountry.AutoSize = true;
            checkBoxCountry.Location = new Point(810, 151);
            checkBoxCountry.Name = "checkBoxCountry";
            checkBoxCountry.Size = new Size(75, 19);
            checkBoxCountry.TabIndex = 20;
            checkBoxCountry.Text = "Exclude ?";
            checkBoxCountry.UseVisualStyleBackColor = true;
            // 
            // textBoxAddProxyPort
            // 
            textBoxAddProxyPort.Location = new Point(810, 98);
            textBoxAddProxyPort.Name = "textBoxAddProxyPort";
            textBoxAddProxyPort.PlaceholderText = "Port (e.g : 80)";
            textBoxAddProxyPort.Size = new Size(98, 23);
            textBoxAddProxyPort.TabIndex = 21;
            // 
            // checkBoxPort
            // 
            checkBoxPort.AutoSize = true;
            checkBoxPort.Location = new Point(810, 223);
            checkBoxPort.Name = "checkBoxPort";
            checkBoxPort.Size = new Size(75, 19);
            checkBoxPort.TabIndex = 24;
            checkBoxPort.Text = "Exclude ?";
            checkBoxPort.UseVisualStyleBackColor = true;
            // 
            // textBoxValuePort
            // 
            textBoxValuePort.Location = new Point(674, 219);
            textBoxValuePort.Name = "textBoxValuePort";
            textBoxValuePort.PlaceholderText = "Value";
            textBoxValuePort.Size = new Size(130, 23);
            textBoxValuePort.TabIndex = 23;
            // 
            // buttonFilterPort
            // 
            buttonFilterPort.Location = new Point(520, 214);
            buttonFilterPort.Name = "buttonFilterPort";
            buttonFilterPort.Size = new Size(148, 30);
            buttonFilterPort.TabIndex = 22;
            buttonFilterPort.Text = "FilterByPort";
            buttonFilterPort.UseVisualStyleBackColor = true;
            buttonFilterPort.Click += buttonFilterPort_Click;
            // 
            // checkBoxHttps
            // 
            checkBoxHttps.AutoSize = true;
            checkBoxHttps.Location = new Point(810, 371);
            checkBoxHttps.Name = "checkBoxHttps";
            checkBoxHttps.Size = new Size(75, 19);
            checkBoxHttps.TabIndex = 30;
            checkBoxHttps.Text = "Exclude ?";
            checkBoxHttps.UseVisualStyleBackColor = true;
            // 
            // buttonFilterHttps
            // 
            buttonFilterHttps.Location = new Point(520, 363);
            buttonFilterHttps.Name = "buttonFilterHttps";
            buttonFilterHttps.Size = new Size(148, 30);
            buttonFilterHttps.TabIndex = 28;
            buttonFilterHttps.Text = "FilerByHttps";
            buttonFilterHttps.UseVisualStyleBackColor = true;
            buttonFilterHttps.Click += buttonFilterHttps_Click;
            // 
            // checkBoxAnonymity
            // 
            checkBoxAnonymity.AutoSize = true;
            checkBoxAnonymity.Location = new Point(810, 294);
            checkBoxAnonymity.Name = "checkBoxAnonymity";
            checkBoxAnonymity.Size = new Size(75, 19);
            checkBoxAnonymity.TabIndex = 27;
            checkBoxAnonymity.Text = "Exclude ?";
            checkBoxAnonymity.UseVisualStyleBackColor = true;
            // 
            // textBoxAnonyminty
            // 
            textBoxAnonyminty.Location = new Point(674, 292);
            textBoxAnonyminty.Name = "textBoxAnonyminty";
            textBoxAnonyminty.PlaceholderText = "Value";
            textBoxAnonyminty.Size = new Size(130, 23);
            textBoxAnonyminty.TabIndex = 26;
            // 
            // buttonFilterAnonymity
            // 
            buttonFilterAnonymity.Location = new Point(520, 288);
            buttonFilterAnonymity.Name = "buttonFilterAnonymity";
            buttonFilterAnonymity.Size = new Size(148, 30);
            buttonFilterAnonymity.TabIndex = 25;
            buttonFilterAnonymity.Text = "FilterByAnonymity";
            buttonFilterAnonymity.UseVisualStyleBackColor = true;
            buttonFilterAnonymity.Click += buttonFilterAnonymity_Click;
            // 
            // checkBoxHttpsIsSupported
            // 
            checkBoxHttpsIsSupported.AutoSize = true;
            checkBoxHttpsIsSupported.Location = new Point(692, 370);
            checkBoxHttpsIsSupported.Name = "checkBoxHttpsIsSupported";
            checkBoxHttpsIsSupported.Size = new Size(99, 19);
            checkBoxHttpsIsSupported.TabIndex = 31;
            checkBoxHttpsIsSupported.Text = "Is supported ?";
            checkBoxHttpsIsSupported.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(920, 452);
            Controls.Add(checkBoxHttpsIsSupported);
            Controls.Add(checkBoxHttps);
            Controls.Add(buttonFilterHttps);
            Controls.Add(checkBoxAnonymity);
            Controls.Add(textBoxAnonyminty);
            Controls.Add(buttonFilterAnonymity);
            Controls.Add(checkBoxPort);
            Controls.Add(textBoxValuePort);
            Controls.Add(buttonFilterPort);
            Controls.Add(textBoxAddProxyPort);
            Controls.Add(checkBoxCountry);
            Controls.Add(label4);
            Controls.Add(textBoxGetIndex);
            Controls.Add(textBoxAddProxyIP);
            Controls.Add(label3);
            Controls.Add(textBoxCountry);
            Controls.Add(buttonClearLog);
            Controls.Add(richTextBoxProxies);
            Controls.Add(buttonFilterCountry);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button buttonFilterCountry;
        private RichTextBox richTextBoxProxies;
        private Button buttonClearLog;
        private TextBox textBoxCountry;
        private Label label3;
        private TextBox textBoxAddProxyIP;
        private TextBox textBoxGetIndex;
        private Label label4;
        private CheckBox checkBoxCountry;
        private TextBox textBoxAddProxyPort;
        private CheckBox checkBoxPort;
        private TextBox textBoxValuePort;
        private Button buttonFilterPort;
        private CheckBox checkBoxHttps;
        private Button buttonFilterHttps;
        private CheckBox checkBoxAnonymity;
        private TextBox textBoxAnonyminty;
        private Button buttonFilterAnonymity;
        private CheckBox checkBoxHttpsIsSupported;
    }
}

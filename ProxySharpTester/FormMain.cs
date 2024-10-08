using ProxySharp;

namespace ProxySharpTester
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonGetProxies_Click(object sender, EventArgs e)
        {
            foreach (var proxy in Proxy.GetProxies())
            {
                richTextBoxProxies.AppendText(proxy + Environment.NewLine);
            }
        }

        private void ButtonGetSingleProxy_Click(object sender, EventArgs e)
        {
            richTextBoxProxies.AppendText(Proxy.GetSingleProxy() + Environment.NewLine);
        }

        private void ButtonGetSingleRandomProxy_Click(object sender, EventArgs e)
        {
            richTextBoxProxies.AppendText(Proxy.GetSingleRandomProxy() + Environment.NewLine);
        }

        private void ButtonGetUsedProxies_Click(object sender, EventArgs e)
        {
            foreach (var proxy in Proxy.GetUsedProxies())
            {
                richTextBoxProxies.AppendText(proxy + Environment.NewLine);
            }
        }

        private void ButtonRenewQueue_Click(object sender, EventArgs e)
        {
            Proxy.RenewQueue();
        }

        private void ButtonGetIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The index of {textBoxGetIndex.Text} is : {Proxy.GetIndex(textBoxGetIndex.Text)}");
        }

        private void ButtonAddProxy_Click(object sender, EventArgs e)
        {
            Proxy.AddProxy(textBoxAddProxyIP.Text, textBoxAddProxyPort.Text);
            textBoxAddProxyIP.Clear();
            textBoxAddProxyPort.Clear();
        }

        private void ButtonPopProxy_Click(object sender, EventArgs e)
        {
            Proxy.PopProxy();
        }

        private void ButtonClearLog_Click(object sender, EventArgs e)
        {
            richTextBoxProxies.Clear();
        }

        private void buttonFilterCountry_Click(object sender, EventArgs e)
        {
            Proxy.FilterQueueByCountry(textBoxCountry.Text, checkBoxCountry.Checked);

        }

        private void buttonFilterPort_Click(object sender, EventArgs e)
        {
            Proxy.FilterQueueByPort(textBoxValuePort.Text, checkBoxPort.Checked);
        }

        private void buttonFilterAnonymity_Click(object sender, EventArgs e)
        {
            Proxy.FilterQueueByAnonymityLevel(Convert.ToInt32(textBoxAnonyminty.Text), checkBoxAnonymity.Checked);
        }

        private void buttonFilterHttps_Click(object sender, EventArgs e)
        {
            Proxy.FilterQueueByHttps(checkBoxHttpsIsSupported.Checked, checkBoxHttps.Checked);
            ButtonGetProxies_Click(sender, e);
        }
    }
}

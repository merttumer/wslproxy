namespace wslproxy
{
    public partial class Form1 : Form
    {

        private void ProcessCmdCommant(string filename, string parameters, bool requireElevation, out string output)
        {
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            pProcess.StartInfo.FileName = filename;

            pProcess.StartInfo.Arguments = parameters;

            pProcess.StartInfo.UseShellExecute = false;

            pProcess.StartInfo.RedirectStandardOutput = true;

            pProcess.StartInfo.CreateNoWindow = true;

            if (requireElevation)
            {
                pProcess.StartInfo.Verb = "runas";
            }

            pProcess.Start();

            string strOutput = pProcess.StandardOutput.ReadToEnd();

            pProcess.WaitForExit();

            output = strOutput.Trim();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void getWSLIPBtn_Click(object sender, EventArgs e)
        {
            ProcessCmdCommant("wsl.exe", "hostname -I", false, out var ip);
            if (ip == null) return;
            wslipText.Text = ip;
            forwardAddrText.Text = ip;
        }

        private string getProxyList()
        {
            string output;
            ProcessCmdCommant("netsh", "interface portproxy show v4tov4", true, out output);
            return output;
        }

        private void deleteList()
        {
            ProcessCmdCommant("netsh", "interface portproxy reset", true, out _);
        }


        private void addWslProxy(string listenaddr, string listenport, string forwardaddr, string forwardport)
        {
            ProcessCmdCommant("netsh", $"interface portproxy add v4tov4 listenaddress={listenaddr} listenport={listenport} connectaddress={forwardaddr} connectport={forwardport}", true, out _);
        }

        private void refreshProxyListBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = getProxyList();
        }

        private void removeProxyBtn_Click(object sender, EventArgs e)
        {
            deleteList();
            richTextBox1.Text = getProxyList();
        }

        private void addProxyBtn_Click(object sender, EventArgs e)
        {
            var listenaddr = listenAddrText.Text;
            var listenport = listenPortText.Text;
            var forwardaddr = forwardAddrText.Text;
            var forwardport = forwardPortText.Text;

            if (string.IsNullOrEmpty(listenaddr) || string.IsNullOrEmpty(forwardaddr)
                || string.IsNullOrEmpty(listenport) || string.IsNullOrEmpty(forwardport))
            {
                MessageBox.Show("Listen addr-port and forward addr-port cannot be empty");
                return;
            }

            addWslProxy(listenaddr, listenport, forwardaddr, forwardport);
            richTextBox1.Text = getProxyList();
        }
    }
}
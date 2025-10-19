using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace PayloadInjector
{
    public partial class Form1 : Form
    {
        enum PayloadType
        {
            PS4ElfLoader = 1,
            PS5ElfLoader = 2,
            BinFile = 3,
            ElfFile = 4
        }
        string BinFile = "";
        string ElfFile = "";
        string ps4elfldr = "";
        string ps5elfldr = "";
        Socket NetSocket = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ps4elfldr = System.IO.Path.Combine(Application.StartupPath, "ps4elfldr.bin");
            ps5elfldr = System.IO.Path.Combine(Application.StartupPath, "ps5elfldr.bin");
            // Check if elf loader bin files exists. Enable buttons accordingly.
            if (!System.IO.File.Exists(ps4elfldr))
                ps4elfldr = "";
            if (!System.IO.File.Exists(ps5elfldr))
                ps5elfldr = "";
            if (ps4elfldr.Length < 1)
                btnSendPs4ElfLdr.Enabled = false;
            if (ps5elfldr.Length < 1)
                btnSendPs5ElfLdr.Enabled = false;
            btnSendBin.Enabled = false;
            btnSendElf.Enabled = false;
            // Apply dark theme
            ApplyTheme_CarbonBlue();
            //ApplyTheme_CyberNeon();
            //ApplyTheme_SteelGray();
        }

        void ApplyTheme_CarbonBlue()
        {
            // Form
            this.BackColor = Color.FromArgb(25, 25, 30);

            // GroupBoxes
            foreach (var grp in new[] { groupBox1, groupBox2, groupBox3 })
            {
                grp.BackColor = Color.FromArgb(30, 30, 35);
                grp.ForeColor = Color.White;
            }

            // TextBoxes
            foreach (var tb in new[] { tbIPAddress, tbBinFile, tbElfFile, tbBinPort, tbElfPort })
            {
                tb.BackColor = Color.FromArgb(45, 45, 50);
                tb.ForeColor = Color.FromArgb(180, 220, 255);
                tb.BorderStyle = BorderStyle.FixedSingle;
            }

            // Buttons
            foreach (var btn in new[] { btnSendPs4ElfLdr, btnSendPs5ElfLdr, btnSendBin, btnSendElf })
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(70, 130, 180);
                btn.BackColor = Color.FromArgb(35, 45, 60);
                btn.ForeColor = Color.FromArgb(200, 220, 255);
            }

            // Labels
            foreach (var lbl in new[] { label1, label2, label3, label4, lbBinSize, lbElfSize })
            {
                lbl.ForeColor = Color.FromArgb(190, 200, 220);
            }
        }

        void ApplyTheme_CyberNeon()
        {
            // Form
            this.BackColor = Color.FromArgb(15, 15, 18);

            // GroupBoxes
            foreach (var grp in new[] { groupBox1, groupBox2, groupBox3 })
            {
                grp.BackColor = Color.FromArgb(20, 20, 25);
                grp.ForeColor = Color.LimeGreen;
            }

            // TextBoxes
            foreach (var tb in new[] { tbIPAddress, tbBinFile, tbElfFile, tbBinPort, tbElfPort })
            {
                tb.BackColor = Color.FromArgb(30, 30, 35);
                tb.ForeColor = Color.FromArgb(0, 255, 180);
                tb.BorderStyle = BorderStyle.FixedSingle;
            }

            // Buttons
            foreach (var btn in new[] { btnSendPs4ElfLdr, btnSendPs5ElfLdr, btnSendBin, btnSendElf })
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.FromArgb(25, 30, 35);
                btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 180);
                btn.ForeColor = Color.FromArgb(0, 255, 180);
            }

            // Labels
            foreach (var lbl in new[] { label1, label2, label3, label4, lbBinSize, lbElfSize })
            {
                lbl.ForeColor = Color.FromArgb(0, 220, 160);
            }
        }

        void ApplyTheme_SteelGray()
        {
            // Form
            this.BackColor = Color.FromArgb(35, 35, 38);

            // GroupBoxes
            foreach (var grp in new[] { groupBox1, groupBox2, groupBox3 })
            {
                grp.BackColor = Color.FromArgb(45, 45, 48);
                grp.ForeColor = Color.Gainsboro;
            }

            // TextBoxes
            foreach (var tb in new[] { tbIPAddress, tbBinFile, tbElfFile, tbBinPort, tbElfPort })
            {
                tb.BackColor = Color.FromArgb(55, 55, 60);
                tb.ForeColor = Color.WhiteSmoke;
                tb.BorderStyle = BorderStyle.FixedSingle;
            }

            // Buttons
            foreach (var btn in new[] { btnSendPs4ElfLdr, btnSendPs5ElfLdr, btnSendBin, btnSendElf })
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.FromArgb(50, 50, 55);
                btn.FlatAppearance.BorderColor = Color.FromArgb(255, 140, 0);
                btn.ForeColor = Color.FromArgb(255, 180, 80);
            }

            // Labels
            foreach (var lbl in new[] { label1, label2, label3, label4, lbBinSize, lbElfSize })
            {
                lbl.ForeColor = Color.FromArgb(210, 210, 210);
            }
        }

        private void tbBinPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if key is digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tbBinPort_TextChanged(object sender, EventArgs e)
        {
            // Enable buttons if valid info available
            if (tbBinPort.TextLength < 1)
            {
                btnSendBin.Enabled = false;
                btnSendPs4ElfLdr.Enabled = false;
                btnSendPs5ElfLdr.Enabled = false;
            }
            else
            {
                if ((tbIPAddress.TextLength > 0) && (BinFile.Length > 0))
                    btnSendBin.Enabled = true;
                if (tbIPAddress.TextLength > 0)
                {
                    if (ps4elfldr.Length > 0)
                        btnSendPs4ElfLdr.Enabled = true;
                    if (ps5elfldr.Length > 0)
                        btnSendPs5ElfLdr.Enabled = true;
                }
            }
        }

        private void tbElfPort_TextChanged(object sender, EventArgs e)
        {
            // Enable buttons if valid info available
            if (tbElfPort.TextLength < 1)
                btnSendElf.Enabled = false;
            else
            {
                if ((tbIPAddress.TextLength > 0) && (ElfFile.Length > 0))
                    btnSendElf.Enabled = true;
            }
        }

        private void tbIPAddress_TextChanged(object sender, EventArgs e)
        {
            // Enable buttons if valid info available
            if (tbIPAddress.TextLength < 1)
            {
                btnSendBin.Enabled = false;
                btnSendElf.Enabled = false;
                btnSendPs4ElfLdr.Enabled = false;
                btnSendPs5ElfLdr.Enabled = false;
            }
            else
            {
                if (ps4elfldr.Length > 0)
                    btnSendPs4ElfLdr.Enabled = true;
                if (ps5elfldr.Length > 0)
                    btnSendPs5ElfLdr.Enabled = true;
                if ((tbBinPort.TextLength > 0) && (BinFile.Length > 0))
                    btnSendBin.Enabled = true;
                if ((tbElfPort.TextLength > 0) && (ElfFile.Length > 0))
                    btnSendElf.Enabled = true;
            }
        }

        private void tbIPAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            int dot_count = 0;
            // Count dots
            for (int i = 0; i < tbIPAddress.TextLength; i++)
            {
                if (tbIPAddress.Text[i] == '.')
                    dot_count++;
            }
            // Max 3 dots allowed
            if ((dot_count > 2) && (e.KeyChar == '.'))
                e.Handled = true;
            // Two dots consecutively not allowed
            if (tbIPAddress.TextLength > 0)
            {
                if ((tbIPAddress.Text[tbIPAddress.TextLength - 1] == '.') && (e.KeyChar == '.'))
                    e.Handled = true;
            }
            // First char can not be dot
            if ((tbIPAddress.TextLength == 0) && (e.KeyChar == '.'))
                e.Handled = true;
            // Check if key is digit or dot
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                // Get the first file only
                string filePath = files[0];
                string extension = System.IO.Path.GetExtension(filePath).ToLower();

                // Allow only .bin or .elf files
                if (extension == ".bin")
                {
                    string fileName = System.IO.Path.GetFileName(filePath); // only file name + extension
                    // Read file size
                    FileInfo fi = new FileInfo(filePath);
                    long sizeBytes = fi.Length;
                    // Convert size to MB
                    double sizeMB = sizeBytes / (1024.0 * 1024.0);
                    lbBinSize.Text = string.Format("File size: {0:N2} MB", sizeMB);
                    tbBinFile.Text = fileName;
                    BinFile = filePath;
                    // Enable buttons if valid info available
                    if ((tbIPAddress.TextLength > 0) && (tbBinPort.TextLength > 0))
                        btnSendBin.Enabled = true;
                }
                if (extension == ".elf")
                {
                    string fileName = System.IO.Path.GetFileName(filePath); // only file name + extension
                    // Read file size
                    FileInfo fi = new FileInfo(filePath);
                    long sizeBytes = fi.Length;
                    // Convert size to MB
                    double sizeMB = sizeBytes / (1024.0 * 1024.0);
                    lbElfSize.Text = string.Format("File size: {0:N2} MB", sizeMB);
                    tbElfFile.Text = fileName;
                    ElfFile = filePath;
                    // Enable buttons if valid info available
                    if ((tbIPAddress.TextLength > 0) && (tbElfPort.TextLength > 0))
                        btnSendElf.Enabled = true;
                }
            }
        }

        private void btnSendPs4ElfLdr_Click(object sender, EventArgs e)
        {
            SendPayload(PayloadType.PS4ElfLoader);
        }

        private void btnSendPs5ElfLdr_Click(object sender, EventArgs e)
        {
            SendPayload(PayloadType.PS5ElfLoader);
        }

        private void btnSendBin_Click(object sender, EventArgs e)
        {
            SendPayload(PayloadType.BinFile);
        }

        private void btnSendElf_Click(object sender, EventArgs e)
        {
            SendPayload(PayloadType.ElfFile);
        }

        // Ping target
        public static bool PingHost(string ip)
        {
            var p = new Ping();
            var reply = p.Send(ip, 500);
            return (reply != null && reply.Status == IPStatus.Success);
        }

        // Check IP and Port if available
        public static bool IsTcpPortOpen(string ip, int port)
        {
            var tcp = new TcpClient();
            IAsyncResult ar = tcp.BeginConnect(ip, port, null, null);
            bool success = ar.AsyncWaitHandle.WaitOne(1000, false); // Wait max 1000ms
            if (!success)
                return false; // Timeout
            tcp.EndConnect(ar);
            return tcp.Connected;
        }

        private void SendPayload(PayloadType type)
        {
            string InfoMessage = "";
            switch (type)
            {
                case PayloadType.PS4ElfLoader:
                    InfoMessage = "Inject PS4 Elf Loader Payload to port " + tbBinPort.Text + "?";
                    break;
                case PayloadType.PS5ElfLoader:
                    InfoMessage = "Inject PS5 Elf Loader Payload to port " + tbBinPort.Text + "?";
                    break;
                case PayloadType.BinFile:
                    InfoMessage = "Inject .bin Payload to port " + tbBinPort.Text + "?";
                    break;
                case PayloadType.ElfFile:
                    InfoMessage = "Inject .elf Payload to port " + tbElfPort.Text + "?";
                    break;
            }
            // Validation of send
            if (MessageBox.Show(InfoMessage, "Inject Payload?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
                return;
            NetSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Limit buffer size to 8kB to improve reliability over unstable networks
            NetSocket.SendBufferSize = 8192;
            NetSocket.SendTimeout = 5000;
            NetSocket.ReceiveTimeout = 5000;
            try
            {
                switch (type)
                {
                    case PayloadType.PS4ElfLoader:
                        if (PingHost(tbIPAddress.Text) == false)
                        {
                            MessageBox.Show("Error: Connection failed. Can not ping.\n\nPlease check the IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //if (IsTcpPortOpen(tbIPAddress.Text, Convert.ToInt16(tbBinPort.Text)) == false)
                        //{
                        //    MessageBox.Show("Error: Connection failed. Please check the IP address and port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}
                        NetSocket.Connect(new IPEndPoint(IPAddress.Parse(tbIPAddress.Text), Convert.ToInt16(tbBinPort.Text)));
                        NetSocket.SendFile(ps4elfldr);
                        break;
                    case PayloadType.PS5ElfLoader:
                        if (PingHost(tbIPAddress.Text) == false)
                        {
                            MessageBox.Show("Error: Connection failed. Can not ping.\n\nPlease check the IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //if (IsTcpPortOpen(tbIPAddress.Text, Convert.ToInt16(tbBinPort.Text)) == false)
                        //{
                        //    MessageBox.Show("Error: Connection failed. Please check the IP address and port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}
                        NetSocket.Connect(new IPEndPoint(IPAddress.Parse(tbIPAddress.Text), Convert.ToInt16(tbBinPort.Text)));
                        NetSocket.SendFile(ps5elfldr);
                        break;
                    case PayloadType.BinFile:
                        if (PingHost(tbIPAddress.Text) == false)
                        {
                            MessageBox.Show("Error: Connection failed. Can not ping.\n\nPlease check the IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //if (IsTcpPortOpen(tbIPAddress.Text, Convert.ToInt16(tbBinPort.Text)) == false)
                        //{
                        //    MessageBox.Show("Error: Connection failed. Please check the IP address and port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}
                        NetSocket.Connect(new IPEndPoint(IPAddress.Parse(tbIPAddress.Text), Convert.ToInt16(tbBinPort.Text)));
                        NetSocket.SendFile(BinFile);
                        break;
                    case PayloadType.ElfFile:
                        if (PingHost(tbIPAddress.Text) == false)
                        {
                            MessageBox.Show("Error: Connection failed. Can not ping.\n\nPlease check the IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //if (IsTcpPortOpen(tbIPAddress.Text, Convert.ToInt16(tbElfPort.Text)) == false)
                        //{
                        //    MessageBox.Show("Error: Connection failed. Please check the IP address and port.\n\nCheck if Elf Loader Payload is active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}
                        NetSocket.Connect(new IPEndPoint(IPAddress.Parse(tbIPAddress.Text), Convert.ToInt16(tbElfPort.Text)));
                        NetSocket.SendFile(ElfFile);
                        break;
                }
                NetSocket.Shutdown(SocketShutdown.Both);
                MessageBox.Show("Payload injected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

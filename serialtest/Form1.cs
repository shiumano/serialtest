using System.IO.Ports;
using System.Text;

namespace serialtest
{
    public partial class Form1 : Form
    {
        public Serial.Serial serial;

        public string com = "";
        public int rate = 9600;
        public int bits = 8;
        public Parity parity = Parity.None;
        public StopBits stop = StopBits.One;
        public Handshake handshake = Handshake.None;
        public Encoding encoding = Encoding.UTF8;
        public int wtimeout = 100000;
        public int rtimeout = 100000;
        public string newline = "\r\n";

        public Task? connection;

        public Form1()
        {
            InitializeComponent();
            serial = new Serial.Serial();
            foreach (var com in serial.GetPort())
            {
                comSelect.Items.Add(com);
            }
        }
        private async Task addMessagesForever()
        {
            while (true)
            {
                var msg = await serial.ReceiveAsync();
                if (msg == null) return;
                messageLog.Items.Add($"!> {msg}");
            }
        }

        public async void connectButton_Click(object sender, EventArgs e)
        {
            if (connectButton.Text == "Ú‘±")
            {
                com = comSelect.Text;
                serial.PortOpen(
                    com,
                    rate,
                    bits,
                    parity,
                    stop,
                    handshake,
                    encoding,
                    wtimeout,
                    rtimeout,
                    newline
                );
                connection = addMessagesForever();
                connectButton.Text = "Ø’f";
                messageLog.Items.Add("--- Ú‘±‚µ‚Ü‚µ‚½B");
            }
            else if (connectButton.Text == "Ø’f")
            {
                serial.PortClose();
                if (connection != null) await connection;
                connectButton.Text = "Ú‘±";
                messageLog.Items.Add("--- Ø’f‚µ‚Ü‚µ‚½B");
            }
        }

        private void sendButton_ClickAsync(object? sender, EventArgs e)
        {
            var text = messageInput.Text;
            messageInput.Text = "";
            serial.Send(text);
            messageLog.Items.Add($"-> {text}");

        }
        private void messageInput_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) sendButton_ClickAsync(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2
            (
                rate,
                bits,
                parity,
                stop,
                handshake,
                encoding,
                wtimeout,
                rtimeout,
                newline,
                this
            );

            form2.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messageLog.Items.Clear();
        }
    }
}
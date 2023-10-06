using System.IO.Ports;
using System.Text;

namespace serialtest
{
    public partial class Form2 : Form
    {
        private Form1? form1;

        private Dictionary<string, Parity> parityDict = new()
        {
            {"Even", Parity.Even},
            {"Mark", Parity.Mark},
            {"None", Parity.None},
            {"Odd", Parity.Odd}
        };
        private Dictionary<string, StopBits> stopDict = new()
        {
            {"None" ,StopBits.None},
            {"One", StopBits.One},
            {"Two", StopBits.Two},
            {"OnePointFive", StopBits.OnePointFive}
        };
        private Dictionary<string, Handshake> handshakeDict = new()
        {
            {"None", Handshake.None},
            {"XOnXOff", Handshake.XOnXOff},
            {"RequestToSend", Handshake.RequestToSend},
            {"RequestToSendXOnXOff", Handshake.RequestToSendXOnXOff}
        };
        private Dictionary<string, Encoding> encodingDict = new()
        {
            {"ASCII", Encoding.ASCII},
            {"UTF8", Encoding.UTF8},
            {"UTF32", Encoding.UTF32}
        };
        private Dictionary<string, string> newlineDict = new()
        {
            {"CRLF", "\r\n"},
            {"LF", "\n"}
        };
        public Form2
        (
            int rate,
            int bits,
            Parity parity,
            StopBits stop,
            Handshake handshake,
            Encoding encoding,
            int wtimeout,
            int rtimeout,
            string newline,
            Form1 form1
        )
        {
            InitializeComponent();

            foreach (var key in parityDict.Keys)
                paritySelect.Items.Add(key);
            foreach (var key in stopDict.Keys)
                stopSelect.Items.Add(key);
            foreach (var key in handshakeDict.Keys)
                handshakeSelect.Items.Add(key);
            foreach (var key in encodingDict.Keys)
                encodingSelect.Items.Add(key);
            foreach (var key in newlineDict.Keys)
                newlineSelect.Items.Add(key);

            rateInput.Text = rate.ToString();
            bitsInput.Text = bits.ToString();
            paritySelect.Text = parity.ToString();
            stopSelect.Text = stop.ToString();
            handshakeSelect.Text = handshake.ToString();
            switch (encoding)
            {
                case ASCIIEncoding:
                    encodingSelect.Text = "ASCII";
                    break;
                case UTF8Encoding:
                    encodingSelect.Text = "UTF8";
                    break;
                case UTF32Encoding:
                    encodingSelect.Text = "UTF32";
                    break;
            }
            wtimeoutInput.Text = wtimeout.ToString();
            rtimeoutInput.Text = rtimeout.ToString();
            switch (newline)
            {
                case "\r\n":
                    newlineSelect.Text = "CRLF";
                    break;
                case "\n":
                    newlineSelect.Text = "LF";
                    break;
            }
            this.form1 = form1;
        }

        private async void OKButton_Click(object sender, EventArgs e)
        {
            if (form1 != null)
            {
                form1.rate = int.Parse(rateInput.Text);
                form1.bits = int.Parse(bitsInput.Text);
                form1.parity = parityDict[paritySelect.Text];
                form1.stop = stopDict[stopSelect.Text];
                form1.handshake = handshakeDict[handshakeSelect.Text];
                form1.encoding = encodingDict[encodingSelect.Text];
                form1.wtimeout = int.Parse(wtimeoutInput.Text);
                form1.rtimeout = int.Parse(rtimeoutInput.Text);
                form1.newline = newlineDict[newlineSelect.Text];
            }
            if ((form1?.serial?.sport?.IsOpen) ?? false)
            {
                var result = MessageBox.Show(
                    "現在接続中です。設定を変更して再接続しますか？",
                    "確認",
                    MessageBoxButtons.YesNo
                    );
                if (result == DialogResult.Yes)
                {
                    form1.serial.PortClose();
                    if (form1.connection != null) await form1.connection;
                    MessageBox.Show(
                        form1.com.ToString()+"\n"+
                        form1.rate.ToString()+ "\n" +
                        form1.bits.ToString()+ "\n" +
                        form1.parity.ToString()+ "\n" +
                        form1.stop.ToString()+ "\n" +
                        form1.handshake.ToString()+ "\n" +
                        form1.encoding.ToString()+ "\n" +
                        form1.wtimeout.ToString()+ "\n" +
                        form1.rtimeout.ToString()+ "\n" +
                        (form1.newline == "\r\n").ToString());
                    form1.serial.PortOpen(
                        form1.com,
                        form1.rate,
                        form1.bits,
                        form1.parity,
                        form1.stop,
                        form1.handshake,
                        form1.encoding,
                        form1.wtimeout,
                        form1.rtimeout,
                        form1.newline);
                    form1.messageLog.Items.Add("--- 再接続しました。");
                }

            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

namespace Serial
{

    using System.Diagnostics;
    using System;
    using System.IO.Ports;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Buffers.Text;

    public class Serial
    {
        public SerialPort? sport = null;
        public bool PortOpen(
            string com,
            int rate = 9600,
            int bits = 8,
            Parity parity = Parity.None,
            StopBits stop = StopBits.One,
            Handshake handshake = Handshake.None,
            Encoding? encoding = null,
            int wtimeout = 100000,
            int rtimeout = 100000,
            string newline = "\r\n"
        )
        {
            if (encoding == null) encoding = Encoding.UTF8; 
            // シリアルポートの設定
            sport = new SerialPort
            {
                PortName = com,                    //ポート番号
                BaudRate = rate,                   //ボーレート
                DataBits = bits,                      //データビット
                Parity = parity,                      //パリティ
                StopBits = stop,           //ストップビット
                Handshake = handshake,  //ハンドシェイク
                Encoding = Encoding.UTF8,          //エンコード
                WriteTimeout = wtimeout,             //書き込みタイムアウト
                ReadTimeout = rtimeout,              //読み取りタイムアウト
                NewLine = newline                   //改行コード指定
            };

            // シリアルポートに接続
            if (!sport.IsOpen)
            {
                try
                {
                    sport.Open();  // ポートオープン
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return false;
                }
            }
            return true;
        }
        public void PortClose()
        {
            sport?.Close();  // ポートクローズ
            sport = null;
        }
        public async Task<string?> ReceiveAsync()
        {
            if (!(sport?.IsOpen) ?? false) return null;  //ポートが閉じている場合は戻す

            var data = await Task.Run(() => ReadData());
            return data;
        }

        public void Send(string data)
        {
            if (!(sport?.IsOpen) ?? true) return;  //ポートが閉じている場合は戻す

            try
            {
                sport?.WriteLine(data);  //データ書き込み
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private string? ReadData()
        {
            var data = "";
            try
            {
                data = sport?.ReadLine();  //データ読み取り
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                data = "";
            }
            return data ?? null;
        }

        public async Task ReceiveAsyncForever()
        {
            while (true) {
                var msg = await ReceiveAsync();
                if (msg == null) return;
                Console.WriteLine("!> "+msg);
                Console.Write("&> ");
            }
        }
        public string[] GetPort()
        {
            return SerialPort.GetPortNames();  //ポート番号のリストを返す
        }
    }
}
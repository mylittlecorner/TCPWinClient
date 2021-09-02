using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace Client
{
    class TCPClient
    {
        private Byte[] _dataRead;
        private readonly Int32 _port;
        private readonly String _host;
        private readonly NetworkStream _stream;
        private readonly TcpClient _client;
        public TCPClient(String host, Int32 port)
        {
            _host = host;
            _port = port;
            _dataRead = new Byte[256];
            _client = new TcpClient(_host, _port);
            _stream = _client.GetStream();
        }
        public Byte[] MessageToBytes(String message)
        {
            return Encoding.ASCII.GetBytes(message);
        }

        public void Write(String message)
        {
            Byte[] data = MessageToBytes(message);
            _stream.Write(data, 0, data.Length);
        }

        public String Read()
        {
            Int32 bytes = _stream.Read(_dataRead, 0, _dataRead.Length);
            return Encoding.ASCII.GetString(_dataRead, 0, bytes);
        }

        public void Close()
        {
            _stream.Close();
            _client.Close();
        }

    }
}

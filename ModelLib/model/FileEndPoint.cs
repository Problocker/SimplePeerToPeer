using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.model
{
    public class FileEndPoint
    {
        private string _ipAddress;
        private int _port;

        public FileEndPoint()
        {
        }

        public FileEndPoint(string ipAddress, int port)
        {
            _ipAddress = ipAddress;
            _port = port;
        }

        public string IpAddress
        {
            get => _ipAddress;
            set => _ipAddress = value;
        }

        public int Port
        {
            get => _port;
            set => _port = value;
        }
    }
}

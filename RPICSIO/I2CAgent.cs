using System;
using System.Linq;

namespace RPICSIO
{
    public class I2CAgent
    {
        private I2CPortFS _port;
        private int _address;

        public I2CAgent(I2CPortFS port, int address)
        {
            _port = port;
            _address = address;

            if (_port.PortIsOpen == false)
            {
                throw new Exception("ssHandle == null");
            }
        }

        public byte[] Read(int bytes)
        {
            var buffer = new byte[bytes];
            _port.Read(_address, buffer, bytes);
            return buffer;
        }

        public byte ReadByte()
        {
            return Read(1).First();
        }

        public void Write(byte[] buffer)
        {
            _port.Write(_address, buffer, buffer.Length);
        }

        public void WriteByte(byte value)
        {
            Write(new[] { value });
        }
    }
}

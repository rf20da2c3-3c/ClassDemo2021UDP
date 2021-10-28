using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClassDemo2021UDPReceiver
{
    internal class UdpWorker
    {
        public UdpWorker()
        {
        }

        public void Start()
        {
            UdpClient client = new UdpClient(7);
            byte[] data;

            while (true)
            {
                IPEndPoint remoteEP = null;

                // modtager
                data = client.Receive(ref remoteEP);
                Console.WriteLine($" modtaget ip = {remoteEP.Address} og port {remoteEP.Port}");

                string str = Encoding.UTF8.GetString(data);

                Console.WriteLine("modtaget tekst = " + str);

                // echo
                byte[] bufferTilbage = Encoding.UTF8.GetBytes("Hej " + str);
                client.Send(bufferTilbage, bufferTilbage.Length, remoteEP);


            }


        }
    }
}
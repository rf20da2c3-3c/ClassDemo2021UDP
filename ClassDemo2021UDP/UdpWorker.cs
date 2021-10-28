using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClassDemo2021UDPSender
{
    internal class UdpWorker
    {
        public UdpWorker()
        {
        }

        public void Start()
        {
            UdpClient client = new UdpClient();

            String intxt = Console.ReadLine();
            Console.WriteLine("Sender " + intxt);

            byte[] udBuffer = Encoding.UTF8.GetBytes(intxt);
            client.Send(udBuffer, udBuffer.Length, new IPEndPoint(IPAddress.Broadcast, 7));


            // modtage
            IPEndPoint kommerFraEP = null;
            byte[] indBuffer = client.Receive(ref kommerFraEP);
            String str = Encoding.UTF8.GetString(indBuffer);
            Console.WriteLine("Modtaget " + str);




        }
    }
}
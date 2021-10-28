using System;

namespace ClassDemo2021UDPReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpWorker worker = new UdpWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}

using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        //string name = (args.Length < 1) ? Dns.GetHostName() : args[0];
        //try
        //{
        //    IPAddress[] addrs = Dns.Resolve(name).AddressList;
        //    foreach (IPAddress addr in addrs)
        //    {
        //        Console.WriteLine($"{name}/{addr}");
        //    }
        //}
        //catch(Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        //Console.ReadLine();

        try
        {
            TcpClient tcpcInt = new TcpClient();
            Console.WriteLine("Connecting.....");

            tcpcInt.Connect("192.168.56.1", 8001);

            Console.WriteLine("Connected");
            Console.WriteLine("Enter the string to be transmitted: ");

            String str = Console.ReadLine();
            Stream stm = tcpcInt.GetStream();

            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(str);
            Console.WriteLine("Transmitting......");

            stm.Write(ba, 0, ba.Length);
            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);

            for (int i = 0; i < k; i++)
            {
                Console.Write(Convert.ToChar(bb[i]));
            }

            tcpcInt.Close();
        }
    }
}
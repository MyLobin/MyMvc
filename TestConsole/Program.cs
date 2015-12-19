using MyEF.Host;
using MyEF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Messaging;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expression<Func<int, int, int>> expression = (a,b) => a + b;

            //BinaryExpression body = (BinaryExpression)expression.Body;
            //ParameterExpression left = (ParameterExpression)body.Left;
            //ParameterExpression right = (ParameterExpression)body.Right;

            //var fun=expression.Compile();



            //int c = fun(2, 3);
            //Console.WriteLine(TimeSpan.MinValue);
            //var key = Console.ReadKey().Key;
            //if (key == ConsoleKey.A)
            //{
            //    Console.WriteLine("A");
            //    while (true)
            //    {
            //        Thread.Sleep(1000);
            //        var msg = Consumer.Receive();
            //            if(string.IsNullOrEmpty(msg))
            //                msg="^_^";
            //        Console.WriteLine(msg);
            //    }
               
            //}
            //Console.WriteLine("发送！");
            //while (true)
            //{
            //    var msg = Console.ReadLine();
            //    Producer.Send(msg);
            //}

            MSMQ.Createqueue(@"FormatName:DIRECT=tcp:192.168.1.103\private$\Email");
            Console.WriteLine(MSMQ.Msg);
            Thread.Sleep(2000);
            MSMQ.SendMessage("just send");
            Console.WriteLine("send!");
            Thread.Sleep(2000);
            var msg=MSMQ.ReceiveMessage();
            Console.WriteLine(msg);
            

            Console.ReadKey();




       
        }
    }
}

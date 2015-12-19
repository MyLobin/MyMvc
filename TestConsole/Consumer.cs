using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
   public  class Consumer
    {
       public static  string Msg = "";
       public static string Receive() 
       {
           IConnectionFactory factory = new ConnectionFactory("tcp://192.168.1.103:61616");
           using (IConnection connection=factory.CreateConnection())
           {
               connection.ClientId = "test listener";
               connection.Start();
               using (ISession session=connection.CreateSession())
               {
                   IMessageConsumer consumer = session.CreateConsumer(new ActiveMQQueue("test"));
                   consumer.Listener += consumer_Listener;

               }
           }
           return Msg;
       }

       static void consumer_Listener(IMessage message)
       {
           ITextMessage msg = (ITextMessage)message;
           Msg = msg.Text;
       }
    }
}

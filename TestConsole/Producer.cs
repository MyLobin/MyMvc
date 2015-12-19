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
   public class Producer
    {
       public static void Send(string msg)
       {
           IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
           using (IConnection connection=factory.CreateConnection())
           {
               using (ISession session=connection.CreateSession())
               {
                   IMessageProducer producer = session.CreateProducer(new ActiveMQQueue("test"));
                   ITextMessage message = producer.CreateTextMessage(msg);
                  // message.Properties.SetString("filter", "demo");
                   producer.Send(message, MsgDeliveryMode.NonPersistent, MsgPriority.Normal, TimeSpan.MinValue);
               }
           }
       }
    }
}

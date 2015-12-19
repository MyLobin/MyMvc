using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class MSMQ
    {
        public static string Msg { get; set; }
        /**/
        /// <summary> 
        /// 通过Create方法创建使用指定路径的新消息队列 
        /// </summary> 
        /// <param name="queuePath"></param> 
        public static void Createqueue(string queuePath)
        {
            try
            {
                var queue = new MessageQueue(queuePath);
                //if (!MessageQueue.Exists(queuePath))
                //{
                //    MessageQueue.Create(@".\private$\myQueue");
                //    Msg = "创建队列成功！";
                //}
                //else
                //{
                //    Msg = queuePath + "已经存在！";
                //}
            }
            catch (MessageQueueException e)
            {
                Msg = e.Message;
            }
        }

        /**/
        /// <summary> 
        /// 连接消息队列并发送消息到队列 
        /// </summary> 
        public static bool SendMessage(string book)
        {
            bool flag = false;
            try
            {
                //连接到本地的队列 
                MessageQueue myQueue = new MessageQueue(".\\private$\\myQueue");

                System.Messaging.Message myMessage = new System.Messaging.Message();
                myMessage.Body = book;
                myMessage.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                //发送消息到队列中 
                myQueue.Send(myMessage);
                flag = true;
            }
            catch (ArgumentException e)
            {
                Msg = e.Message;
            }
            return flag;
        }

        /**/
        /// <summary> 
        /// 连接消息队列并从队列中接收消息 
        /// </summary> 
        public static string ReceiveMessage()
        {
            //连接到本地队列 
            MessageQueue myQueue = new MessageQueue(".\\private$\\myQueue");
            myQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            try
            {
                //从队列中接收消息 
                System.Messaging.Message myMessage = myQueue.Receive();
                string book = (string)myMessage.Body; //获取消息的内容 
                return book;
            }
            catch (MessageQueueException e)
            {
                Msg = e.Message;
            }
            catch (InvalidCastException e)
            {
                Msg = e.Message;
            }
            return null;
        }

    }
}

using System;

namespace PubSubApp
{
    partial class Program
    {
        public class MessageService
        {
            public void OnVedioEncoded(object source, VedioEventArgs e)
            {
                Console.WriteLine("MessageService: Sending a text message..." + e.Vedio.Title);
                Console.ReadLine();
            }
        }
    }
}

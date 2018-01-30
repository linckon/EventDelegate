using System;

namespace PubSubApp
{
    partial class Program
    {
        public class MailService
        {
            public void OnVedioEncoded(object source, VedioEventArgs e)
            {
                Console.WriteLine("MailService: Sending an email..." + e.Vedio.Title);
            }
        }
    }
}

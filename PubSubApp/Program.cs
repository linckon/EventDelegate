namespace PubSubApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var vedio = new Vedio{Title = "Vedio 1"};
            //publisher
            var vedioEncoder = new VedioEncoder();
            //subscriber
            var mailService = new MailService();
            var messageService = new MessageService();

            vedioEncoder.VedioEncoded += mailService.OnVedioEncoded;
            vedioEncoder.VedioEncoded += messageService.OnVedioEncoded;

            vedioEncoder.Encode(vedio);
        }


    }
}

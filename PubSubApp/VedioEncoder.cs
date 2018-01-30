using System;
using System.Threading;

namespace PubSubApp
{

    public class VedioEventArgs:EventArgs
    {
        public Vedio Vedio { get; set; }
    }
    public class VedioEncoder
    {

        // 1.Define a Delegate
        //2.Define an event based on that delegate
        //3.Raise the event

        //public delegate void VedioEncodeEventHandler(object source, VedioEventArgs args);

        //EventHandler
        //Eventandler<TEventArgs>

        public event EventHandler<VedioEventArgs> VedioEncoded;

        public void Encode(Vedio vedio)
        {
            Console.WriteLine("Encodeing vedio");
            Thread.Sleep(3000);

            OnVedioEncoded(vedio);
        }

        protected virtual void OnVedioEncoded(Vedio vedio)
        {
            VedioEncoded?.Invoke(this, new VedioEventArgs { Vedio = vedio });
        }
    }
}
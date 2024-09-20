using System;
using System.Collections.Generic;
using WampSharp.Core.Serialization;
using WampSharp.V2.Client;
using WampSharp.V2.PubSub;
using WampSharp.V2.Core.Contracts;


namespace Wamp.Client
{
    public partial class WampClient
    {
        /***********************************************************************************************************************/
        /********************                       Trace Audio Data Receiving                               *******************/
        /***********************************************************************************************************************/

        TracerAudioDataReceiving tracerAudioDataReceiving = null;
 
        IAsyncDisposable tracerAudioDataReceivingsDisposable = null;

        ///<summary>Event Handler for Audio Data Receiving Event</summary>
        public event EventHandler<wamp_audio_data_receiving> OnAudioDataReceiving;

        ///<summary> </summary>
        /***********************************************************************************************************************/
        public async void TraceAudioDataReceiving()
        /***********************************************************************************************************************/       
        {
            IWampTopicProxy topicProxy = _wampRealmProxy.TopicContainer.GetTopicByUri(TraceWampAudioDataReceiving);

            tracerAudioDataReceiving = new TracerAudioDataReceiving();
            tracerAudioDataReceiving.OnAudioDataReceiving += TracerAudioDataReceiving_OnAudioDetectionEvent;
            tracerAudioDataReceiving.OnDebugString += TracerAudioDataReceiving_OnDebugString;

            tracerAudioDataReceivingsDisposable = await topicProxy.Subscribe(tracerAudioDataReceiving, new SubscribeOptions()).ConfigureAwait(false);
        }


        /***********************************************************************************************************************/
        private void TracerAudioDataReceiving_OnDebugString(object sender, string e)
        /***********************************************************************************************************************/
        {
            OnChildLogString?.Invoke(this, "Audio Data Receiving Subscription: " + e);
        }


        /***********************************************************************************************************************/
        private void TracerAudioDataReceiving_OnAudioDetectionEvent(object sender, wamp_audio_data_receiving audioEvent)
        /***********************************************************************************************************************/       
        {
            OnAudioDataReceiving?.Invoke(this, audioEvent);
        }

        ///<summary>Handle Audio Data Receiving Dispose</summary>
         /***********************************************************************************************************************/
        public void TraceAudioDataReceivingDispose()
        /***********************************************************************************************************************/
        {
            if (tracerAudioDataReceivingsDisposable != null)
            {
                tracerAudioDataReceivingsDisposable.DisposeAsync();
                tracerAudioDataReceivingsDisposable = null;
                tracerAudioDataReceiving = null;
            }
        }

        ///<summary>Return the Audio Data Receiving Enabled Status</summary>
        /***********************************************************************************************************************/
        public bool TraceAudioDataReceivingIsEnabled()
        /***********************************************************************************************************************/
        {
            if (tracerAudioDataReceiving == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /***********************************************************************************************************************/
        internal class TracerAudioDataReceiving : IWampRawTopicClientSubscriber
        /***********************************************************************************************************************/
        {

            public event EventHandler<wamp_audio_data_receiving> OnAudioDataReceiving;
            public event EventHandler<string> OnDebugString;

            /***********************************************************************************************************************/
            public void Event<TMessage>(IWampFormatter<TMessage> formatter, long publicationId, EventDetails details)
            /***********************************************************************************************************************/
            {
                string txt = "Got event with publication id: " + publicationId.ToString();
                OnDebugString?.Invoke(this, txt);
            }


            /***********************************************************************************************************************/
            public void Event<TMessage>(IWampFormatter<TMessage> formatter, long publicationId, EventDetails details, TMessage[] arguments)
            /***********************************************************************************************************************/
            {
                string json_str = arguments[0].ToString();
                OnDebugString?.Invoke(this, json_str);

                wamp_audio_data_receiving audioEvent = Newtonsoft.Json.JsonConvert.DeserializeObject<wamp_audio_data_receiving>(arguments[0].ToString());
                OnAudioDataReceiving?.Invoke(this, audioEvent);
            }


            /***********************************************************************************************************************/
            public void Event<TMessage>(IWampFormatter<TMessage> formatter, long publicationId, EventDetails details, TMessage[] arguments,
                                        IDictionary<string, TMessage> argumentsKeywords)
            /***********************************************************************************************************************/
            {
                string txt = "Event<TMessage>(IWampFormatter<TMessage> formatter, long publicationId, EventDetails details, TMessage[] arguments, IDictionary<string, TMessage> argumentsKeywords) IS NOT SUPPORTED";
                OnDebugString?.Invoke(this, txt);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using WampSharp.Core.Serialization;
using WampSharp.V2.Client;
using WampSharp.V2.PubSub;
using WampSharp.V2.Core.Contracts;
using static Wamp.Client.WampClient;


namespace Wamp.Client
{
    public partial class WampClient
    {
        /***********************************************************************************************************************/
        /********************                       Trace Audio Detector Alive                               *******************/
        /***********************************************************************************************************************/

        TracerAudioDetectorAlive tracerAudioDetectorAlive = null;
 
        IAsyncDisposable tracerAudioDetectorAlivesDisposable = null;

        ///<summary>Event Handler for Audio Event Detector Alive Event</summary>
        public event EventHandler<wamp_audio_detector_alive> OnAudioDetectorAlive;

        ///<summary> </summary>
        /***********************************************************************************************************************/
        public async void TraceAudioDetectorAlive()
        /***********************************************************************************************************************/       
        {
            IWampTopicProxy topicProxy = _wampRealmProxy.TopicContainer.GetTopicByUri(TraceWampAudioDetectorAlive);

            tracerAudioDetectorAlive = new TracerAudioDetectorAlive();
            tracerAudioDetectorAlive.OnAudioDetectorAlive += TracerAudioDetectorAlive_OnAudioDetectionEvent;
            tracerAudioDetectorAlive.OnDebugString += TracerAudioDetectorAlive_OnDebugString;

            tracerAudioDetectorAlivesDisposable = await topicProxy.Subscribe(tracerAudioDetectorAlive, new SubscribeOptions()).ConfigureAwait(false);
        }


        /***********************************************************************************************************************/
        private void TracerAudioDetectorAlive_OnDebugString(object sender, string e)
        /***********************************************************************************************************************/
        {
            OnChildLogString?.Invoke(this, "Audio Detector Alive Subscription: " + e);
        }


        /***********************************************************************************************************************/
        private void TracerAudioDetectorAlive_OnAudioDetectionEvent(object sender, wamp_audio_detector_alive audioEvent)
        /***********************************************************************************************************************/       
        {
            OnAudioDetectorAlive?.Invoke(this, audioEvent);
        }


        ///<summary>Handle Audio Detector Alive Event Dispose</summary>
        /***********************************************************************************************************************/
        public void TraceAudioDetectorAliveDispose()
        /***********************************************************************************************************************/
        {
            if (tracerAudioDetectorAlivesDisposable != null)
            {
                tracerAudioDetectorAlivesDisposable.DisposeAsync();
                tracerAudioDetectorAlivesDisposable = null;
                tracerAudioDetectorAlive = null;
            }
        }

        ///<summary>Return the Audio Detector Alive Event Enabled Status</summary>
        /***********************************************************************************************************************/
        public bool TraceAudioDetectorAliveIsEnabled()
        /***********************************************************************************************************************/
        {
            if (tracerAudioDetectorAlive == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /***********************************************************************************************************************/
        internal class TracerAudioDetectorAlive : IWampRawTopicClientSubscriber
        /***********************************************************************************************************************/
        {

            public event EventHandler<wamp_audio_detector_alive> OnAudioDetectorAlive;
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

                wamp_audio_detector_alive audioEvent = Newtonsoft.Json.JsonConvert.DeserializeObject<wamp_audio_detector_alive>(arguments[0].ToString());
                OnAudioDetectorAlive?.Invoke(this, audioEvent);
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

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
        /********************                       Trace Audio Event Detection                              *******************/
        /***********************************************************************************************************************/

        TracerAudioEventDetection tracerAudioEventDetection = null;
 
        IAsyncDisposable tracerAudioEventDetectionsDisposable = null;

        ///<summary>Event Handler for Audio Event Detection</summary>
        public event EventHandler<wamp_audio_event_detection> OnAudioEventDetection;

        ///<summary></summary>
        /***********************************************************************************************************************/
        public async void TraceAudioEventDetection()
        /***********************************************************************************************************************/       
        {
            IWampTopicProxy topicProxy = _wampRealmProxy.TopicContainer.GetTopicByUri(TraceWampAudioEvents);

            tracerAudioEventDetection = new TracerAudioEventDetection();
            tracerAudioEventDetection.OnAudioEventDetection += TracerAudioEventDetection_OnAudioDetectionEvent;
            tracerAudioEventDetection.OnDebugString += TracerAudioEventDetection_OnDebugString;

            tracerAudioEventDetectionsDisposable = await topicProxy.Subscribe(tracerAudioEventDetection, new SubscribeOptions()).ConfigureAwait(false);
        }


        /***********************************************************************************************************************/
        private void TracerAudioEventDetection_OnDebugString(object sender, string e)
        /***********************************************************************************************************************/
        {
            OnChildLogString?.Invoke(this, "Audio Event Detection Subscription: " + e);
        }


        /***********************************************************************************************************************/
        private void TracerAudioEventDetection_OnAudioDetectionEvent(object sender, wamp_audio_event_detection audioEvent)
        /***********************************************************************************************************************/       
        {
            OnAudioEventDetection?.Invoke(this, audioEvent);
        }


        ///<summary>Handle the Audio Event Detection Dispose</summary>
        /***********************************************************************************************************************/
        public void TraceAudioEventDetectionDispose()
        /***********************************************************************************************************************/
        {
            if (tracerAudioEventDetectionsDisposable != null)
            {
                tracerAudioEventDetectionsDisposable.DisposeAsync();
                tracerAudioEventDetectionsDisposable = null;
                tracerAudioEventDetection = null;
            }
        }

        ///<summary>Return the Audio Event Detection Enabled Status</summary>
        /***********************************************************************************************************************/
        public bool TraceAudioEventDetectionIsEnabled()
        /***********************************************************************************************************************/
        {
            if (tracerAudioEventDetection == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /***********************************************************************************************************************/
        internal class TracerAudioEventDetection : IWampRawTopicClientSubscriber
        /***********************************************************************************************************************/
        {

            public event EventHandler<wamp_audio_event_detection> OnAudioEventDetection;
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

                wamp_audio_event_detection audioEvent = Newtonsoft.Json.JsonConvert.DeserializeObject<wamp_audio_event_detection>(arguments[0].ToString());
                OnAudioEventDetection?.Invoke(this, audioEvent);
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

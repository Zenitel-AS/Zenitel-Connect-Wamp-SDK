
using System;
using System.Collections.Generic;
using WampSharp.Core.Serialization;
using WampSharp.V2.Core.Contracts;
using System.Threading;
using WampSharp.V2.Rpc;

namespace Wamp.Client
{
    public partial class WampClient
    {
        /***********************************************************************************************************************/
        /********************                                  Post Device GPO                               *******************/
        /***********************************************************************************************************************/

        /// <summary>
        /// Change a single digital output controlled by a device. The gpo_id is made up of the type and the index starting from 1.
        /// The index correspond to the array index in the device GPIO configuration, i.e the 'outputs' (relay) and 'gpio' arrays.
        /// The number of outputs for each type may vary between device types. In order to set a GPIO by this URI, the corresponding
        /// GPIO has to be configured as output. Example: id=relay2, id=gpio5.
        /// It will return the outcome of the request execution in the wamp_response class.
        /// </summary>

        /// <param name="dirNo">This parameter specifies directory number of the selected device.</param>
        /// <param name="Id">This parameter specifies the port name {relay1, relay2, gpio1 ...}.</param>
        /// <param name="Operation">This parameter specifies directory number of the selected device.</param>
        /// <param name="Time">This parameter specifies the time </param>

        /// <returns name="wamp_response">This class contains the result of the request execution and a describing text in case the
        /// request fails.
        /// </returns>

        /***********************************************************************************************************************/
        public wamp_response PostDeviceGPO(string dirNo, string Id, string Operation, Int32 Time)
        /***********************************************************************************************************************/
        {
            wamp_response wampResp = new wamp_response();

            try
            {
                Dictionary<string, object> argumentsKeywords = new Dictionary<string, object>();

                argumentsKeywords["dirno"] = dirNo;
                argumentsKeywords["id"] = Id;
                argumentsKeywords["operation"] = Operation;
                argumentsKeywords["time"] = Time;

                RPCCallback rpcCallback = new RPCCallback();

                _wampRealmProxy.RpcCatalog.Invoke(rpcCallback,
                                                  new CallOptions(),
                                                  PostWampDevicesGposGpoId,
                                                  new object[] { argumentsKeywords });

                // Wait time limited for a reply from the WAMP-protocol
                bool cont = true;
                int loopCount = 0;
                int sleepTime = 10;

                while (cont)
                {
                    //Wait for RPC response
                    Thread.Sleep(sleepTime);
                    if (rpcCallback.RespRecv)
                    {
                        cont = false;
                    }
                    else
                    {
                        loopCount++;
                        if (loopCount > 30) cont = false;
                    }
                }

                if (rpcCallback.RespRecv)
                {
                    if (rpcCallback.CompletedSuccessfully)
                    {
                        wampResp.WampResponse = ResponseType.WampRequestSucceeded;
                        wampResp.CompletionText = "PostDeviceGPO sucessfully completed.";
                    }
                    else
                    {
                        wampResp.WampResponse = ResponseType.WampRequestFailed;
                        wampResp.CompletionText = "PostDeviceGPO failed: " + rpcCallback.CompletionText;
                    }
                }
                else
                {
                    wampResp.WampResponse = ResponseType.WampNoResponce;
                    wampResp.CompletionText = "PostDeviceGPO failed. No response from WAMP.";
                }

            }
            catch (Exception ex)
            {
                OnChildLogString?.Invoke(this, "Exception in PostDeviceGPO: " + ex.ToString());
            }

            return wampResp;
        }


        internal class RPCCallback : IWampRawRpcOperationClientCallback
        {
            public bool   RespRecv = false;
            public bool   CompletedSuccessfully = false;
            public string CompletionText = string.Empty;


            public void Result<TMessage>(IWampFormatter<TMessage> formatter, ResultDetails details)
            {
                RespRecv = true;
                CompletedSuccessfully = true;
            }


            public void Result<TMessage>(IWampFormatter<TMessage> formatter, ResultDetails details, TMessage[] arguments)
            {
                RespRecv = true;
                CompletedSuccessfully = true;
            }


            public void Result<TMessage>(IWampFormatter<TMessage> formatter,
                                         ResultDetails details,
                                         TMessage[] arguments,
                                         IDictionary<string, TMessage> argumentsKeywords)
            {
                RespRecv = true;
                CompletedSuccessfully = true;
            }


            public void Error<TMessage>(IWampFormatter<TMessage> formatter, TMessage details, string error)
            {
                RespRecv = true;
                CompletedSuccessfully = false;
                CompletionText = error;
            }


            public void Error<TMessage>(IWampFormatter<TMessage> formatter, TMessage details, string error, TMessage[] arguments)
            {
                RespRecv = true;
                CompletedSuccessfully = false;
                CompletionText = error;
            }


            public void Error<TMessage>(IWampFormatter<TMessage> formatter, TMessage details, string error, TMessage[] arguments,
                                        TMessage argumentsKeywords)
            {
                RespRecv = true;
                CompletedSuccessfully = false;
                CompletionText = error;
            }
        }
    }
}
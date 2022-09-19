﻿using WampSharp.V2.Rpc;


namespace Wamp.Client
{
    // interface of WAMP services
    internal interface IConnectWampServices
    {
        [WampProcedure(WampClient.GetWampRegisteredDevices)]
        object SystemDevicesRegistered();


        [WampProcedure(WampClient.GetWampInterfaceList)]
        object InterfaceList();

        [WampProcedure(WampClient.GetWampCalls)]
        object GET_calls(string dirNo, string callId, string state);


        [WampProcedure(WampClient.GetWampQueues)]
        object GET_calls_queued(string agent, string fromDirno, string queueDirNo);


        [WampProcedure(WampClient.GetWampDevicesGpos)]
        object GET_devices_gpos(string device_id, string id);


        [WampProcedure(WampClient.GetWampDevicesGpis)]
        object GET_devices_gpis(string device_id, string id);
    }
}
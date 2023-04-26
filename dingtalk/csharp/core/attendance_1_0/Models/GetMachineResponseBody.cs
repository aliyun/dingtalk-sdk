// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetMachineResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMachineResponseBodyResult Result { get; set; }
        public class GetMachineResponseBodyResult : TeaModel {
            [NameInMap("atmManagerList")]
            [Validation(Required=false)]
            public List<string> AtmManagerList { get; set; }

            [NameInMap("devId")]
            [Validation(Required=false)]
            public long? DevId { get; set; }

            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("deviceSn")]
            [Validation(Required=false)]
            public string DeviceSn { get; set; }

            [NameInMap("machineBluetoothVO")]
            [Validation(Required=false)]
            public GetMachineResponseBodyResultMachineBluetoothVO MachineBluetoothVO { get; set; }
            public class GetMachineResponseBodyResultMachineBluetoothVO : TeaModel {
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("bluetoothCheckWithFace")]
                [Validation(Required=false)]
                public bool? BluetoothCheckWithFace { get; set; }

                [NameInMap("bluetoothDistanceMode")]
                [Validation(Required=false)]
                public string BluetoothDistanceMode { get; set; }

                [NameInMap("bluetoothDistanceModeDesc")]
                [Validation(Required=false)]
                public string BluetoothDistanceModeDesc { get; set; }

                [NameInMap("bluetoothValue")]
                [Validation(Required=false)]
                public bool? BluetoothValue { get; set; }

                [NameInMap("latitude")]
                [Validation(Required=false)]
                public double? Latitude { get; set; }

                [NameInMap("limitUserDeviceCount")]
                [Validation(Required=false)]
                public bool? LimitUserDeviceCount { get; set; }

                [NameInMap("longitude")]
                [Validation(Required=false)]
                public double? Longitude { get; set; }

                [NameInMap("monitorLocationAbnormal")]
                [Validation(Required=false)]
                public bool? MonitorLocationAbnormal { get; set; }

                [NameInMap("userDeviceCount")]
                [Validation(Required=false)]
                public int? UserDeviceCount { get; set; }

            }

            [NameInMap("maxFace")]
            [Validation(Required=false)]
            public int? MaxFace { get; set; }

            [NameInMap("netStatus")]
            [Validation(Required=false)]
            public string NetStatus { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("productVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            [NameInMap("voiceMode")]
            [Validation(Required=false)]
            public int? VoiceMode { get; set; }

        }

    }

}

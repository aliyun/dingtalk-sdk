// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetMachineResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMachineResponseBodyResult Result { get; set; }
        public class GetMachineResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("atmManagerList")]
            [Validation(Required=false)]
            public List<string> AtmManagerList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("devId")]
            [Validation(Required=false)]
            public long? DevId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deviceSn")]
            [Validation(Required=false)]
            public string DeviceSn { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("machineBluetoothVO")]
            [Validation(Required=false)]
            public GetMachineResponseBodyResultMachineBluetoothVO MachineBluetoothVO { get; set; }
            public class GetMachineResponseBodyResultMachineBluetoothVO : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("bluetoothCheckWithFace")]
                [Validation(Required=false)]
                public bool? BluetoothCheckWithFace { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("bluetoothDistanceMode")]
                [Validation(Required=false)]
                public string BluetoothDistanceMode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("bluetoothDistanceModeDesc")]
                [Validation(Required=false)]
                public string BluetoothDistanceModeDesc { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("bluetoothValue")]
                [Validation(Required=false)]
                public bool? BluetoothValue { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public double? Latitude { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("limitUserDeviceCount")]
                [Validation(Required=false)]
                public bool? LimitUserDeviceCount { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public double? Longitude { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("monitorLocationAbnormal")]
                [Validation(Required=false)]
                public bool? MonitorLocationAbnormal { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("userDeviceCount")]
                [Validation(Required=false)]
                public int? UserDeviceCount { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("maxFace")]
            [Validation(Required=false)]
            public int? MaxFace { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("netStatus")]
            [Validation(Required=false)]
            public string NetStatus { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("productVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("voiceMode")]
            [Validation(Required=false)]
            public int? VoiceMode { get; set; }

        }

    }

}

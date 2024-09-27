// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetMachineResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMachineResponseBodyResult Result { get; set; }
        public class GetMachineResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("atmManagerList")]
            [Validation(Required=false)]
            public List<string> AtmManagerList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1406333705</para>
            /// </summary>
            [NameInMap("devId")]
            [Validation(Required=false)]
            public long? DevId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2078053438</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>泱云❄️的体00056</para>
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0601IFW201001N000056</para>
            /// </summary>
            [NameInMap("deviceSn")]
            [Validation(Required=false)]
            public string DeviceSn { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("machineBluetoothVO")]
            [Validation(Required=false)]
            public GetMachineResponseBodyResultMachineBluetoothVO MachineBluetoothVO { get; set; }
            public class GetMachineResponseBodyResultMachineBluetoothVO : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>绿城-未来park</para>
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("bluetoothCheckWithFace")]
                [Validation(Required=false)]
                public bool? BluetoothCheckWithFace { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("bluetoothDistanceMode")]
                [Validation(Required=false)]
                public string BluetoothDistanceMode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>默认 (最远5-10米)</para>
                /// </summary>
                [NameInMap("bluetoothDistanceModeDesc")]
                [Validation(Required=false)]
                public string BluetoothDistanceModeDesc { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("bluetoothValue")]
                [Validation(Required=false)]
                public bool? BluetoothValue { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30.285871310763888</para>
                /// </summary>
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public double? Latitude { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("limitUserDeviceCount")]
                [Validation(Required=false)]
                public bool? LimitUserDeviceCount { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120.01757758246528</para>
                /// </summary>
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public double? Longitude { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("monitorLocationAbnormal")]
                [Validation(Required=false)]
                public bool? MonitorLocationAbnormal { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("userDeviceCount")]
                [Validation(Required=false)]
                public int? UserDeviceCount { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("maxFace")]
            [Validation(Required=false)]
            public int? MaxFace { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("netStatus")]
            [Validation(Required=false)]
            public string NetStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>M1F</para>
            /// </summary>
            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.1-R-20200326.1543</para>
            /// </summary>
            [NameInMap("productVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("voiceMode")]
            [Validation(Required=false)]
            public int? VoiceMode { get; set; }

        }

    }

}

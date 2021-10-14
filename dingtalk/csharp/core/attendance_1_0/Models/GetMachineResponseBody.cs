// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetMachineResponseBody : TeaModel {
        /// <summary>
        /// 查询结果
        /// </summary>
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
                /// <summary>
                /// 地址位置描述
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// 蓝牙打卡人脸识别开关值
                /// </summary>
                [NameInMap("bluetoothCheckWithFace")]
                [Validation(Required=false)]
                public bool? BluetoothCheckWithFace { get; set; }

                /// <summary>
                /// 蓝牙打卡范围
                /// </summary>
                [NameInMap("bluetoothDistanceMode")]
                [Validation(Required=false)]
                public string BluetoothDistanceMode { get; set; }

                /// <summary>
                /// 蓝牙打卡范围描述
                /// </summary>
                [NameInMap("bluetoothDistanceModeDesc")]
                [Validation(Required=false)]
                public string BluetoothDistanceModeDesc { get; set; }

                /// <summary>
                /// 蓝牙打卡开关
                /// </summary>
                [NameInMap("bluetoothValue")]
                [Validation(Required=false)]
                public bool? BluetoothValue { get; set; }

                /// <summary>
                /// 纬度
                /// </summary>
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public double? Latitude { get; set; }

                /// <summary>
                /// 是否限制员工常用手机
                /// </summary>
                [NameInMap("limitUserDeviceCount")]
                [Validation(Required=false)]
                public bool? LimitUserDeviceCount { get; set; }

                /// <summary>
                /// 经度
                /// </summary>
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public double? Longitude { get; set; }

                /// <summary>
                /// 是否打开位置异常监控
                /// </summary>
                [NameInMap("monitorLocationAbnormal")]
                [Validation(Required=false)]
                public bool? MonitorLocationAbnormal { get; set; }

                /// <summary>
                /// 员工常用手机数量
                /// </summary>
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
        };

    }

}

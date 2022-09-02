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
            /// <summary>
            /// 设备管理员列表
            /// </summary>
            [NameInMap("atmManagerList")]
            [Validation(Required=false)]
            public List<string> AtmManagerList { get; set; }

            /// <summary>
            /// 设备id (deviceId)
            /// </summary>
            [NameInMap("devId")]
            [Validation(Required=false)]
            public long? DevId { get; set; }

            /// <summary>
            /// 设备id (deviceUid加密之后)
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// 设备名称
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// 设备sn号
            /// </summary>
            [NameInMap("deviceSn")]
            [Validation(Required=false)]
            public string DeviceSn { get; set; }

            /// <summary>
            /// 考勤机蓝牙相关设置信息
            /// </summary>
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

            /// <summary>
            /// 人脸容量
            /// </summary>
            [NameInMap("maxFace")]
            [Validation(Required=false)]
            public int? MaxFace { get; set; }

            /// <summary>
            /// 网络状态
            /// </summary>
            [NameInMap("netStatus")]
            [Validation(Required=false)]
            public string NetStatus { get; set; }

            /// <summary>
            /// 设备类型名称
            /// </summary>
            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// 固件版本
            /// </summary>
            [NameInMap("productVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            /// <summary>
            /// 音量模式
            /// </summary>
            [NameInMap("voiceMode")]
            [Validation(Required=false)]
            public int? VoiceMode { get; set; }

        }

    }

}

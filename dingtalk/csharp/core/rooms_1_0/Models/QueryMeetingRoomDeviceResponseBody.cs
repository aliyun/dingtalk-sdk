// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryMeetingRoomDeviceResponseBody : TeaModel {
        /// <summary>
        /// 响应结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryMeetingRoomDeviceResponseBodyResult Result { get; set; }
        public class QueryMeetingRoomDeviceResponseBodyResult : TeaModel {
            /// <summary>
            /// 设备控制器
            /// </summary>
            [NameInMap("controllers")]
            [Validation(Required=false)]
            public List<QueryMeetingRoomDeviceResponseBodyResultControllers> Controllers { get; set; }
            public class QueryMeetingRoomDeviceResponseBodyResultControllers : TeaModel {
                /// <summary>
                /// 企业corpId
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// 控制器设备id
                /// </summary>
                [NameInMap("deviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// 控制器mac地址
                /// </summary>
                [NameInMap("deviceMac")]
                [Validation(Required=false)]
                public string DeviceMac { get; set; }

                /// <summary>
                /// 控制器型号
                /// </summary>
                [NameInMap("deviceModel")]
                [Validation(Required=false)]
                public string DeviceModel { get; set; }

                /// <summary>
                /// 控制器名称
                /// </summary>
                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// 控制器注册serviceId
                /// </summary>
                [NameInMap("deviceServiceId")]
                [Validation(Required=false)]
                public int? DeviceServiceId { get; set; }

                /// <summary>
                /// 控制器sn
                /// </summary>
                [NameInMap("deviceSn")]
                [Validation(Required=false)]
                public string DeviceSn { get; set; }

                /// <summary>
                /// 控制器状态
                /// </summary>
                [NameInMap("deviceStatus")]
                [Validation(Required=false)]
                public string DeviceStatus { get; set; }

                /// <summary>
                /// 设备类型
                /// </summary>
                [NameInMap("deviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                /// <summary>
                /// 控制器unionId
                /// </summary>
                [NameInMap("deviceUnionId")]
                [Validation(Required=false)]
                public string DeviceUnionId { get; set; }

                /// <summary>
                /// 控制器绑定会议室id
                /// </summary>
                [NameInMap("openRoomId")]
                [Validation(Required=false)]
                public string OpenRoomId { get; set; }

                /// <summary>
                /// 控制器投屏码
                /// </summary>
                [NameInMap("shareCode")]
                [Validation(Required=false)]
                public string ShareCode { get; set; }

            }

            /// <summary>
            /// 企业corpId
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 设备id
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// 设备mac地址
            /// </summary>
            [NameInMap("deviceMac")]
            [Validation(Required=false)]
            public string DeviceMac { get; set; }

            /// <summary>
            /// 设备型号
            /// </summary>
            [NameInMap("deviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            /// <summary>
            /// 设备名称
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// 设备注册serviceId
            /// </summary>
            [NameInMap("deviceServiceId")]
            [Validation(Required=false)]
            public int? DeviceServiceId { get; set; }

            /// <summary>
            /// 设备sn
            /// </summary>
            [NameInMap("deviceSn")]
            [Validation(Required=false)]
            public string DeviceSn { get; set; }

            /// <summary>
            /// 设备状态
            /// </summary>
            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public string DeviceStatus { get; set; }

            /// <summary>
            /// 设备类型
            /// </summary>
            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// 设备unionId
            /// </summary>
            [NameInMap("deviceUnionId")]
            [Validation(Required=false)]
            public string DeviceUnionId { get; set; }

            /// <summary>
            /// 设备绑定会议室id
            /// </summary>
            [NameInMap("openRoomId")]
            [Validation(Required=false)]
            public string OpenRoomId { get; set; }

            /// <summary>
            /// 设备投屏码
            /// </summary>
            [NameInMap("shareCode")]
            [Validation(Required=false)]
            public string ShareCode { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchRegisterDeviceRequest : TeaModel {
        /// <summary>
        /// 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 设备列表。
        /// </summary>
        [NameInMap("devices")]
        [Validation(Required=false)]
        public List<BatchRegisterDeviceRequestDevices> Devices { get; set; }
        public class BatchRegisterDeviceRequestDevices : TeaModel {
            /// <summary>
            /// 设备ID。
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// 设备名称。
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// 设备状态  0:在线  1:离线
            /// </summary>
            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public int? DeviceStatus { get; set; }

            /// <summary>
            /// 设备类型，自定义传入，最多128个字节。
            /// </summary>
            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// 设备类型名称，自定义传入，最多128个字节，与deviceType一一对应。
            /// </summary>
            [NameInMap("deviceTypeName")]
            [Validation(Required=false)]
            public string DeviceTypeName { get; set; }

            /// <summary>
            /// 第三方平台定制参数，企业内部系统忽略。
            /// </summary>
            [NameInMap("extraData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraData { get; set; }

            /// <summary>
            /// 视频流地址直播流地址，支持rtmp、flv、hls等格式，需要https协议。
            /// </summary>
            [NameInMap("liveUrls")]
            [Validation(Required=false)]
            public BatchRegisterDeviceRequestDevicesLiveUrls LiveUrls { get; set; }
            public class BatchRegisterDeviceRequestDevicesLiveUrls : TeaModel {
                /// <summary>
                /// flv格式视频流地址
                /// </summary>
                [NameInMap("flv")]
                [Validation(Required=false)]
                public string Flv { get; set; }

                /// <summary>
                /// hls格式视频流地址
                /// </summary>
                [NameInMap("hls")]
                [Validation(Required=false)]
                public string Hls { get; set; }

                /// <summary>
                /// rtmp格式视频流地址
                /// </summary>
                [NameInMap("rtmp")]
                [Validation(Required=false)]
                public string Rtmp { get; set; }

            }

            /// <summary>
            /// 设备地址。
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// 父设备ID。
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// 产品类型 CAMERA：摄像头，可看直播 OTHERS：非摄像头
            /// </summary>
            [NameInMap("productType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

        }

    }

}

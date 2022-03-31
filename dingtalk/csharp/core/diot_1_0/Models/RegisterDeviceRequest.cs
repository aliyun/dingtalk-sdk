// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class RegisterDeviceRequest : TeaModel {
        /// <summary>
        /// 钉钉组织id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备状态 0:在线 1:离线
        /// </summary>
        [NameInMap("deviceStatus")]
        [Validation(Required=false)]
        public int? DeviceStatus { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [NameInMap("deviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备类型名称
        /// </summary>
        [NameInMap("deviceTypeName")]
        [Validation(Required=false)]
        public string DeviceTypeName { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 视频流地址直播流地址，支持rtmp、flv、hls等格式，需要https协议。
        /// </summary>
        [NameInMap("liveUrls")]
        [Validation(Required=false)]
        public RegisterDeviceRequestLiveUrls LiveUrls { get; set; }
        public class RegisterDeviceRequestLiveUrls : TeaModel {
            [NameInMap("flv")]
            [Validation(Required=false)]
            public string Flv { get; set; }
            [NameInMap("hls")]
            [Validation(Required=false)]
            public string Hls { get; set; }
            [NameInMap("rtmp")]
            [Validation(Required=false)]
            public string Rtmp { get; set; }
        };

        /// <summary>
        /// 设备地址
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// 设备昵称
        /// </summary>
        [NameInMap("nickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// 设备父节点id
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// 设备类型 摄像头:CAMERA 其它:OTHERS
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}

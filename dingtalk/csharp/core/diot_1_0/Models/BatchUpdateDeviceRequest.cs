// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchUpdateDeviceRequest : TeaModel {
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
        public List<BatchUpdateDeviceRequestDevices> Devices { get; set; }
        public class BatchUpdateDeviceRequestDevices : TeaModel {
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
            /// 设备地址。
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// 设备状态 0:在线 1:离线
            /// </summary>
            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public int? DeviceStatus { get; set; }

            /// <summary>
            /// 视频流地址直播流地址，支持rtmp、flv、hls等格式，需要https协议。
            /// </summary>
            [NameInMap("liveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }

            /// <summary>
            /// 第三方平台定制参数，企业内部系统忽略。
            /// </summary>
            [NameInMap("extraData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraData { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchUpdateDeviceRequest : TeaModel {
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("devices")]
        [Validation(Required=false)]
        public List<BatchUpdateDeviceRequestDevices> Devices { get; set; }
        public class BatchUpdateDeviceRequestDevices : TeaModel {
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public int? DeviceStatus { get; set; }

            [NameInMap("extraData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraData { get; set; }

            [NameInMap("liveUrls")]
            [Validation(Required=false)]
            public BatchUpdateDeviceRequestDevicesLiveUrls LiveUrls { get; set; }
            public class BatchUpdateDeviceRequestDevicesLiveUrls : TeaModel {
                [NameInMap("flv")]
                [Validation(Required=false)]
                public string Flv { get; set; }

                [NameInMap("hls")]
                [Validation(Required=false)]
                public string Hls { get; set; }

                [NameInMap("rtmp")]
                [Validation(Required=false)]
                public string Rtmp { get; set; }

            }

            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

        }

    }

}

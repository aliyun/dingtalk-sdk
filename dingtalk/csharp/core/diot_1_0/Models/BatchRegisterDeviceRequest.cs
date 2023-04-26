// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchRegisterDeviceRequest : TeaModel {
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("devices")]
        [Validation(Required=false)]
        public List<BatchRegisterDeviceRequestDevices> Devices { get; set; }
        public class BatchRegisterDeviceRequestDevices : TeaModel {
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public int? DeviceStatus { get; set; }

            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("deviceTypeName")]
            [Validation(Required=false)]
            public string DeviceTypeName { get; set; }

            [NameInMap("extraData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraData { get; set; }

            [NameInMap("liveUrls")]
            [Validation(Required=false)]
            public BatchRegisterDeviceRequestDevicesLiveUrls LiveUrls { get; set; }
            public class BatchRegisterDeviceRequestDevicesLiveUrls : TeaModel {
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

            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("productType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

        }

    }

}

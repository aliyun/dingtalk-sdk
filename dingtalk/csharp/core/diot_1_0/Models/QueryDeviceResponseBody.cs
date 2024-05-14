// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class QueryDeviceResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryDeviceResponseBodyData> Data { get; set; }
        public class QueryDeviceResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public long? DeviceStatus { get; set; }

            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("deviceTypeName")]
            [Validation(Required=false)]
            public string DeviceTypeName { get; set; }

            [NameInMap("liveUrls")]
            [Validation(Required=false)]
            public QueryDeviceResponseBodyDataLiveUrls LiveUrls { get; set; }
            public class QueryDeviceResponseBodyDataLiveUrls : TeaModel {
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

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

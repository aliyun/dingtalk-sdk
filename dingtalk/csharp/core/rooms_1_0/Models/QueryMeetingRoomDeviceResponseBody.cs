// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryMeetingRoomDeviceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryMeetingRoomDeviceResponseBodyResult Result { get; set; }
        public class QueryMeetingRoomDeviceResponseBodyResult : TeaModel {
            [NameInMap("controllers")]
            [Validation(Required=false)]
            public List<QueryMeetingRoomDeviceResponseBodyResultControllers> Controllers { get; set; }
            public class QueryMeetingRoomDeviceResponseBodyResultControllers : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("deviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                [NameInMap("deviceMac")]
                [Validation(Required=false)]
                public string DeviceMac { get; set; }

                [NameInMap("deviceModel")]
                [Validation(Required=false)]
                public string DeviceModel { get; set; }

                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("deviceServiceId")]
                [Validation(Required=false)]
                public int? DeviceServiceId { get; set; }

                [NameInMap("deviceSn")]
                [Validation(Required=false)]
                public string DeviceSn { get; set; }

                [NameInMap("deviceStatus")]
                [Validation(Required=false)]
                public string DeviceStatus { get; set; }

                [NameInMap("deviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                [NameInMap("deviceUnionId")]
                [Validation(Required=false)]
                public string DeviceUnionId { get; set; }

                [NameInMap("openRoomId")]
                [Validation(Required=false)]
                public string OpenRoomId { get; set; }

                [NameInMap("shareCode")]
                [Validation(Required=false)]
                public string ShareCode { get; set; }

            }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("deviceMac")]
            [Validation(Required=false)]
            public string DeviceMac { get; set; }

            [NameInMap("deviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("deviceServiceId")]
            [Validation(Required=false)]
            public int? DeviceServiceId { get; set; }

            [NameInMap("deviceSn")]
            [Validation(Required=false)]
            public string DeviceSn { get; set; }

            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public string DeviceStatus { get; set; }

            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("deviceUnionId")]
            [Validation(Required=false)]
            public string DeviceUnionId { get; set; }

            [NameInMap("openRoomId")]
            [Validation(Required=false)]
            public string OpenRoomId { get; set; }

            [NameInMap("shareCode")]
            [Validation(Required=false)]
            public string ShareCode { get; set; }

        }

    }

}

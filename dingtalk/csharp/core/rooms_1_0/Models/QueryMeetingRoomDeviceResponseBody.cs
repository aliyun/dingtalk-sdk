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
            [NameInMap("activeTime")]
            [Validation(Required=false)]
            public long? ActiveTime { get; set; }

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

            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            [NameInMap("devCamera")]
            [Validation(Required=false)]
            public string DevCamera { get; set; }

            [NameInMap("devHdmi")]
            [Validation(Required=false)]
            public string DevHdmi { get; set; }

            [NameInMap("devMic")]
            [Validation(Required=false)]
            public string DevMic { get; set; }

            [NameInMap("devMirror")]
            [Validation(Required=false)]
            public string DevMirror { get; set; }

            [NameInMap("devNetIp")]
            [Validation(Required=false)]
            public string DevNetIp { get; set; }

            [NameInMap("devNetType")]
            [Validation(Required=false)]
            public string DevNetType { get; set; }

            [NameInMap("devVoice")]
            [Validation(Required=false)]
            public string DevVoice { get; set; }

            [NameInMap("devWifiMac")]
            [Validation(Required=false)]
            public string DevWifiMac { get; set; }

            [NameInMap("devWireMac")]
            [Validation(Required=false)]
            public string DevWireMac { get; set; }

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

            [NameInMap("firmwareVersion")]
            [Validation(Required=false)]
            public string FirmwareVersion { get; set; }

            [NameInMap("openRoomId")]
            [Validation(Required=false)]
            public string OpenRoomId { get; set; }

            [NameInMap("roomName")]
            [Validation(Required=false)]
            public string RoomName { get; set; }

            [NameInMap("shareCode")]
            [Validation(Required=false)]
            public string ShareCode { get; set; }

            [NameInMap("sipAccountName")]
            [Validation(Required=false)]
            public string SipAccountName { get; set; }

            [NameInMap("softwareVersion")]
            [Validation(Required=false)]
            public string SoftwareVersion { get; set; }

        }

    }

}

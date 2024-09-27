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
            /// <summary>
            /// <b>Example:</b>
            /// <para>1697198045000</para>
            /// </summary>
            [NameInMap("activeTime")]
            [Validation(Required=false)]
            public long? ActiveTime { get; set; }

            [NameInMap("controllers")]
            [Validation(Required=false)]
            public List<QueryMeetingRoomDeviceResponseBodyResultControllers> Controllers { get; set; }
            public class QueryMeetingRoomDeviceResponseBodyResultControllers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;ding994a046bca84545935c2f4657eb6378f&quot;</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2345</para>
                /// </summary>
                [NameInMap("deviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;d8:2f:e6:d9:ab:5b&quot;</para>
                /// </summary>
                [NameInMap("deviceMac")]
                [Validation(Required=false)]
                public string DeviceMac { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;AILABS_S3_T1&quot;</para>
                /// </summary>
                [NameInMap("deviceModel")]
                [Validation(Required=false)]
                public string DeviceModel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>会控平板_xxxx</para>
                /// </summary>
                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1190</para>
                /// </summary>
                [NameInMap("deviceServiceId")]
                [Validation(Required=false)]
                public int? DeviceServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;02caa8169c80f74a2d375093a6107017&quot;</para>
                /// </summary>
                [NameInMap("deviceSn")]
                [Validation(Required=false)]
                public string DeviceSn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>空闲：idle  投屏中：projection   会议响铃中：conf_incoming   会议中：conf_running   使用白板中：white_board   离线: offline</para>
                /// </summary>
                [NameInMap("deviceStatus")]
                [Validation(Required=false)]
                public string DeviceStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>视频会议设备:&quot;touyingyi&quot;   设备控制器:&quot;meetingaccessory&quot;</para>
                /// </summary>
                [NameInMap("deviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;lmvUrRkpboRrSMtgsiS9V4AiEiE&quot;</para>
                /// </summary>
                [NameInMap("deviceUnionId")]
                [Validation(Required=false)]
                public string DeviceUnionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;7263defed6b361fedf0fe6a3b578b96e808b09d6ca6282ed&quot;</para>
                /// </summary>
                [NameInMap("openRoomId")]
                [Validation(Required=false)]
                public string OpenRoomId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>234567</para>
                /// </summary>
                [NameInMap("shareCode")]
                [Validation(Required=false)]
                public string ShareCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;ding994a046bca84545935c2f4657eb6378f&quot;</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lPHhSZDLXXXXXXpBlC9lxLwiEiE</para>
            /// </summary>
            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Smart Camera</para>
            /// </summary>
            [NameInMap("devCamera")]
            [Validation(Required=false)]
            public string DevCamera { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("devHdmi")]
            [Validation(Required=false)]
            public string DevHdmi { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Microphone (2- Built-in Audio)</para>
            /// </summary>
            [NameInMap("devMic")]
            [Validation(Required=false)]
            public string DevMic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("devMirror")]
            [Validation(Required=false)]
            public string DevMirror { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.10</para>
            /// </summary>
            [NameInMap("devNetIp")]
            [Validation(Required=false)]
            public string DevNetIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>net_wired</para>
            /// </summary>
            [NameInMap("devNetType")]
            [Validation(Required=false)]
            public string DevNetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Speaker (2- Built-in Audio)</para>
            /// </summary>
            [NameInMap("devVoice")]
            [Validation(Required=false)]
            public string DevVoice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d4:aa:ee:e8:4d:55</para>
            /// </summary>
            [NameInMap("devWifiMac")]
            [Validation(Required=false)]
            public string DevWifiMac { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d4:3a:ee:aa:45:85</para>
            /// </summary>
            [NameInMap("devWireMac")]
            [Validation(Required=false)]
            public string DevWireMac { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;14:85:7f:e5:f3:f3&quot;</para>
            /// </summary>
            [NameInMap("deviceMac")]
            [Validation(Required=false)]
            public string DeviceMac { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>winbox</para>
            /// </summary>
            [NameInMap("deviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>钉钉会议设备_xxxx</para>
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1204</para>
            /// </summary>
            [NameInMap("deviceServiceId")]
            [Validation(Required=false)]
            public int? DeviceServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;02caa8169c80f74a2d375093a6107016&quot;</para>
            /// </summary>
            [NameInMap("deviceSn")]
            [Validation(Required=false)]
            public string DeviceSn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>空闲：idle  投屏中：projection   会议响铃中：conf_incoming   会议中：conf_running   使用白板中：white_board   离线: offline</para>
            /// </summary>
            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public string DeviceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>视频会议设备:&quot;touyingyi&quot;   设备控制器:&quot;meetingaccessory&quot;</para>
            /// </summary>
            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;lmvUrRkpboRrSMtgsiS9V3AiEiE&quot;</para>
            /// </summary>
            [NameInMap("deviceUnionId")]
            [Validation(Required=false)]
            public string DeviceUnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>LMVXXX.20XX0818</para>
            /// </summary>
            [NameInMap("firmwareVersion")]
            [Validation(Required=false)]
            public string FirmwareVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;7263defed6b361fedf0fe6a3b578b96e808b09d6ca6282ed&quot;</para>
            /// </summary>
            [NameInMap("openRoomId")]
            [Validation(Required=false)]
            public string OpenRoomId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试会议室</para>
            /// </summary>
            [NameInMap("roomName")]
            [Validation(Required=false)]
            public string RoomName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("shareCode")]
            [Validation(Required=false)]
            public string ShareCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sip13492</para>
            /// </summary>
            [NameInMap("sipAccountName")]
            [Validation(Required=false)]
            public string SipAccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7.14.1</para>
            /// </summary>
            [NameInMap("softwareVersion")]
            [Validation(Required=false)]
            public string SoftwareVersion { get; set; }

        }

    }

}

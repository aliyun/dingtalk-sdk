// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class GetConfDetailDataResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<GetConfDetailDataResponseBodyList> List { get; set; }
        public class GetConfDetailDataResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("belongOrg")]
            [Validation(Required=false)]
            public string BelongOrg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6449d8a6414xxxxxxxx01464af9f0</para>
            /// </summary>
            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Mac</para>
            /// </summary>
            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>974000</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1682561199000</para>
            /// </summary>
            [NameInMap("joinTime")]
            [Validation(Required=false)]
            public long? JoinTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1682562173000</para>
            /// </summary>
            [NameInMap("leaveTime")]
            [Validation(Required=false)]
            public long? LeaveTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("networkQuality")]
            [Validation(Required=false)]
            public string NetworkQuality { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>参会人</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>已离开</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>njMTqKo9xxxxEiE</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6.1.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxZ0bVGoqxxBGQbxdxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

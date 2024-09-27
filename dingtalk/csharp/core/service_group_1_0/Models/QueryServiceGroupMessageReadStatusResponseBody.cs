// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryServiceGroupMessageReadStatusResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<QueryServiceGroupMessageReadStatusResponseBodyRecords> Records { get; set; }
        public class QueryServiceGroupMessageReadStatusResponseBodyRecords : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("readStatus")]
            [Validation(Required=false)]
            public int? ReadStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-09-01 00:00:00</para>
            /// </summary>
            [NameInMap("readTimeStr")]
            [Validation(Required=false)]
            public string ReadTimeStr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>$:LWCP_v1:xxxx==</para>
            /// </summary>
            [NameInMap("receiverDingTalkId")]
            [Validation(Required=false)]
            public string ReceiverDingTalkId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("receiverName")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Kxiwk2</para>
            /// </summary>
            [NameInMap("receiverUnionId")]
            [Validation(Required=false)]
            public string ReceiverUnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("receiverUserId")]
            [Validation(Required=false)]
            public string ReceiverUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-09-01 00:00:00</para>
            /// </summary>
            [NameInMap("sendTimeStr")]
            [Validation(Required=false)]
            public string SendTimeStr { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

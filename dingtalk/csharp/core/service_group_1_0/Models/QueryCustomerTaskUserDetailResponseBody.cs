// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryCustomerTaskUserDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<QueryCustomerTaskUserDetailResponseBodyRecords> Records { get; set; }
        public class QueryCustomerTaskUserDetailResponseBodyRecords : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>客户名称</para>
            /// </summary>
            [NameInMap("customerNames")]
            [Validation(Required=false)]
            public string CustomerNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("errorDetail")]
            [Validation(Required=false)]
            public string ErrorDetail { get; set; }

            [NameInMap("eventTrackResponses")]
            [Validation(Required=false)]
            public List<QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses> EventTrackResponses { get; set; }
            public class QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-14 00:00:00</para>
                /// </summary>
                [NameInMap("clickTime")]
                [Validation(Required=false)]
                public string ClickTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>88888</para>
                /// </summary>
                [NameInMap("eventTrackId")]
                [Validation(Required=false)]
                public string EventTrackId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("onClick")]
                [Validation(Required=false)]
                public bool? OnClick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>标题名称</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8888</para>
            /// </summary>
            [NameInMap("openBatchTaskId")]
            [Validation(Required=false)]
            public string OpenBatchTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("readStatus")]
            [Validation(Required=false)]
            public long? ReadStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-14 00:00:00</para>
            /// </summary>
            [NameInMap("readTime")]
            [Validation(Required=false)]
            public string ReadTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>接收人姓名</para>
            /// </summary>
            [NameInMap("receiverName")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>接收人ID</para>
            /// </summary>
            [NameInMap("receiverUnionId")]
            [Validation(Required=false)]
            public string ReceiverUnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-14 00:00:00</para>
            /// </summary>
            [NameInMap("sendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UNSEND未发；SEND_SUCCESS成功；SEND_FAILED失败；EXCEED_LIMIT被限流</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

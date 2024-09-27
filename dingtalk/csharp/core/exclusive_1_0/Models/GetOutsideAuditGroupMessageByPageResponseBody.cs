// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetOutsideAuditGroupMessageByPageResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("responseBody")]
        [Validation(Required=false)]
        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBody ResponseBody { get; set; }
        public class GetOutsideAuditGroupMessageByPageResponseBodyResponseBody : TeaModel {
            [NameInMap("messageList")]
            [Validation(Required=false)]
            public List<GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList> MessageList { get; set; }
            public class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{   &quot;text&quot;: {     &quot;content&quot;: &quot;这是一段文本&quot;   } }</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text/audio/video</para>
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-05 15:43:03</para>
                /// </summary>
                [NameInMap("createAt")]
                [Validation(Required=false)]
                public string CreateAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cid123456</para>
                /// </summary>
                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

                [NameInMap("sender")]
                [Validation(Required=false)]
                public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender Sender { get; set; }
                public class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>user1234</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>userId</para>
                    /// </summary>
                    [NameInMap("idType")]
                    [Validation(Required=false)]
                    public string IdType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>user</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1680493837428</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}

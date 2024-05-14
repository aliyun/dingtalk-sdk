// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetOutsideAuditGroupMessageByPageResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("responseBody")]
        [Validation(Required=false)]
        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBody ResponseBody { get; set; }
        public class GetOutsideAuditGroupMessageByPageResponseBodyResponseBody : TeaModel {
            [NameInMap("messageList")]
            [Validation(Required=false)]
            public List<GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList> MessageList { get; set; }
            public class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("createAt")]
                [Validation(Required=false)]
                public string CreateAt { get; set; }

                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

                [NameInMap("sender")]
                [Validation(Required=false)]
                public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender Sender { get; set; }
                public class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("idType")]
                    [Validation(Required=false)]
                    public string IdType { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}

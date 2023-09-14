// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class QueryConversationMessageForAIResponseBody : TeaModel {
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<QueryConversationMessageForAIResponseBodyMessages> Messages { get; set; }
        public class QueryConversationMessageForAIResponseBodyMessages : TeaModel {
            [NameInMap("atAll")]
            [Validation(Required=false)]
            public bool? AtAll { get; set; }

            [NameInMap("atUsers")]
            [Validation(Required=false)]
            public List<QueryConversationMessageForAIResponseBodyMessagesAtUsers> AtUsers { get; set; }
            public class QueryConversationMessageForAIResponseBodyMessagesAtUsers : TeaModel {
                [NameInMap("agentCode")]
                [Validation(Required=false)]
                public string AgentCode { get; set; }

                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("msgContent")]
            [Validation(Required=false)]
            public string MsgContent { get; set; }

            [NameInMap("msgType")]
            [Validation(Required=false)]
            public string MsgType { get; set; }

            [NameInMap("sendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            [NameInMap("sender")]
            [Validation(Required=false)]
            public QueryConversationMessageForAIResponseBodyMessagesSender Sender { get; set; }
            public class QueryConversationMessageForAIResponseBodyMessagesSender : TeaModel {
                [NameInMap("agentCode")]
                [Validation(Required=false)]
                public string AgentCode { get; set; }

                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

        }

    }

}

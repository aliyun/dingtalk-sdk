// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetOutsideAuditGroupMessageByPageResponseBody : TeaModel {
        /// <summary>
        /// 返回结构体
        /// </summary>
        [NameInMap("responseBody")]
        [Validation(Required=false)]
        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBody ResponseBody { get; set; }
        public class GetOutsideAuditGroupMessageByPageResponseBodyResponseBody : TeaModel {
            /// <summary>
            /// 消息列表
            /// </summary>
            [NameInMap("messageList")]
            [Validation(Required=false)]
            public List<GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList> MessageList { get; set; }
            public class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList : TeaModel {
                /// <summary>
                /// 内容
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// 内容类型 文本/语音/视频
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// 发送时间 格式:yyyy-MM-dd HH:mm:ss
                /// </summary>
                [NameInMap("createAt")]
                [Validation(Required=false)]
                public string CreateAt { get; set; }

                /// <summary>
                /// 会话id
                /// </summary>
                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

                /// <summary>
                /// 发送人
                /// </summary>
                [NameInMap("sender")]
                [Validation(Required=false)]
                public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender Sender { get; set; }
                public class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender : TeaModel {
                    /// <summary>
                    /// 根据id的类型决定是哪一种id
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// 发送者的id类型，可以是userId或者unionId
                    /// </summary>
                    [NameInMap("idType")]
                    [Validation(Required=false)]
                    public string IdType { get; set; }

                    /// <summary>
                    /// 用户-user 机器人-bot 系统账号-sys
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// 下一次请求的token,无返回值则下一条消息不存在
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendMessageRequest : TeaModel {
        /// <summary>
        /// 消息内容
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// 群会话Id
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// B端客服钉钉Id
        /// </summary>
        [NameInMap("receiverId")]
        [Validation(Required=false)]
        public string ReceiverId { get; set; }

        /// <summary>
        /// C端客户appUserId
        /// </summary>
        [NameInMap("senderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

    }

}

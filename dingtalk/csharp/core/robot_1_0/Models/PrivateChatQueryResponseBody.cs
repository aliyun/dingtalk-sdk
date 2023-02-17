// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class PrivateChatQueryResponseBody : TeaModel {
        /// <summary>
        /// 分页查询是否还有人员可查询消息已读状态
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下次分页查询的加密凭证
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 消息已读人的userId列表
        /// </summary>
        [NameInMap("readUserIds")]
        [Validation(Required=false)]
        public List<string> ReadUserIds { get; set; }

        /// <summary>
        /// 消息发送状态
        /// </summary>
        [NameInMap("sendStatus")]
        [Validation(Required=false)]
        public string SendStatus { get; set; }

    }

}

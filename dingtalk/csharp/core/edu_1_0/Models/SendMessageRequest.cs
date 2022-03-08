// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SendMessageRequest : TeaModel {
        /// <summary>
        /// 消息的唯一id
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// 发送者
        /// </summary>
        [NameInMap("fromUserId")]
        [Validation(Required=false)]
        public string FromUserId { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// 接收者
        /// </summary>
        [NameInMap("toUserIdList")]
        [Validation(Required=false)]
        public List<string> ToUserIdList { get; set; }

        /// <summary>
        /// 发送消息的类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}

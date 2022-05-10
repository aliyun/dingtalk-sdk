// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class GrantHonorRequest : TeaModel {
        /// <summary>
        /// 有效期到期时间 时间戳. 会处理成到期那天的23:59:59秒的时间戳
        /// </summary>
        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// 颁奖词，最多可以填50字
        /// </summary>
        [NameInMap("grantReason")]
        [Validation(Required=false)]
        public string GrantReason { get; set; }

        /// <summary>
        /// 颁奖人名字，最多15个字
        /// </summary>
        [NameInMap("granterName")]
        [Validation(Required=false)]
        public string GranterName { get; set; }

        /// <summary>
        /// 是否使用官宣号发送内网动态
        /// </summary>
        [NameInMap("noticeAnnouncer")]
        [Validation(Required=false)]
        public bool? NoticeAnnouncer { get; set; }

        /// <summary>
        /// 是否触达单聊会话通知
        /// </summary>
        [NameInMap("noticeSingle")]
        [Validation(Required=false)]
        public bool? NoticeSingle { get; set; }

        /// <summary>
        /// 接受人userId
        /// </summary>
        [NameInMap("receiverUserIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIds { get; set; }

        /// <summary>
        /// 发送人userId
        /// </summary>
        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

    }

}

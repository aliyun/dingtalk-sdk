// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbadge_1_0.Models
{
    public class CreateBadgeNotifyRequest : TeaModel {
        /// <summary>
        /// 通知内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [NameInMap("msgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [NameInMap("msgType")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

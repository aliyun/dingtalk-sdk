// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class PushBadgeRequest : TeaModel {
        /// <summary>
        /// 微应用agentId
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// 推送列表
        /// </summary>
        [NameInMap("badgeItems")]
        [Validation(Required=false)]
        public List<PushBadgeRequestBadgeItems> BadgeItems { get; set; }
        public class PushBadgeRequestBadgeItems : TeaModel {
            /// <summary>
            /// 推送的内容（目前仅限数字）
            /// </summary>
            [NameInMap("pushValue")]
            [Validation(Required=false)]
            public string PushValue { get; set; }

            /// <summary>
            /// 员工ID。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 推送类型
        /// </summary>
        [NameInMap("pushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

    }

}

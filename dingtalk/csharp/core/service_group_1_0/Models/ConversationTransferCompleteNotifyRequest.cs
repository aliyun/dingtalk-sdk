// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ConversationTransferCompleteNotifyRequest : TeaModel {
        /// <summary>
        /// 小二2088id
        /// </summary>
        [NameInMap("alipayUserId")]
        [Validation(Required=false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// DT端会话ID
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// 小二昵称
        /// </summary>
        [NameInMap("nickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// 开放团队id
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 对应外部渠道的会话ID
        /// </summary>
        [NameInMap("serviceToken")]
        [Validation(Required=false)]
        public string ServiceToken { get; set; }

        /// <summary>
        /// 小二id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// DT端定义的，标识唯一的访
        /// </summary>
        [NameInMap("visitorToken")]
        [Validation(Required=false)]
        public string VisitorToken { get; set; }

    }

}

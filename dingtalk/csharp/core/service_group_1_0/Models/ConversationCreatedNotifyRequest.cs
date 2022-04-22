// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ConversationCreatedNotifyRequest : TeaModel {
        /// <summary>
        /// 小二客服2088
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
        /// 小二客服昵称
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
        /// 客服名称
        /// </summary>
        [NameInMap("serverName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

        /// <summary>
        /// 客服服务提示
        /// </summary>
        [NameInMap("serverTips")]
        [Validation(Required=false)]
        public string ServerTips { get; set; }

        [NameInMap("serviceToken")]
        [Validation(Required=false)]
        public string ServiceToken { get; set; }

        /// <summary>
        /// 超时规则提示
        /// </summary>
        [NameInMap("timeoutRemindTips")]
        [Validation(Required=false)]
        public string TimeoutRemindTips { get; set; }

        /// <summary>
        /// 小二客服id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// DT端定义的，标识唯一的访客
        /// </summary>
        [NameInMap("visitorToken")]
        [Validation(Required=false)]
        public string VisitorToken { get; set; }

    }

}

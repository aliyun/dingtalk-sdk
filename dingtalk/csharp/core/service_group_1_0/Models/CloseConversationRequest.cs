// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CloseConversationRequest : TeaModel {
        /// <summary>
        /// DT端会话ID
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 客户信息
        /// </summary>
        [NameInMap("serverTips")]
        [Validation(Required=false)]
        public string ServerTips { get; set; }

        /// <summary>
        /// 对应外部渠道的会话ID
        /// </summary>
        [NameInMap("serviceToken")]
        [Validation(Required=false)]
        public string ServiceToken { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [NameInMap("targetChannel")]
        [Validation(Required=false)]
        public string TargetChannel { get; set; }

        /// <summary>
        /// DT端定义的
        /// </summary>
        [NameInMap("visitorToken")]
        [Validation(Required=false)]
        public string VisitorToken { get; set; }

    }

}

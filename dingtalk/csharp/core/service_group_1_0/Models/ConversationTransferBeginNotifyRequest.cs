// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ConversationTransferBeginNotifyRequest : TeaModel {
        /// <summary>
        /// DT端会话ID
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// 转接备注
        /// </summary>
        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// 团队ID
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
        /// 原始技能组ID
        /// </summary>
        [NameInMap("sourceSkillGroupId")]
        [Validation(Required=false)]
        public string SourceSkillGroupId { get; set; }

        /// <summary>
        /// 目标技能组ID
        /// </summary>
        [NameInMap("targetSkillGroupId")]
        [Validation(Required=false)]
        public string TargetSkillGroupId { get; set; }

    }

}

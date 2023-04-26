// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ConversationTransferBeginNotifyRequest : TeaModel {
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("serviceToken")]
        [Validation(Required=false)]
        public string ServiceToken { get; set; }

        [NameInMap("sourceSkillGroupId")]
        [Validation(Required=false)]
        public string SourceSkillGroupId { get; set; }

        [NameInMap("targetSkillGroupId")]
        [Validation(Required=false)]
        public string TargetSkillGroupId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalSendMessageRequest : TeaModel {
        [NameInMap("mobileUrl")]
        [Validation(Required=false)]
        public string MobileUrl { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("pcUrl")]
        [Validation(Required=false)]
        public string PcUrl { get; set; }

        [NameInMap("sourceDingUserId")]
        [Validation(Required=false)]
        public string SourceDingUserId { get; set; }

        [NameInMap("targetDingUserIds")]
        [Validation(Required=false)]
        public List<string> TargetDingUserIds { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}

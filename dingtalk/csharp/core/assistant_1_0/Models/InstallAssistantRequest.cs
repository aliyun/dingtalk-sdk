// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class InstallAssistantRequest : TeaModel {
        [NameInMap("assistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        [NameInMap("isAllOrgMemberVisible")]
        [Validation(Required=false)]
        public bool? IsAllOrgMemberVisible { get; set; }

    }

}

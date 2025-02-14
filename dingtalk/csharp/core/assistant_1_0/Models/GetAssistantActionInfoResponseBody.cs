// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class GetAssistantActionInfoResponseBody : TeaModel {
        [NameInMap("actionList")]
        [Validation(Required=false)]
        public List<GetAssistantActionInfoResponseBodyActionList> ActionList { get; set; }
        public class GetAssistantActionInfoResponseBodyActionList : TeaModel {
            [NameInMap("actionId")]
            [Validation(Required=false)]
            public string ActionId { get; set; }

            [NameInMap("actionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            [NameInMap("actionVersion")]
            [Validation(Required=false)]
            public string ActionVersion { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

        }

        [NameInMap("assistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}

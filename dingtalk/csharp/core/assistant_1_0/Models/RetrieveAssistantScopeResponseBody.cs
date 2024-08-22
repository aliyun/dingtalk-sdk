// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class RetrieveAssistantScopeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public RetrieveAssistantScopeResponseBodyResult Result { get; set; }
        public class RetrieveAssistantScopeResponseBodyResult : TeaModel {
            [NameInMap("assistantId")]
            [Validation(Required=false)]
            public string AssistantId { get; set; }

            [NameInMap("scopes")]
            [Validation(Required=false)]
            public RetrieveAssistantScopeResponseBodyResultScopes Scopes { get; set; }
            public class RetrieveAssistantScopeResponseBodyResultScopes : TeaModel {
                [NameInMap("deptVisibleScopes")]
                [Validation(Required=false)]
                public List<string> DeptVisibleScopes { get; set; }

                [NameInMap("dynamicGroupScopes")]
                [Validation(Required=false)]
                public List<string> DynamicGroupScopes { get; set; }

                [NameInMap("isAdmin")]
                [Validation(Required=false)]
                public bool? IsAdmin { get; set; }

                [NameInMap("roleVisibleScopes")]
                [Validation(Required=false)]
                public List<string> RoleVisibleScopes { get; set; }

                [NameInMap("userVisibleScopes")]
                [Validation(Required=false)]
                public List<string> UserVisibleScopes { get; set; }

            }

            [NameInMap("sharing")]
            [Validation(Required=false)]
            public bool? Sharing { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

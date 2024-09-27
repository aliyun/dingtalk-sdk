// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class UpdateAssistantScopeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("assistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

        [NameInMap("scopes")]
        [Validation(Required=false)]
        public UpdateAssistantScopeRequestScopes Scopes { get; set; }
        public class UpdateAssistantScopeRequestScopes : TeaModel {
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

}

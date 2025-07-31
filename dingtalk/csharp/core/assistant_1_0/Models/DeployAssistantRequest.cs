// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class DeployAssistantRequest : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public DeployAssistantRequestAction Action { get; set; }
        public class DeployAssistantRequestAction : TeaModel {
            [NameInMap("actionAuthInfo")]
            [Validation(Required=false)]
            public DeployAssistantRequestActionActionAuthInfo ActionAuthInfo { get; set; }
            public class DeployAssistantRequestActionActionAuthInfo : TeaModel {
                [NameInMap("authConfig")]
                [Validation(Required=false)]
                public string AuthConfig { get; set; }

                [NameInMap("authenticationType")]
                [Validation(Required=false)]
                public string AuthenticationType { get; set; }

            }

            [NameInMap("actionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

        }

        [NameInMap("aiAssistantId")]
        [Validation(Required=false)]
        public string AiAssistantId { get; set; }

        [NameInMap("appScopes")]
        [Validation(Required=false)]
        public DeployAssistantRequestAppScopes AppScopes { get; set; }
        public class DeployAssistantRequestAppScopes : TeaModel {
            [NameInMap("deptVisibleScopes")]
            [Validation(Required=false)]
            public string DeptVisibleScopes { get; set; }

            [NameInMap("dynamicGroupScopes")]
            [Validation(Required=false)]
            public string DynamicGroupScopes { get; set; }

            [NameInMap("isHidden")]
            [Validation(Required=false)]
            public bool? IsHidden { get; set; }

            [NameInMap("roleVisibleScopes")]
            [Validation(Required=false)]
            public string RoleVisibleScopes { get; set; }

            [NameInMap("userVisibleScopes")]
            [Validation(Required=false)]
            public string UserVisibleScopes { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("fallback")]
        [Validation(Required=false)]
        public DeployAssistantRequestFallback Fallback { get; set; }
        public class DeployAssistantRequestFallback : TeaModel {
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("defaultMsg")]
            [Validation(Required=false)]
            public string DefaultMsg { get; set; }

        }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        [NameInMap("isPublic")]
        [Validation(Required=false)]
        public int? IsPublic { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        [NameInMap("recommendPrompts")]
        [Validation(Required=false)]
        public List<string> RecommendPrompts { get; set; }

        [NameInMap("shareRecipient")]
        [Validation(Required=false)]
        public string ShareRecipient { get; set; }

        [NameInMap("toneStyle")]
        [Validation(Required=false)]
        public string ToneStyle { get; set; }

        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        [NameInMap("welcomeContent")]
        [Validation(Required=false)]
        public string WelcomeContent { get; set; }

        [NameInMap("welcomeTitle")]
        [Validation(Required=false)]
        public string WelcomeTitle { get; set; }

    }

}

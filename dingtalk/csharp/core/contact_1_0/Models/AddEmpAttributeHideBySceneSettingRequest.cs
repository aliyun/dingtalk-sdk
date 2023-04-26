// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class AddEmpAttributeHideBySceneSettingRequest : TeaModel {
        [NameInMap("chatSubtitleConfig")]
        [Validation(Required=false)]
        public AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig ChatSubtitleConfig { get; set; }
        public class AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("excludeDeptIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeDeptIds { get; set; }

        [NameInMap("excludeTagIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeTagIds { get; set; }

        [NameInMap("excludeUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeUserIds { get; set; }

        [NameInMap("hideFields")]
        [Validation(Required=false)]
        public List<string> HideFields { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("objectDeptIds")]
        [Validation(Required=false)]
        public List<long?> ObjectDeptIds { get; set; }

        [NameInMap("objectTagIds")]
        [Validation(Required=false)]
        public List<long?> ObjectTagIds { get; set; }

        [NameInMap("objectUserIds")]
        [Validation(Required=false)]
        public List<string> ObjectUserIds { get; set; }

        [NameInMap("profileSceneConfig")]
        [Validation(Required=false)]
        public AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig ProfileSceneConfig { get; set; }
        public class AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

        [NameInMap("searchSceneConfig")]
        [Validation(Required=false)]
        public AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig SearchSceneConfig { get; set; }
        public class AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

    }

}

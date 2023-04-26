// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetContactHideBySceneSettingResponseBody : TeaModel {
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

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nodeListSceneConfig")]
        [Validation(Required=false)]
        public GetContactHideBySceneSettingResponseBodyNodeListSceneConfig NodeListSceneConfig { get; set; }
        public class GetContactHideBySceneSettingResponseBodyNodeListSceneConfig : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("deptObjectIncludeEmp")]
            [Validation(Required=false)]
            public bool? DeptObjectIncludeEmp { get; set; }

        }

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
        public GetContactHideBySceneSettingResponseBodyProfileSceneConfig ProfileSceneConfig { get; set; }
        public class GetContactHideBySceneSettingResponseBodyProfileSceneConfig : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

        [NameInMap("searchSceneConfig")]
        [Validation(Required=false)]
        public GetContactHideBySceneSettingResponseBodySearchSceneConfig SearchSceneConfig { get; set; }
        public class GetContactHideBySceneSettingResponseBodySearchSceneConfig : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("deptObjectIncludeEmp")]
            [Validation(Required=false)]
            public bool? DeptObjectIncludeEmp { get; set; }

        }

    }

}

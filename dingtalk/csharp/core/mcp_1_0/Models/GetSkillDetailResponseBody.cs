// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmcp_1_0.Models
{
    public class GetSkillDetailResponseBody : TeaModel {
        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<GetSkillDetailResponseBodyCategories> Categories { get; set; }
        public class GetSkillDetailResponseBodyCategories : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        [NameInMap("dependencies")]
        [Validation(Required=false)]
        public List<GetSkillDetailResponseBodyDependencies> Dependencies { get; set; }
        public class GetSkillDetailResponseBodyDependencies : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("refId")]
            [Validation(Required=false)]
            public string RefId { get; set; }

            [NameInMap("required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public string DetailUrl { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("packageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        [NameInMap("skillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

    }

}

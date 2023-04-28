// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class TeamVO : TeaModel {
        [NameInMap("cover")]
        [Validation(Required=false)]
        public string Cover { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public TeamVOCreator Creator { get; set; }
        public class TeamVOCreator : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("relatedDeptInfo")]
        [Validation(Required=false)]
        public TeamVORelatedDeptInfo RelatedDeptInfo { get; set; }
        public class TeamVORelatedDeptInfo : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

        }

        [NameInMap("shareScopeInfo")]
        [Validation(Required=false)]
        public TeamVOShareScopeInfo ShareScopeInfo { get; set; }
        public class TeamVOShareScopeInfo : TeaModel {
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public int? Scope { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("updatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

        [NameInMap("updater")]
        [Validation(Required=false)]
        public TeamVOUpdater Updater { get; set; }
        public class TeamVOUpdater : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("visitInfo")]
        [Validation(Required=false)]
        public TeamVOVisitInfo VisitInfo { get; set; }
        public class TeamVOVisitInfo : TeaModel {
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

        }

    }

}

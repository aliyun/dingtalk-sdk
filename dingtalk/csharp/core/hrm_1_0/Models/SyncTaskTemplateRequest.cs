// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class SyncTaskTemplateRequest : TeaModel {
        [NameInMap("delete")]
        [Validation(Required=false)]
        public bool? Delete { get; set; }

        [NameInMap("des")]
        [Validation(Required=false)]
        public string Des { get; set; }

        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        [NameInMap("outerId")]
        [Validation(Required=false)]
        public string OuterId { get; set; }

        [NameInMap("taskScopeVO")]
        [Validation(Required=false)]
        public SyncTaskTemplateRequestTaskScopeVO TaskScopeVO { get; set; }
        public class SyncTaskTemplateRequestTaskScopeVO : TeaModel {
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            [NameInMap("positionIds")]
            [Validation(Required=false)]
            public List<string> PositionIds { get; set; }

            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<string> RoleIds { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("solutionType")]
        [Validation(Required=false)]
        public string SolutionType { get; set; }

    }

}

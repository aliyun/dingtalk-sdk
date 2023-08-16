// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CrossOrgMigrateRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public CrossOrgMigrateRequestOption Option { get; set; }
        public class CrossOrgMigrateRequestOption : TeaModel {
            [NameInMap("checkOperatorSourceRole")]
            [Validation(Required=false)]
            public bool? CheckOperatorSourceRole { get; set; }

            [NameInMap("deleteSource")]
            [Validation(Required=false)]
            public bool? DeleteSource { get; set; }

            [NameInMap("needRecycleFailedWorkspaceId")]
            [Validation(Required=false)]
            public bool? NeedRecycleFailedWorkspaceId { get; set; }

            [NameInMap("relateTeamId")]
            [Validation(Required=false)]
            public long? RelateTeamId { get; set; }

            [NameInMap("relateTeamIdStr")]
            [Validation(Required=false)]
            public string RelateTeamIdStr { get; set; }

            [NameInMap("retainOrgGroup")]
            [Validation(Required=false)]
            public bool? RetainOrgGroup { get; set; }

            [NameInMap("skipRole")]
            [Validation(Required=false)]
            public bool? SkipRole { get; set; }

            [NameInMap("workspaceIdStrs")]
            [Validation(Required=false)]
            public List<string> WorkspaceIdStrs { get; set; }

            [NameInMap("workspaceIds")]
            [Validation(Required=false)]
            public List<long?> WorkspaceIds { get; set; }

        }

        [NameInMap("param")]
        [Validation(Required=false)]
        public CrossOrgMigrateRequestParam Param { get; set; }
        public class CrossOrgMigrateRequestParam : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

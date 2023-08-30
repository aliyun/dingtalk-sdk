// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class BatchCreateTeamRequest : TeaModel {
        [NameInMap("param")]
        [Validation(Required=false)]
        public BatchCreateTeamRequestParam Param { get; set; }
        public class BatchCreateTeamRequestParam : TeaModel {
            [NameInMap("createTeamParamList")]
            [Validation(Required=false)]
            public List<BatchCreateTeamRequestParamCreateTeamParamList> CreateTeamParamList { get; set; }
            public class BatchCreateTeamRequestParamCreateTeamParamList : TeaModel {
                [NameInMap("adminUnionIdList")]
                [Validation(Required=false)]
                public List<string> AdminUnionIdList { get; set; }

                [NameInMap("creatorUnionId")]
                [Validation(Required=false)]
                public string CreatorUnionId { get; set; }

                [NameInMap("deptId")]
                [Validation(Required=false)]
                public string DeptId { get; set; }

                [NameInMap("teamName")]
                [Validation(Required=false)]
                public string TeamName { get; set; }

            }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

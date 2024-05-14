// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class BatchCreateTeamRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public BatchCreateTeamRequestParam Param { get; set; }
        public class BatchCreateTeamRequestParam : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("createTeamParamList")]
            [Validation(Required=false)]
            public List<BatchCreateTeamRequestParamCreateTeamParamList> CreateTeamParamList { get; set; }
            public class BatchCreateTeamRequestParamCreateTeamParamList : TeaModel {
                [NameInMap("adminUnionIdList")]
                [Validation(Required=false)]
                public List<string> AdminUnionIdList { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("creatorUnionId")]
                [Validation(Required=false)]
                public string CreatorUnionId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public string DeptId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("teamName")]
                [Validation(Required=false)]
                public string TeamName { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

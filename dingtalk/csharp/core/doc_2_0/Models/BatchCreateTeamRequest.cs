// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class BatchCreateTeamRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public BatchCreateTeamRequestParam Param { get; set; }
        public class BatchCreateTeamRequestParam : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("createTeamParamList")]
            [Validation(Required=false)]
            public List<BatchCreateTeamRequestParamCreateTeamParamList> CreateTeamParamList { get; set; }
            public class BatchCreateTeamRequestParamCreateTeamParamList : TeaModel {
                [NameInMap("adminUnionIdList")]
                [Validation(Required=false)]
                public List<string> AdminUnionIdList { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>creator_union_id</para>
                /// </summary>
                [NameInMap("creatorUnionId")]
                [Validation(Required=false)]
                public string CreatorUnionId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dept_id</para>
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public string DeptId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>team_name</para>
                /// </summary>
                [NameInMap("teamName")]
                [Validation(Required=false)]
                public string TeamName { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

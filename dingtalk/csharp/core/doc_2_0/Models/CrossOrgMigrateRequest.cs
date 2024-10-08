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
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("checkOperatorSourceRole")]
            [Validation(Required=false)]
            public bool? CheckOperatorSourceRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("deleteSource")]
            [Validation(Required=false)]
            public bool? DeleteSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("needRecycleFailedWorkspaceId")]
            [Validation(Required=false)]
            public bool? NeedRecycleFailedWorkspaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1L</para>
            /// </summary>
            [NameInMap("relateTeamId")]
            [Validation(Required=false)]
            public long? RelateTeamId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_id</para>
            /// </summary>
            [NameInMap("relateTeamIdStr")]
            [Validation(Required=false)]
            public string RelateTeamIdStr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("retainOrgGroup")]
            [Validation(Required=false)]
            public bool? RetainOrgGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public CrossOrgMigrateRequestParam Param { get; set; }
        public class CrossOrgMigrateRequestParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>corp_id</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

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

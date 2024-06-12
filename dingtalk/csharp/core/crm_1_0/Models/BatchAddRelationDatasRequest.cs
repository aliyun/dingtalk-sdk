// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchAddRelationDatasRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("relationList")]
        [Validation(Required=false)]
        public List<BatchAddRelationDatasRequestRelationList> RelationList { get; set; }
        public class BatchAddRelationDatasRequestRelationList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<BatchAddRelationDatasRequestRelationListBizDataList> BizDataList { get; set; }
            public class BatchAddRelationDatasRequestRelationListBizDataList : TeaModel {
                [NameInMap("extendValue")]
                [Validation(Required=false)]
                public string ExtendValue { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("bizExtMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> BizExtMap { get; set; }

            [NameInMap("relationPermissionDTO")]
            [Validation(Required=false)]
            public BatchAddRelationDatasRequestRelationListRelationPermissionDTO RelationPermissionDTO { get; set; }
            public class BatchAddRelationDatasRequestRelationListRelationPermissionDTO : TeaModel {
                [NameInMap("participantUserIds")]
                [Validation(Required=false)]
                public List<string> ParticipantUserIds { get; set; }

                [NameInMap("principalUserIds")]
                [Validation(Required=false)]
                public List<string> PrincipalUserIds { get; set; }

            }

            [NameInMap("sourceDataId")]
            [Validation(Required=false)]
            public string SourceDataId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        [NameInMap("skipDuplicateCheck")]
        [Validation(Required=false)]
        public bool? SkipDuplicateCheck { get; set; }

    }

}

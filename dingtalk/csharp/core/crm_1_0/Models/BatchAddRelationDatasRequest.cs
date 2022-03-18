// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchAddRelationDatasRequest : TeaModel {
        /// <summary>
        /// 操作人userId
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// 关系数据列表。
        /// </summary>
        [NameInMap("relationList")]
        [Validation(Required=false)]
        public List<BatchAddRelationDatasRequestRelationList> RelationList { get; set; }
        public class BatchAddRelationDatasRequestRelationList : TeaModel {
            /// <summary>
            /// 关系模型数据。
            /// </summary>
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<BatchAddRelationDatasRequestRelationListBizDataList> BizDataList { get; set; }
            public class BatchAddRelationDatasRequestRelationListBizDataList : TeaModel {
                /// <summary>
                /// 模型字段extendValue。
                /// </summary>
                [NameInMap("extendValue")]
                [Validation(Required=false)]
                public string ExtendValue { get; set; }

                /// <summary>
                /// 模型字段id。
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 模型字段value。
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 扩展业务字段。
            /// </summary>
            [NameInMap("bizExtMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> BizExtMap { get; set; }

            /// <summary>
            /// 负责人、协同人信息。
            /// </summary>
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
            };

        }

        /// <summary>
        /// 关系类型。
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// 是否跳过查重，默认不跳过。
        /// </summary>
        [NameInMap("skipDuplicateCheck")]
        [Validation(Required=false)]
        public bool? SkipDuplicateCheck { get; set; }

    }

}

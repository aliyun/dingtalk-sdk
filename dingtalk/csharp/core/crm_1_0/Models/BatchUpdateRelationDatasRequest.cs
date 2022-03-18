// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchUpdateRelationDatasRequest : TeaModel {
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
        public List<BatchUpdateRelationDatasRequestRelationList> RelationList { get; set; }
        public class BatchUpdateRelationDatasRequestRelationList : TeaModel {
            /// <summary>
            /// 关系模型数据。
            /// </summary>
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<BatchUpdateRelationDatasRequestRelationListBizDataList> BizDataList { get; set; }
            public class BatchUpdateRelationDatasRequestRelationListBizDataList : TeaModel {
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
            /// 关系id
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

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

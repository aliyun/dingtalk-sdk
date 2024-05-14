// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchUpdateRelationDatasRequest : TeaModel {
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
        public List<BatchUpdateRelationDatasRequestRelationList> RelationList { get; set; }
        public class BatchUpdateRelationDatasRequestRelationList : TeaModel {
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<BatchUpdateRelationDatasRequestRelationListBizDataList> BizDataList { get; set; }
            public class BatchUpdateRelationDatasRequestRelationListBizDataList : TeaModel {
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

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

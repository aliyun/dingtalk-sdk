// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryRelationDatasByTargetIdResponseBody : TeaModel {
        /// <summary>
        /// 关系数据。
        /// </summary>
        [NameInMap("relations")]
        [Validation(Required=false)]
        public List<QueryRelationDatasByTargetIdResponseBodyRelations> Relations { get; set; }
        public class QueryRelationDatasByTargetIdResponseBodyRelations : TeaModel {
            /// <summary>
            /// 关系模型。
            /// </summary>
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList> BizDataList { get; set; }
            public class QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList : TeaModel {
                /// <summary>
                /// 关系模型数据字段扩展值。
                /// </summary>
                [NameInMap("extendValue")]
                [Validation(Required=false)]
                public string ExtendValue { get; set; }

                /// <summary>
                /// 关系模型数据字段名。
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 关系模型数据字段值。
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 关系所在的群ID，加密形式。
            /// </summary>
            [NameInMap("openConversationIds")]
            [Validation(Required=false)]
            public List<string> OpenConversationIds { get; set; }

            /// <summary>
            /// 关系实例ID。
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

            /// <summary>
            /// 关系类型。
            /// </summary>
            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

        }

    }

}

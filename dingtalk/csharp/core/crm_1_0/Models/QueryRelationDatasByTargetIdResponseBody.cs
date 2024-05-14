// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryRelationDatasByTargetIdResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("relations")]
        [Validation(Required=false)]
        public List<QueryRelationDatasByTargetIdResponseBodyRelations> Relations { get; set; }
        public class QueryRelationDatasByTargetIdResponseBodyRelations : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList> BizDataList { get; set; }
            public class QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("openConversationIds")]
            [Validation(Required=false)]
            public List<string> OpenConversationIds { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

        }

    }

}

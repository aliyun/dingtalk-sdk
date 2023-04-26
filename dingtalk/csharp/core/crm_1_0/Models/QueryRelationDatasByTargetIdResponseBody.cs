// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryRelationDatasByTargetIdResponseBody : TeaModel {
        [NameInMap("relations")]
        [Validation(Required=false)]
        public List<QueryRelationDatasByTargetIdResponseBodyRelations> Relations { get; set; }
        public class QueryRelationDatasByTargetIdResponseBodyRelations : TeaModel {
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList> BizDataList { get; set; }
            public class QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList : TeaModel {
                [NameInMap("extendValue")]
                [Validation(Required=false)]
                public string ExtendValue { get; set; }

                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("openConversationIds")]
            [Validation(Required=false)]
            public List<string> OpenConversationIds { get; set; }

            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

        }

    }

}

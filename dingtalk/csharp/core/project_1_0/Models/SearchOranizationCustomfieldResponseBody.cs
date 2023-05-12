// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchOranizationCustomfieldResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchOranizationCustomfieldResponseBodyResult> Result { get; set; }
        public class SearchOranizationCustomfieldResponseBodyResult : TeaModel {
            [NameInMap("advancedCustomField")]
            [Validation(Required=false)]
            public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField AdvancedCustomField { get; set; }
            public class SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField : TeaModel {
                [NameInMap("advancedCustomFieldId")]
                [Validation(Required=false)]
                public string AdvancedCustomFieldId { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

            }

            [NameInMap("choices")]
            [Validation(Required=false)]
            public List<SearchOranizationCustomfieldResponseBodyResultChoices> Choices { get; set; }
            public class SearchOranizationCustomfieldResponseBodyResultChoices : TeaModel {
                [NameInMap("choiceId")]
                [Validation(Required=false)]
                public string ChoiceId { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("customFieldsId")]
            [Validation(Required=false)]
            public string CustomFieldsId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("payload")]
            [Validation(Required=false)]
            public Dictionary<string, object> Payload { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}

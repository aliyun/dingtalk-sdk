// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchProjectCustomfieldResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchProjectCustomfieldResponseBodyResult> Result { get; set; }
        public class SearchProjectCustomfieldResponseBodyResult : TeaModel {
            [NameInMap("advancedCustomField")]
            [Validation(Required=false)]
            public SearchProjectCustomfieldResponseBodyResultAdvancedCustomField AdvancedCustomField { get; set; }
            public class SearchProjectCustomfieldResponseBodyResultAdvancedCustomField : TeaModel {
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

            [NameInMap("boundToObjectId")]
            [Validation(Required=false)]
            public string BoundToObjectId { get; set; }

            [NameInMap("choices")]
            [Validation(Required=false)]
            public List<SearchProjectCustomfieldResponseBodyResultChoices> Choices { get; set; }
            public class SearchProjectCustomfieldResponseBodyResultChoices : TeaModel {
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

            [NameInMap("customFieldId")]
            [Validation(Required=false)]
            public string CustomFieldId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("originalId")]
            [Validation(Required=false)]
            public string OriginalId { get; set; }

            [NameInMap("payload")]
            [Validation(Required=false)]
            public Dictionary<string, object> Payload { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}

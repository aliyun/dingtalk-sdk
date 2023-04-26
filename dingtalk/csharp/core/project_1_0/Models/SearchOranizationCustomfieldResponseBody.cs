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
            [NameInMap("advancedCustomfield")]
            [Validation(Required=false)]
            public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield AdvancedCustomfield { get; set; }
            public class SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield : TeaModel {
                [NameInMap("advancedCustomfieldId")]
                [Validation(Required=false)]
                public string AdvancedCustomfieldId { get; set; }

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

            [NameInMap("customfieldsId")]
            [Validation(Required=false)]
            public string CustomfieldsId { get; set; }

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

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

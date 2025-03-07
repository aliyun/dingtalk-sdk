// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class ExclusiveModelCompleteServiceResponseBody : TeaModel {
        [NameInMap("choices")]
        [Validation(Required=false)]
        public List<ExclusiveModelCompleteServiceResponseBodyChoices> Choices { get; set; }
        public class ExclusiveModelCompleteServiceResponseBodyChoices : TeaModel {
            [NameInMap("finishReason")]
            [Validation(Required=false)]
            public string FinishReason { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public ExclusiveModelCompleteServiceResponseBodyChoicesMessage Message { get; set; }
            public class ExclusiveModelCompleteServiceResponseBodyChoicesMessage : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("reasoning_content")]
                [Validation(Required=false)]
                public string ReasoningContent { get; set; }

                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

        }

        [NameInMap("created")]
        [Validation(Required=false)]
        public int? Created { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public ExclusiveModelCompleteServiceResponseBodyUsage Usage { get; set; }
        public class ExclusiveModelCompleteServiceResponseBodyUsage : TeaModel {
            [NameInMap("input_tokens")]
            [Validation(Required=false)]
            public int? InputTokens { get; set; }

            [NameInMap("output_tokens")]
            [Validation(Required=false)]
            public int? OutputTokens { get; set; }

            [NameInMap("total_tokens")]
            [Validation(Required=false)]
            public int? TotalTokens { get; set; }

        }

    }

}

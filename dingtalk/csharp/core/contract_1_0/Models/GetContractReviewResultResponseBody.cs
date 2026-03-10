// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class GetContractReviewResultResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetContractReviewResultResponseBodyResult Result { get; set; }
        public class GetContractReviewResultResponseBodyResult : TeaModel {
            [NameInMap("annotations")]
            [Validation(Required=false)]
            public List<GetContractReviewResultResponseBodyResultAnnotations> Annotations { get; set; }
            public class GetContractReviewResultResponseBodyResultAnnotations : TeaModel {
                [NameInMap("commentTexts")]
                [Validation(Required=false)]
                public List<GetContractReviewResultResponseBodyResultAnnotationsCommentTexts> CommentTexts { get; set; }
                public class GetContractReviewResultResponseBodyResultAnnotationsCommentTexts : TeaModel {
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("riskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("originalText")]
                [Validation(Required=false)]
                public string OriginalText { get; set; }

                [NameInMap("paragraph")]
                [Validation(Required=false)]
                public string Paragraph { get; set; }

                [NameInMap("riskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public bool? Status { get; set; }

            }

            [NameInMap("clearWordPath")]
            [Validation(Required=false)]
            public string ClearWordPath { get; set; }

            [NameInMap("reviewType")]
            [Validation(Required=false)]
            public string ReviewType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public GetContractReviewResultResponseBodyResultSummary Summary { get; set; }
            public class GetContractReviewResultResponseBodyResultSummary : TeaModel {
                [NameInMap("riskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            [NameInMap("wordPath")]
            [Validation(Required=false)]
            public string WordPath { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

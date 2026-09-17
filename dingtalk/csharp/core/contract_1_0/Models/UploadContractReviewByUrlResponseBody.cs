// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class UploadContractReviewByUrlResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public UploadContractReviewByUrlResponseBodyData Data { get; set; }
        public class UploadContractReviewByUrlResponseBodyData : TeaModel {
            [NameInMap("overview_summary")]
            [Validation(Required=false)]
            public string OverviewSummary { get; set; }

            [NameInMap("recommendation_fallback")]
            [Validation(Required=false)]
            public bool? RecommendationFallback { get; set; }

            [NameInMap("recommended")]
            [Validation(Required=false)]
            public UploadContractReviewByUrlResponseBodyDataRecommended Recommended { get; set; }
            public class UploadContractReviewByUrlResponseBodyDataRecommended : TeaModel {
                [NameInMap("contract_type")]
                [Validation(Required=false)]
                public string ContractType { get; set; }

                [NameInMap("scale")]
                [Validation(Required=false)]
                public string Scale { get; set; }

                [NameInMap("standpoint")]
                [Validation(Required=false)]
                public string Standpoint { get; set; }

            }

            [NameInMap("review_id")]
            [Validation(Required=false)]
            public string ReviewId { get; set; }

            [NameInMap("weboffice")]
            [Validation(Required=false)]
            public UploadContractReviewByUrlResponseBodyDataWeboffice Weboffice { get; set; }
            public class UploadContractReviewByUrlResponseBodyDataWeboffice : TeaModel {
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class GetContractReviewStatusResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetContractReviewStatusResponseBodyData Data { get; set; }
        public class GetContractReviewStatusResponseBodyData : TeaModel {
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("progress_pct")]
            [Validation(Required=false)]
            public long? ProgressPct { get; set; }

            [NameInMap("review_id")]
            [Validation(Required=false)]
            public string ReviewId { get; set; }

            [NameInMap("risk_counts")]
            [Validation(Required=false)]
            public GetContractReviewStatusResponseBodyDataRiskCounts RiskCounts { get; set; }
            public class GetContractReviewStatusResponseBodyDataRiskCounts : TeaModel {
                [NameInMap("high")]
                [Validation(Required=false)]
                public long? High { get; set; }

                [NameInMap("low")]
                [Validation(Required=false)]
                public long? Low { get; set; }

                [NameInMap("medium")]
                [Validation(Required=false)]
                public long? Medium { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("top_risks")]
            [Validation(Required=false)]
            public List<GetContractReviewStatusResponseBodyDataTopRisks> TopRisks { get; set; }
            public class GetContractReviewStatusResponseBodyDataTopRisks : TeaModel {
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("weboffice_url")]
            [Validation(Required=false)]
            public string WebofficeUrl { get; set; }

        }

    }

}

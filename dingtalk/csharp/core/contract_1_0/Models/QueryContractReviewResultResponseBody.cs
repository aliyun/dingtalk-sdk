// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QueryContractReviewResultResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryContractReviewResultResponseBodyResult Result { get; set; }
        public class QueryContractReviewResultResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public QueryContractReviewResultResponseBodyResultData Data { get; set; }
            public class QueryContractReviewResultResponseBodyResultData : TeaModel {
                [NameInMap("reviewRiskDetail")]
                [Validation(Required=false)]
                public List<QueryContractReviewResultResponseBodyResultDataReviewRiskDetail> ReviewRiskDetail { get; set; }
                public class QueryContractReviewResultResponseBodyResultDataReviewRiskDetail : TeaModel {
                    [NameInMap("examineBrief")]
                    [Validation(Required=false)]
                    public string ExamineBrief { get; set; }

                    [NameInMap("examineResult")]
                    [Validation(Required=false)]
                    public string ExamineResult { get; set; }

                    [NameInMap("examineStatus")]
                    [Validation(Required=false)]
                    public string ExamineStatus { get; set; }

                    [NameInMap("riskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    [NameInMap("ruleSequence")]
                    [Validation(Required=false)]
                    public string RuleSequence { get; set; }

                    [NameInMap("ruleTag")]
                    [Validation(Required=false)]
                    public string RuleTag { get; set; }

                    [NameInMap("ruleTitle")]
                    [Validation(Required=false)]
                    public string RuleTitle { get; set; }

                    [NameInMap("subRisks")]
                    [Validation(Required=false)]
                    public List<QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks> SubRisks { get; set; }
                    public class QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks : TeaModel {
                        [NameInMap("originalContent")]
                        [Validation(Required=false)]
                        public string OriginalContent { get; set; }

                        [NameInMap("resultContent")]
                        [Validation(Required=false)]
                        public string ResultContent { get; set; }

                        [NameInMap("resultType")]
                        [Validation(Required=false)]
                        public string ResultType { get; set; }

                        [NameInMap("riskBrief")]
                        [Validation(Required=false)]
                        public string RiskBrief { get; set; }

                        [NameInMap("riskClause")]
                        [Validation(Required=false)]
                        public string RiskClause { get; set; }

                        [NameInMap("riskExplain")]
                        [Validation(Required=false)]
                        public string RiskExplain { get; set; }

                    }

                }

                [NameInMap("reviewRiskOverview")]
                [Validation(Required=false)]
                public QueryContractReviewResultResponseBodyResultDataReviewRiskOverview ReviewRiskOverview { get; set; }
                public class QueryContractReviewResultResponseBodyResultDataReviewRiskOverview : TeaModel {
                    [NameInMap("hasRisk")]
                    [Validation(Required=false)]
                    public bool? HasRisk { get; set; }

                    [NameInMap("highRisk")]
                    [Validation(Required=false)]
                    public int? HighRisk { get; set; }

                    [NameInMap("lowRisk")]
                    [Validation(Required=false)]
                    public int? LowRisk { get; set; }

                    [NameInMap("mediumRisk")]
                    [Validation(Required=false)]
                    public int? MediumRisk { get; set; }

                }

                [NameInMap("reviewStatus")]
                [Validation(Required=false)]
                public QueryContractReviewResultResponseBodyResultDataReviewStatus ReviewStatus { get; set; }
                public class QueryContractReviewResultResponseBodyResultDataReviewStatus : TeaModel {
                    [NameInMap("overview")]
                    [Validation(Required=false)]
                    public string Overview { get; set; }

                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    [NameInMap("rule")]
                    [Validation(Required=false)]
                    public string Rule { get; set; }

                    [NameInMap("stage")]
                    [Validation(Required=false)]
                    public string Stage { get; set; }

                }

            }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

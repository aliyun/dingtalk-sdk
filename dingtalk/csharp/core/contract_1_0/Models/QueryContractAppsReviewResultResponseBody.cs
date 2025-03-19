// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QueryContractAppsReviewResultResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryContractAppsReviewResultResponseBodyResult Result { get; set; }
        public class QueryContractAppsReviewResultResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public QueryContractAppsReviewResultResponseBodyResultData Data { get; set; }
            public class QueryContractAppsReviewResultResponseBodyResultData : TeaModel {
                [NameInMap("reviewRiskDetail")]
                [Validation(Required=false)]
                public List<QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail> ReviewRiskDetail { get; set; }
                public class QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail : TeaModel {
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
                    public List<QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks> SubRisks { get; set; }
                    public class QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks : TeaModel {
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
                public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview ReviewRiskOverview { get; set; }
                public class QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview : TeaModel {
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
                public QueryContractAppsReviewResultResponseBodyResultDataReviewStatus ReviewStatus { get; set; }
                public class QueryContractAppsReviewResultResponseBodyResultDataReviewStatus : TeaModel {
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

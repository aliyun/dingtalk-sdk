// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class GetContractReviewResultsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetContractReviewResultsResponseBodyData Data { get; set; }
        public class GetContractReviewResultsResponseBodyData : TeaModel {
            [NameInMap("annotated_export_url")]
            [Validation(Required=false)]
            public string AnnotatedExportUrl { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("report")]
            [Validation(Required=false)]
            public GetContractReviewResultsResponseBodyDataReport Report { get; set; }
            public class GetContractReviewResultsResponseBodyDataReport : TeaModel {
                [NameInMap("all_issues")]
                [Validation(Required=false)]
                public List<GetContractReviewResultsResponseBodyDataReportAllIssues> AllIssues { get; set; }
                public class GetContractReviewResultsResponseBodyDataReportAllIssues : TeaModel {
                    [NameInMap("builtin")]
                    [Validation(Required=false)]
                    public bool? Builtin { get; set; }

                    [NameInMap("check_type")]
                    [Validation(Required=false)]
                    public string CheckType { get; set; }

                    [NameInMap("clause_location")]
                    [Validation(Required=false)]
                    public string ClauseLocation { get; set; }

                    [NameInMap("clause_quote")]
                    [Validation(Required=false)]
                    public string ClauseQuote { get; set; }

                    [NameInMap("custom")]
                    [Validation(Required=false)]
                    public bool? Custom { get; set; }

                    [NameInMap("fallback")]
                    [Validation(Required=false)]
                    public string Fallback { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("impact")]
                    [Validation(Required=false)]
                    public string Impact { get; set; }

                    [NameInMap("legal_basis")]
                    [Validation(Required=false)]
                    public string LegalBasis { get; set; }

                    [NameInMap("pack")]
                    [Validation(Required=false)]
                    public string Pack { get; set; }

                    [NameInMap("practice_reference")]
                    [Validation(Required=false)]
                    public string PracticeReference { get; set; }

                    [NameInMap("problem")]
                    [Validation(Required=false)]
                    public string Problem { get; set; }

                    [NameInMap("revision_text")]
                    [Validation(Required=false)]
                    public string RevisionText { get; set; }

                    [NameInMap("riskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    [NameInMap("rule_name")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    [NameInMap("suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    [NameInMap("tier")]
                    [Validation(Required=false)]
                    public string Tier { get; set; }

                }

                [NameInMap("conclusion")]
                [Validation(Required=false)]
                public string Conclusion { get; set; }

                [NameInMap("cross_clause_findings")]
                [Validation(Required=false)]
                public List<string> CrossClauseFindings { get; set; }

                [NameInMap("deterministic_findings")]
                [Validation(Required=false)]
                public List<string> DeterministicFindings { get; set; }

                [NameInMap("file_name")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("generated_at")]
                [Validation(Required=false)]
                public string GeneratedAt { get; set; }

                [NameInMap("missing_clauses")]
                [Validation(Required=false)]
                public List<string> MissingClauses { get; set; }

                [NameInMap("review_id")]
                [Validation(Required=false)]
                public string ReviewId { get; set; }

                [NameInMap("risk_issues")]
                [Validation(Required=false)]
                public List<string> RiskIssues { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public GetContractReviewResultsResponseBodyDataReportSummary Summary { get; set; }
                public class GetContractReviewResultsResponseBodyDataReportSummary : TeaModel {
                    [NameInMap("contract_type")]
                    [Validation(Required=false)]
                    public string ContractType { get; set; }

                    [NameInMap("cross_clause_count")]
                    [Validation(Required=false)]
                    public long? CrossClauseCount { get; set; }

                    [NameInMap("deterministic_count")]
                    [Validation(Required=false)]
                    public long? DeterministicCount { get; set; }

                    [NameInMap("formal_hint_count")]
                    [Validation(Required=false)]
                    public long? FormalHintCount { get; set; }

                    [NameInMap("hard_issue_count")]
                    [Validation(Required=false)]
                    public long? HardIssueCount { get; set; }

                    [NameInMap("high")]
                    [Validation(Required=false)]
                    public long? High { get; set; }

                    [NameInMap("issue_count")]
                    [Validation(Required=false)]
                    public long? IssueCount { get; set; }

                    [NameInMap("low")]
                    [Validation(Required=false)]
                    public long? Low { get; set; }

                    [NameInMap("medium")]
                    [Validation(Required=false)]
                    public long? Medium { get; set; }

                    [NameInMap("missing_clause_count")]
                    [Validation(Required=false)]
                    public long? MissingClauseCount { get; set; }

                    [NameInMap("overall_risk_level")]
                    [Validation(Required=false)]
                    public string OverallRiskLevel { get; set; }

                    [NameInMap("risk_issue_count")]
                    [Validation(Required=false)]
                    public long? RiskIssueCount { get; set; }

                    [NameInMap("scale")]
                    [Validation(Required=false)]
                    public string Scale { get; set; }

                    [NameInMap("standpoint")]
                    [Validation(Required=false)]
                    public string Standpoint { get; set; }

                }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("report_export_url")]
            [Validation(Required=false)]
            public string ReportExportUrl { get; set; }

            [NameInMap("review_id")]
            [Validation(Required=false)]
            public string ReviewId { get; set; }

            [NameInMap("risk_counts")]
            [Validation(Required=false)]
            public GetContractReviewResultsResponseBodyDataRiskCounts RiskCounts { get; set; }
            public class GetContractReviewResultsResponseBodyDataRiskCounts : TeaModel {
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

            [NameInMap("total_risks")]
            [Validation(Required=false)]
            public long? TotalRisks { get; set; }

            [NameInMap("weboffice_url")]
            [Validation(Required=false)]
            public string WebofficeUrl { get; set; }

        }

    }

}

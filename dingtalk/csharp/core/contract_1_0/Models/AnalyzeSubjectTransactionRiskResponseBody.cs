// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class AnalyzeSubjectTransactionRiskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AnalyzeSubjectTransactionRiskResponseBodyResult Result { get; set; }
        public class AnalyzeSubjectTransactionRiskResponseBodyResult : TeaModel {
            [NameInMap("aiAnalysis")]
            [Validation(Required=false)]
            public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis AiAnalysis { get; set; }
            public class AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis : TeaModel {
                [NameInMap("keyRisks")]
                [Validation(Required=false)]
                public List<AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks> KeyRisks { get; set; }
                public class AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks : TeaModel {
                    [NameInMap("evidence")]
                    [Validation(Required=false)]
                    public string Evidence { get; set; }

                    [NameInMap("impact")]
                    [Validation(Required=false)]
                    public string Impact { get; set; }

                    [NameInMap("riskName")]
                    [Validation(Required=false)]
                    public string RiskName { get; set; }

                    [NameInMap("suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                [NameInMap("limitations")]
                [Validation(Required=false)]
                public List<string> Limitations { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            [NameInMap("currentContract")]
            [Validation(Required=false)]
            public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract CurrentContract { get; set; }
            public class AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract : TeaModel {
                [NameInMap("acceptanceTerms")]
                [Validation(Required=false)]
                public string AcceptanceTerms { get; set; }

                [NameInMap("breachLiability")]
                [Validation(Required=false)]
                public string BreachLiability { get; set; }

                [NameInMap("contractAmount")]
                [Validation(Required=false)]
                public string ContractAmount { get; set; }

                [NameInMap("contractId")]
                [Validation(Required=false)]
                public long? ContractId { get; set; }

                [NameInMap("contractName")]
                [Validation(Required=false)]
                public string ContractName { get; set; }

                [NameInMap("contractSubject")]
                [Validation(Required=false)]
                public string ContractSubject { get; set; }

                [NameInMap("contractType")]
                [Validation(Required=false)]
                public string ContractType { get; set; }

                [NameInMap("contractVersion")]
                [Validation(Required=false)]
                public long? ContractVersion { get; set; }

                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("dataStatus")]
                [Validation(Required=false)]
                public string DataStatus { get; set; }

                [NameInMap("deliveryTerms")]
                [Validation(Required=false)]
                public string DeliveryTerms { get; set; }

                [NameInMap("disputeResolution")]
                [Validation(Required=false)]
                public string DisputeResolution { get; set; }

                [NameInMap("guaranteeTerms")]
                [Validation(Required=false)]
                public string GuaranteeTerms { get; set; }

                [NameInMap("missingFields")]
                [Validation(Required=false)]
                public List<string> MissingFields { get; set; }

                [NameInMap("paymentTerms")]
                [Validation(Required=false)]
                public string PaymentTerms { get; set; }

                [NameInMap("performancePeriod")]
                [Validation(Required=false)]
                public string PerformancePeriod { get; set; }

                [NameInMap("terminationTerms")]
                [Validation(Required=false)]
                public string TerminationTerms { get; set; }

                [NameInMap("transactionDirection")]
                [Validation(Required=false)]
                public string TransactionDirection { get; set; }

            }

            [NameInMap("dataStatus")]
            [Validation(Required=false)]
            public string DataStatus { get; set; }

            [NameInMap("historyCooperation")]
            [Validation(Required=false)]
            public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation HistoryCooperation { get; set; }
            public class AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation : TeaModel {
                [NameInMap("expenseAmounts")]
                [Validation(Required=false)]
                public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts ExpenseAmounts { get; set; }
                public class AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts : TeaModel {
                    [NameInMap("cNY")]
                    [Validation(Required=false)]
                    public string CNY { get; set; }

                    [NameInMap("uSD")]
                    [Validation(Required=false)]
                    public string USD { get; set; }

                }

                [NameInMap("historyDataStatus")]
                [Validation(Required=false)]
                public string HistoryDataStatus { get; set; }

                [NameInMap("historyEndTime")]
                [Validation(Required=false)]
                public long? HistoryEndTime { get; set; }

                [NameInMap("historyStartTime")]
                [Validation(Required=false)]
                public long? HistoryStartTime { get; set; }

                [NameInMap("incomeAmounts")]
                [Validation(Required=false)]
                public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts IncomeAmounts { get; set; }
                public class AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts : TeaModel {
                    [NameInMap("cNY")]
                    [Validation(Required=false)]
                    public string CNY { get; set; }

                    [NameInMap("uSD")]
                    [Validation(Required=false)]
                    public string USD { get; set; }

                }

                [NameInMap("performanceAnomalies")]
                [Validation(Required=false)]
                public List<string> PerformanceAnomalies { get; set; }

                [NameInMap("performanceDataStatus")]
                [Validation(Required=false)]
                public string PerformanceDataStatus { get; set; }

                [NameInMap("periodContractCount")]
                [Validation(Required=false)]
                public long? PeriodContractCount { get; set; }

                [NameInMap("relatedContracts")]
                [Validation(Required=false)]
                public List<AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts> RelatedContracts { get; set; }
                public class AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts : TeaModel {
                    [NameInMap("contractAmount")]
                    [Validation(Required=false)]
                    public string ContractAmount { get; set; }

                    [NameInMap("contractId")]
                    [Validation(Required=false)]
                    public long? ContractId { get; set; }

                    [NameInMap("contractName")]
                    [Validation(Required=false)]
                    public string ContractName { get; set; }

                    [NameInMap("contractType")]
                    [Validation(Required=false)]
                    public string ContractType { get; set; }

                    [NameInMap("currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    [NameInMap("endDate")]
                    [Validation(Required=false)]
                    public long? EndDate { get; set; }

                    [NameInMap("startDate")]
                    [Validation(Required=false)]
                    public long? StartDate { get; set; }

                    [NameInMap("transactionDirection")]
                    [Validation(Required=false)]
                    public string TransactionDirection { get; set; }

                }

                [NameInMap("totalRelatedContractCount")]
                [Validation(Required=false)]
                public long? TotalRelatedContractCount { get; set; }

            }

            [NameInMap("subjectInfo")]
            [Validation(Required=false)]
            public AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo SubjectInfo { get; set; }
            public class AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo : TeaModel {
                [NameInMap("creditCode")]
                [Validation(Required=false)]
                public string CreditCode { get; set; }

                [NameInMap("relatedOwnSubjects")]
                [Validation(Required=false)]
                public List<string> RelatedOwnSubjects { get; set; }

                [NameInMap("subjectName")]
                [Validation(Required=false)]
                public string SubjectName { get; set; }

                [NameInMap("subjectTags")]
                [Validation(Required=false)]
                public List<string> SubjectTags { get; set; }

                [NameInMap("uniqueCode")]
                [Validation(Required=false)]
                public string UniqueCode { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

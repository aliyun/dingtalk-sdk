// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QuerySubjectPublicRiskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QuerySubjectPublicRiskResponseBodyResult Result { get; set; }
        public class QuerySubjectPublicRiskResponseBodyResult : TeaModel {
            [NameInMap("aiRiskSummary")]
            [Validation(Required=false)]
            public string AiRiskSummary { get; set; }

            [NameInMap("aiSampleRiskCount")]
            [Validation(Required=false)]
            public long? AiSampleRiskCount { get; set; }

            [NameInMap("aiSummaryStatus")]
            [Validation(Required=false)]
            public string AiSummaryStatus { get; set; }

            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("companyInfo")]
            [Validation(Required=false)]
            public QuerySubjectPublicRiskResponseBodyResultCompanyInfo CompanyInfo { get; set; }
            public class QuerySubjectPublicRiskResponseBodyResultCompanyInfo : TeaModel {
                [NameInMap("bankAccountName")]
                [Validation(Required=false)]
                public string BankAccountName { get; set; }

                [NameInMap("bankAccountNumber")]
                [Validation(Required=false)]
                public string BankAccountNumber { get; set; }

                [NameInMap("bankName")]
                [Validation(Required=false)]
                public string BankName { get; set; }

                [NameInMap("companyName")]
                [Validation(Required=false)]
                public string CompanyName { get; set; }

                [NameInMap("creditCode")]
                [Validation(Required=false)]
                public string CreditCode { get; set; }

                [NameInMap("legalPersonName")]
                [Validation(Required=false)]
                public string LegalPersonName { get; set; }

                [NameInMap("phoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("regLocation")]
                [Validation(Required=false)]
                public string RegLocation { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("taxNumber")]
                [Validation(Required=false)]
                public string TaxNumber { get; set; }

            }

            [NameInMap("dataStatus")]
            [Validation(Required=false)]
            public string DataStatus { get; set; }

            [NameInMap("dataUpdatedAt")]
            [Validation(Required=false)]
            public long? DataUpdatedAt { get; set; }

            [NameInMap("freeBenefitRestEnough")]
            [Validation(Required=false)]
            public bool? FreeBenefitRestEnough { get; set; }

            [NameInMap("riskTypes")]
            [Validation(Required=false)]
            public List<string> RiskTypes { get; set; }

            [NameInMap("risks")]
            [Validation(Required=false)]
            public QuerySubjectPublicRiskResponseBodyResultRisks Risks { get; set; }
            public class QuerySubjectPublicRiskResponseBodyResultRisks : TeaModel {
                [NameInMap("business_risk")]
                [Validation(Required=false)]
                public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk BusinessRisk { get; set; }
                public class QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk : TeaModel {
                    [NameInMap("riskName")]
                    [Validation(Required=false)]
                    public string RiskName { get; set; }

                    [NameInMap("riskNumber")]
                    [Validation(Required=false)]
                    public long? RiskNumber { get; set; }

                    [NameInMap("riskType")]
                    [Validation(Required=false)]
                    public string RiskType { get; set; }

                    [NameInMap("subRiskTypes")]
                    [Validation(Required=false)]
                    public List<string> SubRiskTypes { get; set; }

                    [NameInMap("subRisks")]
                    [Validation(Required=false)]
                    public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisks SubRisks { get; set; }
                    public class QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisks : TeaModel {
                        [NameInMap("administrative_punishment")]
                        [Validation(Required=false)]
                        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment AdministrativePunishment { get; set; }
                        public class QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment : TeaModel {
                            [NameInMap("columns")]
                            [Validation(Required=false)]
                            public List<QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns> Columns { get; set; }
                            public class QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns : TeaModel {
                                [NameInMap("columnName")]
                                [Validation(Required=false)]
                                public string ColumnName { get; set; }

                                [NameInMap("columnType")]
                                [Validation(Required=false)]
                                public string ColumnType { get; set; }

                                [NameInMap("isDate")]
                                [Validation(Required=false)]
                                public bool? IsDate { get; set; }

                            }

                            [NameInMap("items")]
                            [Validation(Required=false)]
                            public List<QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems> Items { get; set; }
                            public class QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems : TeaModel {
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                [NameInMap("decisionDate")]
                                [Validation(Required=false)]
                                public string DecisionDate { get; set; }

                                [NameInMap("departmentName")]
                                [Validation(Required=false)]
                                public string DepartmentName { get; set; }

                                [NameInMap("punishNumber")]
                                [Validation(Required=false)]
                                public string PunishNumber { get; set; }

                                [NameInMap("reason")]
                                [Validation(Required=false)]
                                public string Reason { get; set; }

                            }

                            [NameInMap("noticeText")]
                            [Validation(Required=false)]
                            public string NoticeText { get; set; }

                            [NameInMap("subRiskName")]
                            [Validation(Required=false)]
                            public string SubRiskName { get; set; }

                            [NameInMap("subRiskNumber")]
                            [Validation(Required=false)]
                            public long? SubRiskNumber { get; set; }

                            [NameInMap("subRiskType")]
                            [Validation(Required=false)]
                            public string SubRiskType { get; set; }

                        }

                    }

                }

                [NameInMap("justice_risk")]
                [Validation(Required=false)]
                public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk JusticeRisk { get; set; }
                public class QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk : TeaModel {
                    [NameInMap("riskName")]
                    [Validation(Required=false)]
                    public string RiskName { get; set; }

                    [NameInMap("riskNumber")]
                    [Validation(Required=false)]
                    public long? RiskNumber { get; set; }

                    [NameInMap("riskType")]
                    [Validation(Required=false)]
                    public string RiskType { get; set; }

                    [NameInMap("subRiskTypes")]
                    [Validation(Required=false)]
                    public List<string> SubRiskTypes { get; set; }

                    [NameInMap("subRisks")]
                    [Validation(Required=false)]
                    public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisks SubRisks { get; set; }
                    public class QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisks : TeaModel {
                        [NameInMap("court_opening_announcement")]
                        [Validation(Required=false)]
                        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement CourtOpeningAnnouncement { get; set; }
                        public class QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement : TeaModel {
                            [NameInMap("columns")]
                            [Validation(Required=false)]
                            public List<QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns> Columns { get; set; }
                            public class QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns : TeaModel {
                                [NameInMap("columnName")]
                                [Validation(Required=false)]
                                public string ColumnName { get; set; }

                                [NameInMap("columnType")]
                                [Validation(Required=false)]
                                public string ColumnType { get; set; }

                                [NameInMap("isDate")]
                                [Validation(Required=false)]
                                public bool? IsDate { get; set; }

                            }

                            [NameInMap("items")]
                            [Validation(Required=false)]
                            public List<QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems> Items { get; set; }
                            public class QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems : TeaModel {
                                [NameInMap("caseNo")]
                                [Validation(Required=false)]
                                public string CaseNo { get; set; }

                                [NameInMap("caseReason")]
                                [Validation(Required=false)]
                                public string CaseReason { get; set; }

                                [NameInMap("court")]
                                [Validation(Required=false)]
                                public string Court { get; set; }

                                [NameInMap("startDate")]
                                [Validation(Required=false)]
                                public string StartDate { get; set; }

                            }

                            [NameInMap("noticeText")]
                            [Validation(Required=false)]
                            public string NoticeText { get; set; }

                            [NameInMap("subRiskName")]
                            [Validation(Required=false)]
                            public string SubRiskName { get; set; }

                            [NameInMap("subRiskNumber")]
                            [Validation(Required=false)]
                            public long? SubRiskNumber { get; set; }

                            [NameInMap("subRiskType")]
                            [Validation(Required=false)]
                            public string SubRiskType { get; set; }

                        }

                    }

                }

            }

            [NameInMap("subjectExist")]
            [Validation(Required=false)]
            public bool? SubjectExist { get; set; }

            [NameInMap("totalRiskNumber")]
            [Validation(Required=false)]
            public long? TotalRiskNumber { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

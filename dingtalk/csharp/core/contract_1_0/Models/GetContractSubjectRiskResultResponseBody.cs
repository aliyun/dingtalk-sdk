// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class GetContractSubjectRiskResultResponseBody : TeaModel {
        [NameInMap("subjectRiskResponses")]
        [Validation(Required=false)]
        public List<GetContractSubjectRiskResultResponseBodySubjectRiskResponses> SubjectRiskResponses { get; set; }
        public class GetContractSubjectRiskResultResponseBodySubjectRiskResponses : TeaModel {
            [NameInMap("subjectBaseInfoResponse")]
            [Validation(Required=false)]
            public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse SubjectBaseInfoResponse { get; set; }
            public class GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse : TeaModel {
                [NameInMap("aboveScale")]
                [Validation(Required=false)]
                public string AboveScale { get; set; }

                [NameInMap("actualCapital")]
                [Validation(Required=false)]
                public string ActualCapital { get; set; }

                [NameInMap("actualCapitalCurrency")]
                [Validation(Required=false)]
                public string ActualCapitalCurrency { get; set; }

                [NameInMap("alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("approvedTime")]
                [Validation(Required=false)]
                public long? ApprovedTime { get; set; }

                [NameInMap("base")]
                [Validation(Required=false)]
                public string Base { get; set; }

                [NameInMap("benNumber")]
                [Validation(Required=false)]
                public string BenNumber { get; set; }

                [NameInMap("bondName")]
                [Validation(Required=false)]
                public string BondName { get; set; }

                [NameInMap("bondNum")]
                [Validation(Required=false)]
                public string BondNum { get; set; }

                [NameInMap("bondType")]
                [Validation(Required=false)]
                public string BondType { get; set; }

                [NameInMap("businessScope")]
                [Validation(Required=false)]
                public string BusinessScope { get; set; }

                [NameInMap("cancelDate")]
                [Validation(Required=false)]
                public long? CancelDate { get; set; }

                [NameInMap("cancelReason")]
                [Validation(Required=false)]
                public string CancelReason { get; set; }

                [NameInMap("city")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("companyOrgType")]
                [Validation(Required=false)]
                public string CompanyOrgType { get; set; }

                [NameInMap("creditCode")]
                [Validation(Required=false)]
                public string CreditCode { get; set; }

                [NameInMap("district")]
                [Validation(Required=false)]
                public string District { get; set; }

                [NameInMap("districtCode")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                [NameInMap("economicFunctionZone1")]
                [Validation(Required=false)]
                public string EconomicFunctionZone1 { get; set; }

                [NameInMap("economicFunctionZone2")]
                [Validation(Required=false)]
                public string EconomicFunctionZone2 { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("emailList")]
                [Validation(Required=false)]
                public string EmailList { get; set; }

                [NameInMap("establishTime")]
                [Validation(Required=false)]
                public long? EstablishTime { get; set; }

                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                [NameInMap("historyNameList")]
                [Validation(Required=false)]
                public List<string> HistoryNameList { get; set; }

                [NameInMap("historyNames")]
                [Validation(Required=false)]
                public string HistoryNames { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                [NameInMap("industryAll")]
                [Validation(Required=false)]
                public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll IndustryAll { get; set; }
                public class GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll : TeaModel {
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("categoryBig")]
                    [Validation(Required=false)]
                    public string CategoryBig { get; set; }

                    [NameInMap("categoryCodeFirst")]
                    [Validation(Required=false)]
                    public string CategoryCodeFirst { get; set; }

                    [NameInMap("categoryCodeFourth")]
                    [Validation(Required=false)]
                    public string CategoryCodeFourth { get; set; }

                    [NameInMap("categoryCodeSecond")]
                    [Validation(Required=false)]
                    public string CategoryCodeSecond { get; set; }

                    [NameInMap("categoryCodeThird")]
                    [Validation(Required=false)]
                    public string CategoryCodeThird { get; set; }

                    [NameInMap("categoryMiddle")]
                    [Validation(Required=false)]
                    public string CategoryMiddle { get; set; }

                    [NameInMap("categorySmall")]
                    [Validation(Required=false)]
                    public string CategorySmall { get; set; }

                }

                [NameInMap("isMicroEnt")]
                [Validation(Required=false)]
                public int? IsMicroEnt { get; set; }

                [NameInMap("legalPersonName")]
                [Validation(Required=false)]
                public string LegalPersonName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("numberSource")]
                [Validation(Required=false)]
                public string NumberSource { get; set; }

                [NameInMap("numberType")]
                [Validation(Required=false)]
                public string NumberType { get; set; }

                [NameInMap("orgNumber")]
                [Validation(Required=false)]
                public string OrgNumber { get; set; }

                [NameInMap("percentileScore")]
                [Validation(Required=false)]
                public int? PercentileScore { get; set; }

                [NameInMap("phoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("property3")]
                [Validation(Required=false)]
                public string Property3 { get; set; }

                [NameInMap("regCapital")]
                [Validation(Required=false)]
                public string RegCapital { get; set; }

                [NameInMap("regCapitalCurrency")]
                [Validation(Required=false)]
                public string RegCapitalCurrency { get; set; }

                [NameInMap("regInstitute")]
                [Validation(Required=false)]
                public string RegInstitute { get; set; }

                [NameInMap("regLocation")]
                [Validation(Required=false)]
                public string RegLocation { get; set; }

                [NameInMap("regLocationHalfWidth")]
                [Validation(Required=false)]
                public string RegLocationHalfWidth { get; set; }

                [NameInMap("regNumber")]
                [Validation(Required=false)]
                public string RegNumber { get; set; }

                [NameInMap("regStatus")]
                [Validation(Required=false)]
                public string RegStatus { get; set; }

                [NameInMap("revokeDate")]
                [Validation(Required=false)]
                public long? RevokeDate { get; set; }

                [NameInMap("revokeReason")]
                [Validation(Required=false)]
                public string RevokeReason { get; set; }

                [NameInMap("socialStaffNum")]
                [Validation(Required=false)]
                public long? SocialStaffNum { get; set; }

                [NameInMap("staffNumRange")]
                [Validation(Required=false)]
                public string StaffNumRange { get; set; }

                [NameInMap("tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                [NameInMap("taxNumber")]
                [Validation(Required=false)]
                public string TaxNumber { get; set; }

                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("updateTimes")]
                [Validation(Required=false)]
                public long? UpdateTimes { get; set; }

                [NameInMap("usedBondName")]
                [Validation(Required=false)]
                public string UsedBondName { get; set; }

                [NameInMap("websiteList")]
                [Validation(Required=false)]
                public string WebsiteList { get; set; }

            }

            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

            [NameInMap("subjectRiskListResponse")]
            [Validation(Required=false)]
            public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse SubjectRiskListResponse { get; set; }
            public class GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse : TeaModel {
                [NameInMap("isSubjectExist")]
                [Validation(Required=false)]
                public bool? IsSubjectExist { get; set; }

                [NameInMap("riskTypes")]
                [Validation(Required=false)]
                public List<string> RiskTypes { get; set; }

                [NameInMap("risks")]
                [Validation(Required=false)]
                public Dictionary<string, object> Risks { get; set; }

                [NameInMap("totalRiskNumber")]
                [Validation(Required=false)]
                public int? TotalRiskNumber { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

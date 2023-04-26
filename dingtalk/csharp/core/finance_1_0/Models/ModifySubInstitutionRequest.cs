// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class ModifySubInstitutionRequest : TeaModel {
        [NameInMap("bindingAlipayLogonId")]
        [Validation(Required=false)]
        public string BindingAlipayLogonId { get; set; }

        [NameInMap("contactInfo")]
        [Validation(Required=false)]
        public ModifySubInstitutionRequestContactInfo ContactInfo { get; set; }
        public class ModifySubInstitutionRequestContactInfo : TeaModel {
            [NameInMap("contactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

        }

        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        [NameInMap("legalPersonCertInfo")]
        [Validation(Required=false)]
        public ModifySubInstitutionRequestLegalPersonCertInfo LegalPersonCertInfo { get; set; }
        public class ModifySubInstitutionRequestLegalPersonCertInfo : TeaModel {
            [NameInMap("certBackImage")]
            [Validation(Required=false)]
            public string CertBackImage { get; set; }

            [NameInMap("certFrontImage")]
            [Validation(Required=false)]
            public string CertFrontImage { get; set; }

            [NameInMap("certName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            [NameInMap("certType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            [NameInMap("idCardNo")]
            [Validation(Required=false)]
            public string IdCardNo { get; set; }

        }

        [NameInMap("outTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

        [NameInMap("qualificationInfos")]
        [Validation(Required=false)]
        public List<ModifySubInstitutionRequestQualificationInfos> QualificationInfos { get; set; }
        public class ModifySubInstitutionRequestQualificationInfos : TeaModel {
            [NameInMap("qualificationImage")]
            [Validation(Required=false)]
            public string QualificationImage { get; set; }

            [NameInMap("qualificationType")]
            [Validation(Required=false)]
            public string QualificationType { get; set; }

        }

        [NameInMap("services")]
        [Validation(Required=false)]
        public List<string> Services { get; set; }

        [NameInMap("settleInfo")]
        [Validation(Required=false)]
        public ModifySubInstitutionRequestSettleInfo SettleInfo { get; set; }
        public class ModifySubInstitutionRequestSettleInfo : TeaModel {
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("bankBranchName")]
            [Validation(Required=false)]
            public string BankBranchName { get; set; }

            [NameInMap("bankCity")]
            [Validation(Required=false)]
            public string BankCity { get; set; }

            [NameInMap("bankCode")]
            [Validation(Required=false)]
            public string BankCode { get; set; }

            [NameInMap("bankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

            [NameInMap("bankProvince")]
            [Validation(Required=false)]
            public string BankProvince { get; set; }

            [NameInMap("bankShortNameCode")]
            [Validation(Required=false)]
            public string BankShortNameCode { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("usageType")]
            [Validation(Required=false)]
            public string UsageType { get; set; }

        }

        [NameInMap("subInstAddressInfo")]
        [Validation(Required=false)]
        public ModifySubInstitutionRequestSubInstAddressInfo SubInstAddressInfo { get; set; }
        public class ModifySubInstitutionRequestSubInstAddressInfo : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("districtCode")]
            [Validation(Required=false)]
            public string DistrictCode { get; set; }

            [NameInMap("provinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

        }

        [NameInMap("subInstAuthInfo")]
        [Validation(Required=false)]
        public ModifySubInstitutionRequestSubInstAuthInfo SubInstAuthInfo { get; set; }
        public class ModifySubInstitutionRequestSubInstAuthInfo : TeaModel {
            [NameInMap("authorizationLetterUrl")]
            [Validation(Required=false)]
            public string AuthorizationLetterUrl { get; set; }

        }

        [NameInMap("subInstBasicInfo")]
        [Validation(Required=false)]
        public ModifySubInstitutionRequestSubInstBasicInfo SubInstBasicInfo { get; set; }
        public class ModifySubInstitutionRequestSubInstBasicInfo : TeaModel {
            [NameInMap("aliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("mcc")]
            [Validation(Required=false)]
            public string Mcc { get; set; }

            [NameInMap("subInstName")]
            [Validation(Required=false)]
            public string SubInstName { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("subInstCertifyInfo")]
        [Validation(Required=false)]
        public ModifySubInstitutionRequestSubInstCertifyInfo SubInstCertifyInfo { get; set; }
        public class ModifySubInstitutionRequestSubInstCertifyInfo : TeaModel {
            [NameInMap("certImage")]
            [Validation(Required=false)]
            public string CertImage { get; set; }

            [NameInMap("certNo")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            [NameInMap("certType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

        }

        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        [NameInMap("subInstInvoiceInfo")]
        [Validation(Required=false)]
        public ModifySubInstitutionRequestSubInstInvoiceInfo SubInstInvoiceInfo { get; set; }
        public class ModifySubInstitutionRequestSubInstInvoiceInfo : TeaModel {
            [NameInMap("acceptElectronic")]
            [Validation(Required=false)]
            public bool? AcceptElectronic { get; set; }

            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("autoInvoice")]
            [Validation(Required=false)]
            public bool? AutoInvoice { get; set; }

            [NameInMap("bankAccount")]
            [Validation(Required=false)]
            public string BankAccount { get; set; }

            [NameInMap("bankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

            [NameInMap("mailAddress")]
            [Validation(Required=false)]
            public ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress MailAddress { get; set; }
            public class ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress : TeaModel {
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("districtCode")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                [NameInMap("provinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

            }

            [NameInMap("mailName")]
            [Validation(Required=false)]
            public string MailName { get; set; }

            [NameInMap("mailPhone")]
            [Validation(Required=false)]
            public string MailPhone { get; set; }

            [NameInMap("taxNo")]
            [Validation(Required=false)]
            public string TaxNo { get; set; }

            [NameInMap("taxPayerQualification")]
            [Validation(Required=false)]
            public string TaxPayerQualification { get; set; }

            [NameInMap("taxPayerValidDate")]
            [Validation(Required=false)]
            public string TaxPayerValidDate { get; set; }

            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("subInstShopInfo")]
        [Validation(Required=false)]
        public ModifySubInstitutionRequestSubInstShopInfo SubInstShopInfo { get; set; }
        public class ModifySubInstitutionRequestSubInstShopInfo : TeaModel {
            [NameInMap("inDoorImages")]
            [Validation(Required=false)]
            public List<string> InDoorImages { get; set; }

            [NameInMap("outDoorImages")]
            [Validation(Required=false)]
            public List<string> OutDoorImages { get; set; }

        }

    }

}

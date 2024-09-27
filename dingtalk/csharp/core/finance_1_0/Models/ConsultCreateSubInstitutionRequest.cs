// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class ConsultCreateSubInstitutionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:asdf@163.com">asdf@163.com</a></para>
        /// </summary>
        [NameInMap("bindingAlipayLogonId")]
        [Validation(Required=false)]
        public string BindingAlipayLogonId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contactInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestContactInfo ContactInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestContactInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李某某</para>
            /// </summary>
            [NameInMap("contactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13900000000</para>
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202111090001</para>
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("legalPersonCertInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestLegalPersonCertInfo LegalPersonCertInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestLegalPersonCertInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ossUrl</para>
            /// </summary>
            [NameInMap("certBackImage")]
            [Validation(Required=false)]
            public string CertBackImage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ossUrl</para>
            /// </summary>
            [NameInMap("certFrontImage")]
            [Validation(Required=false)]
            public string CertFrontImage { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李某某</para>
            /// </summary>
            [NameInMap("certName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("certType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330104200010109999</para>
            /// </summary>
            [NameInMap("idCardNo")]
            [Validation(Required=false)]
            public string IdCardNo { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021000001</para>
        /// </summary>
        [NameInMap("outTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIPAY</para>
        /// </summary>
        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

        [NameInMap("qualificationInfos")]
        [Validation(Required=false)]
        public List<ConsultCreateSubInstitutionRequestQualificationInfos> QualificationInfos { get; set; }
        public class ConsultCreateSubInstitutionRequestQualificationInfos : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ossUrl</para>
            /// </summary>
            [NameInMap("qualificationImage")]
            [Validation(Required=false)]
            public string QualificationImage { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>301</para>
            /// </summary>
            [NameInMap("qualificationType")]
            [Validation(Required=false)]
            public string QualificationType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("services")]
        [Validation(Required=false)]
        public List<string> Services { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("settleInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSettleInfo SettleInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSettleInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>622202120200000000</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李某某</para>
            /// </summary>
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DEBIT_CARD</para>
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>城东支行</para>
            /// </summary>
            [NameInMap("bankBranchName")]
            [Validation(Required=false)]
            public string BankBranchName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州市</para>
            /// </summary>
            [NameInMap("bankCity")]
            [Validation(Required=false)]
            public string BankCity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>313791000023</para>
            /// </summary>
            [NameInMap("bankCode")]
            [Validation(Required=false)]
            public string BankCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>工商银行</para>
            /// </summary>
            [NameInMap("bankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>浙江省</para>
            /// </summary>
            [NameInMap("bankProvince")]
            [Validation(Required=false)]
            public string BankProvince { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ICBC</para>
            /// </summary>
            [NameInMap("bankShortNameCode")]
            [Validation(Required=false)]
            public string BankShortNameCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIPAY</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TO_PRI</para>
            /// </summary>
            [NameInMap("usageType")]
            [Validation(Required=false)]
            public string UsageType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S001</para>
        /// </summary>
        [NameInMap("solution")]
        [Validation(Required=false)]
        public string Solution { get; set; }

        [NameInMap("subInstAddressInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstAddressInfo SubInstAddressInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstAddressInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>未来park</para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330104</para>
            /// </summary>
            [NameInMap("districtCode")]
            [Validation(Required=false)]
            public string DistrictCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330000</para>
            /// </summary>
            [NameInMap("provinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

        }

        [NameInMap("subInstAuthInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstAuthInfo SubInstAuthInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstAuthInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ossUrl</para>
            /// </summary>
            [NameInMap("authorizationLetterUrl")]
            [Validation(Required=false)]
            public string AuthorizationLetterUrl { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subInstBasicInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstBasicInfo SubInstBasicInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstBasicInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>一食堂</para>
            /// </summary>
            [NameInMap("aliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5812</para>
            /// </summary>
            [NameInMap("mcc")]
            [Validation(Required=false)]
            public string Mcc { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>食堂</para>
            /// </summary>
            [NameInMap("subInstName")]
            [Validation(Required=false)]
            public string SubInstName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subInstCertifyInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstCertifyInfo SubInstCertifyInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstCertifyInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ossUrl</para>
            /// </summary>
            [NameInMap("certImage")]
            [Validation(Required=false)]
            public string CertImage { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>331081198611111111</para>
            /// </summary>
            [NameInMap("certNo")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201</para>
            /// </summary>
            [NameInMap("certType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        [NameInMap("subInstInvoiceInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo SubInstInvoiceInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstInvoiceInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("acceptElectronic")]
            [Validation(Required=false)]
            public bool? AcceptElectronic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>浙江省杭州市西湖区西溪路蚂蚁金服</para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("autoInvoice")]
            [Validation(Required=false)]
            public bool? AutoInvoice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567812345678123</para>
            /// </summary>
            [NameInMap("bankAccount")]
            [Validation(Required=false)]
            public string BankAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>中国银行</para>
            /// </summary>
            [NameInMap("bankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

            [NameInMap("mailAddress")]
            [Validation(Required=false)]
            public ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress MailAddress { get; set; }
            public class ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>未来park</para>
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330104</para>
                /// </summary>
                [NameInMap("districtCode")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330000</para>
                /// </summary>
                [NameInMap("provinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("mailName")]
            [Validation(Required=false)]
            public string MailName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>057162288888</para>
            /// </summary>
            [NameInMap("mailPhone")]
            [Validation(Required=false)]
            public string MailPhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51010482542598631219</para>
            /// </summary>
            [NameInMap("taxNo")]
            [Validation(Required=false)]
            public string TaxNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("taxPayerQualification")]
            [Validation(Required=false)]
            public string TaxPayerQualification { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19981011</para>
            /// </summary>
            [NameInMap("taxPayerValidDate")]
            [Validation(Required=false)]
            public string TaxPayerValidDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>057162288888</para>
            /// </summary>
            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>**有限公司</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("subInstShopInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstShopInfo SubInstShopInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstShopInfo : TeaModel {
            [NameInMap("inDoorImages")]
            [Validation(Required=false)]
            public List<string> InDoorImages { get; set; }

            [NameInMap("outDoorImages")]
            [Validation(Required=false)]
            public List<string> OutDoorImages { get; set; }

        }

    }

}

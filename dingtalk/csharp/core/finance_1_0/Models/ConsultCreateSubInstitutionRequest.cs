// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class ConsultCreateSubInstitutionRequest : TeaModel {
        /// <summary>
        /// 签约支付宝账户，用于协议确认
        /// </summary>
        [NameInMap("bindingAlipayLogonId")]
        [Validation(Required=false)]
        public string BindingAlipayLogonId { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [NameInMap("contactInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestContactInfo ContactInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestContactInfo : TeaModel {
            /// <summary>
            /// 联系人姓名
            /// </summary>
            [NameInMap("contactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// 联系人手机号
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

        }

        /// <summary>
        /// 主机构编号
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        [NameInMap("legalPersonCertInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestLegalPersonCertInfo LegalPersonCertInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestLegalPersonCertInfo : TeaModel {
            /// <summary>
            /// 法人证件反面url
            /// </summary>
            [NameInMap("certBackImage")]
            [Validation(Required=false)]
            public string CertBackImage { get; set; }

            /// <summary>
            /// 法人证件正面url
            /// </summary>
            [NameInMap("certFrontImage")]
            [Validation(Required=false)]
            public string CertFrontImage { get; set; }

            /// <summary>
            /// 法人姓名
            /// </summary>
            [NameInMap("certName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// 法人证件类型 不填默认为身份证
            /// </summary>
            [NameInMap("certType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// 法人证件号
            /// </summary>
            [NameInMap("idCardNo")]
            [Validation(Required=false)]
            public string IdCardNo { get; set; }

        }

        /// <summary>
        /// 进件创建外部流水号
        /// </summary>
        [NameInMap("outTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 进件渠道
        /// </summary>
        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

        /// <summary>
        /// 资质信息
        /// </summary>
        [NameInMap("qualificationInfos")]
        [Validation(Required=false)]
        public List<ConsultCreateSubInstitutionRequestQualificationInfos> QualificationInfos { get; set; }
        public class ConsultCreateSubInstitutionRequestQualificationInfos : TeaModel {
            /// <summary>
            /// 子机构行业资质图片
            /// </summary>
            [NameInMap("qualificationImage")]
            [Validation(Required=false)]
            public string QualificationImage { get; set; }

            /// <summary>
            /// 子机构行业资质类型
            /// </summary>
            [NameInMap("qualificationType")]
            [Validation(Required=false)]
            public string QualificationType { get; set; }

        }

        /// <summary>
        /// 开通的服务类型
        /// </summary>
        [NameInMap("services")]
        [Validation(Required=false)]
        public List<string> Services { get; set; }

        /// <summary>
        /// 资金账户信息
        /// </summary>
        [NameInMap("settleInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSettleInfo SettleInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSettleInfo : TeaModel {
            /// <summary>
            /// 账户账号
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// 账户名称 账号类型银行卡时为卡户名
            /// </summary>
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// 卡类型
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// 支行名称
            /// </summary>
            [NameInMap("bankBranchName")]
            [Validation(Required=false)]
            public string BankBranchName { get; set; }

            /// <summary>
            /// 开户行所在地 市
            /// </summary>
            [NameInMap("bankCity")]
            [Validation(Required=false)]
            public string BankCity { get; set; }

            /// <summary>
            /// 联行号
            /// </summary>
            [NameInMap("bankCode")]
            [Validation(Required=false)]
            public string BankCode { get; set; }

            /// <summary>
            /// 银行名称
            /// </summary>
            [NameInMap("bankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

            /// <summary>
            /// 开户行所在地 省
            /// </summary>
            [NameInMap("bankProvince")]
            [Validation(Required=false)]
            public string BankProvince { get; set; }

            /// <summary>
            /// 开户行简称缩写
            /// </summary>
            [NameInMap("bankShortNameCode")]
            [Validation(Required=false)]
            public string BankShortNameCode { get; set; }

            /// <summary>
            /// 账号类型
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 账户使用类型
            /// </summary>
            [NameInMap("usageType")]
            [Validation(Required=false)]
            public string UsageType { get; set; }

        }

        /// <summary>
        /// 解决方案，包含清算、费率规则
        /// </summary>
        [NameInMap("solution")]
        [Validation(Required=false)]
        public string Solution { get; set; }

        /// <summary>
        /// 子机构地址信息
        /// </summary>
        [NameInMap("subInstAddressInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstAddressInfo SubInstAddressInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstAddressInfo : TeaModel {
            /// <summary>
            /// 详细地址
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// 市码
            /// </summary>
            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// 区码
            /// </summary>
            [NameInMap("districtCode")]
            [Validation(Required=false)]
            public string DistrictCode { get; set; }

            /// <summary>
            /// 省码
            /// </summary>
            [NameInMap("provinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

        }

        /// <summary>
        /// 授权信息
        /// </summary>
        [NameInMap("subInstAuthInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstAuthInfo SubInstAuthInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstAuthInfo : TeaModel {
            /// <summary>
            /// 授权函图片url
            /// </summary>
            [NameInMap("authorizationLetterUrl")]
            [Validation(Required=false)]
            public string AuthorizationLetterUrl { get; set; }

        }

        /// <summary>
        /// 子机构基本信息
        /// </summary>
        [NameInMap("subInstBasicInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstBasicInfo SubInstBasicInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstBasicInfo : TeaModel {
            /// <summary>
            /// 别名
            /// </summary>
            [NameInMap("aliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// 机构识别码
            /// </summary>
            [NameInMap("mcc")]
            [Validation(Required=false)]
            public string Mcc { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("subInstName")]
            [Validation(Required=false)]
            public string SubInstName { get; set; }

            /// <summary>
            /// 类型
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 子机构认证信息
        /// </summary>
        [NameInMap("subInstCertifyInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstCertifyInfo SubInstCertifyInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstCertifyInfo : TeaModel {
            /// <summary>
            /// 证件图片, 如果是特殊行业必填
            /// </summary>
            [NameInMap("certImage")]
            [Validation(Required=false)]
            public string CertImage { get; set; }

            /// <summary>
            /// 证件号码
            /// </summary>
            [NameInMap("certNo")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// 证件类型
            /// </summary>
            [NameInMap("certType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

        }

        /// <summary>
        /// 子机构编号
        /// </summary>
        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        /// <summary>
        /// 开票信息
        /// </summary>
        [NameInMap("subInstInvoiceInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo SubInstInvoiceInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstInvoiceInfo : TeaModel {
            /// <summary>
            /// 是否接受电票
            /// </summary>
            [NameInMap("acceptElectronic")]
            [Validation(Required=false)]
            public bool? AcceptElectronic { get; set; }

            /// <summary>
            /// 开票地址
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// 是否自动开票
            /// </summary>
            [NameInMap("autoInvoice")]
            [Validation(Required=false)]
            public bool? AutoInvoice { get; set; }

            /// <summary>
            /// 银行账户
            /// </summary>
            [NameInMap("bankAccount")]
            [Validation(Required=false)]
            public string BankAccount { get; set; }

            /// <summary>
            /// 银行名称
            /// </summary>
            [NameInMap("bankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

            /// <summary>
            /// 收件地址
            /// </summary>
            [NameInMap("mailAddress")]
            [Validation(Required=false)]
            public ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress MailAddress { get; set; }
            public class ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress : TeaModel {
                /// <summary>
                /// 详细地址
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// 市码
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// 区码
                /// </summary>
                [NameInMap("districtCode")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                /// <summary>
                /// 省码
                /// </summary>
                [NameInMap("provinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

            }

            /// <summary>
            /// 收件人名称
            /// </summary>
            [NameInMap("mailName")]
            [Validation(Required=false)]
            public string MailName { get; set; }

            /// <summary>
            /// 收件人号码
            /// </summary>
            [NameInMap("mailPhone")]
            [Validation(Required=false)]
            public string MailPhone { get; set; }

            /// <summary>
            /// 纳税人识别号
            /// </summary>
            [NameInMap("taxNo")]
            [Validation(Required=false)]
            public string TaxNo { get; set; }

            /// <summary>
            /// 纳税人资质
            /// </summary>
            [NameInMap("taxPayerQualification")]
            [Validation(Required=false)]
            public string TaxPayerQualification { get; set; }

            /// <summary>
            /// 纳税人资格开始时间
            /// </summary>
            [NameInMap("taxPayerValidDate")]
            [Validation(Required=false)]
            public string TaxPayerValidDate { get; set; }

            /// <summary>
            /// 开票电话
            /// </summary>
            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            /// <summary>
            /// 纳税人抬头
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 子机构门店信息
        /// </summary>
        [NameInMap("subInstShopInfo")]
        [Validation(Required=false)]
        public ConsultCreateSubInstitutionRequestSubInstShopInfo SubInstShopInfo { get; set; }
        public class ConsultCreateSubInstitutionRequestSubInstShopInfo : TeaModel {
            /// <summary>
            /// 内景照
            /// </summary>
            [NameInMap("inDoorImages")]
            [Validation(Required=false)]
            public List<string> InDoorImages { get; set; }

            /// <summary>
            /// 外景照
            /// </summary>
            [NameInMap("outDoorImages")]
            [Validation(Required=false)]
            public List<string> OutDoorImages { get; set; }

        }

    }

}

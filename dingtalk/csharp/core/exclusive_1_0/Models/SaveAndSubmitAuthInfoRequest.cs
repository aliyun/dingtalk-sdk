// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveAndSubmitAuthInfoRequest : TeaModel {
        /// <summary>
        /// 申请说明
        /// </summary>
        [NameInMap("applyRemark")]
        [Validation(Required=false)]
        public string ApplyRemark { get; set; }

        /// <summary>
        /// 认证书图片mediaId
        /// </summary>
        [NameInMap("authorizeMediaId")]
        [Validation(Required=false)]
        public string AuthorizeMediaId { get; set; }

        /// <summary>
        /// 行业
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// 企业法人
        /// </summary>
        [NameInMap("legalPerson")]
        [Validation(Required=false)]
        public string LegalPerson { get; set; }

        /// <summary>
        /// 企业法人身份证
        /// </summary>
        [NameInMap("legalPersonIdCard")]
        [Validation(Required=false)]
        public string LegalPersonIdCard { get; set; }

        /// <summary>
        /// 营业执照图片mediaId
        /// </summary>
        [NameInMap("licenseMediaId")]
        [Validation(Required=false)]
        public string LicenseMediaId { get; set; }

        /// <summary>
        /// 城市名字
        /// </summary>
        [NameInMap("locCityName")]
        [Validation(Required=false)]
        public string LocCityName { get; set; }

        /// <summary>
        /// 省份名字
        /// </summary>
        [NameInMap("locProvinceName")]
        [Validation(Required=false)]
        public string LocProvinceName { get; set; }

        /// <summary>
        /// 申请人手机号（需要实名认证）
        /// </summary>
        [NameInMap("mobileNum")]
        [Validation(Required=false)]
        public string MobileNum { get; set; }

        /// <summary>
        /// 组织名，提交认证的时候可以修改
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// 组织机构代码证号（格式11111111-1）
        /// </summary>
        [NameInMap("organizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 组织机构代码证图片mediaId
        /// </summary>
        [NameInMap("organizationCodeMediaId")]
        [Validation(Required=false)]
        public string OrganizationCodeMediaId { get; set; }

        /// <summary>
        /// 认证企业详细地址
        /// </summary>
        [NameInMap("registLocation")]
        [Validation(Required=false)]
        public string RegistLocation { get; set; }

        /// <summary>
        /// 营业执照注册号（一般15位）
        /// </summary>
        [NameInMap("registNum")]
        [Validation(Required=false)]
        public string RegistNum { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        /// <summary>
        /// 社会统一信用代码（固定18位）
        /// </summary>
        [NameInMap("unifiedSocialCredit")]
        [Validation(Required=false)]
        public string UnifiedSocialCredit { get; set; }

    }

}

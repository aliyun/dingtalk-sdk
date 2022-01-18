// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetOrgAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// 认证等级 1高级认证 2中级认证
        /// </summary>
        [NameInMap("authLevel")]
        [Validation(Required=false)]
        public long? AuthLevel { get; set; }

        /// <summary>
        /// 法人
        /// </summary>
        [NameInMap("legalPerson")]
        [Validation(Required=false)]
        public string LegalPerson { get; set; }

        /// <summary>
        /// 提交企业认证时营业执照上面的企业名称
        /// </summary>
        [NameInMap("licenseOrgName")]
        [Validation(Required=false)]
        public string LicenseOrgName { get; set; }

        /// <summary>
        /// 营业执照url
        /// </summary>
        [NameInMap("licenseUrl")]
        [Validation(Required=false)]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// 企业在钉钉通讯录的名称
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
        /// 营业执照注册号（一般15位）
        /// </summary>
        [NameInMap("registrationNum")]
        [Validation(Required=false)]
        public string RegistrationNum { get; set; }

        /// <summary>
        /// 社会统一信用代码（固定18位）
        /// </summary>
        [NameInMap("unifiedSocialCredit")]
        [Validation(Required=false)]
        public string UnifiedSocialCredit { get; set; }

    }

}

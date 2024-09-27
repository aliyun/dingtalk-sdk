// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetOrgAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("authLevel")]
        [Validation(Required=false)]
        public long? AuthLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("legalPerson")]
        [Validation(Required=false)]
        public string LegalPerson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试有限公司</para>
        /// </summary>
        [NameInMap("licenseOrgName")]
        [Validation(Required=false)]
        public string LicenseOrgName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://XXX.XX">https://XXX.XX</a></para>
        /// </summary>
        [NameInMap("licenseUrl")]
        [Validation(Required=false)]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2456677</para>
        /// </summary>
        [NameInMap("organizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1233</para>
        /// </summary>
        [NameInMap("registrationNum")]
        [Validation(Required=false)]
        public string RegistrationNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123566788</para>
        /// </summary>
        [NameInMap("unifiedSocialCredit")]
        [Validation(Required=false)]
        public string UnifiedSocialCredit { get; set; }

    }

}

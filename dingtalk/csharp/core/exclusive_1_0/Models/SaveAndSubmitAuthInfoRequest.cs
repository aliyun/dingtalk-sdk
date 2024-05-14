// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveAndSubmitAuthInfoRequest : TeaModel {
        [NameInMap("applyRemark")]
        [Validation(Required=false)]
        public string ApplyRemark { get; set; }

        [NameInMap("authorizeMediaId")]
        [Validation(Required=false)]
        public string AuthorizeMediaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("legalPerson")]
        [Validation(Required=false)]
        public string LegalPerson { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("legalPersonIdCard")]
        [Validation(Required=false)]
        public string LegalPersonIdCard { get; set; }

        [NameInMap("licenseMediaId")]
        [Validation(Required=false)]
        public string LicenseMediaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("locCity")]
        [Validation(Required=false)]
        public long? LocCity { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("locCityName")]
        [Validation(Required=false)]
        public string LocCityName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("locProvince")]
        [Validation(Required=false)]
        public long? LocProvince { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("locProvinceName")]
        [Validation(Required=false)]
        public string LocProvinceName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mobileNum")]
        [Validation(Required=false)]
        public string MobileNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("organizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        [NameInMap("organizationCodeMediaId")]
        [Validation(Required=false)]
        public string OrganizationCodeMediaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("registLocation")]
        [Validation(Required=false)]
        public string RegistLocation { get; set; }

        [NameInMap("registNum")]
        [Validation(Required=false)]
        public string RegistNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("unifiedSocialCredit")]
        [Validation(Required=false)]
        public string UnifiedSocialCredit { get; set; }

    }

}

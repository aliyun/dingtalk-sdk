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

        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("legalPerson")]
        [Validation(Required=false)]
        public string LegalPerson { get; set; }

        [NameInMap("legalPersonIdCard")]
        [Validation(Required=false)]
        public string LegalPersonIdCard { get; set; }

        [NameInMap("licenseMediaId")]
        [Validation(Required=false)]
        public string LicenseMediaId { get; set; }

        [NameInMap("locCity")]
        [Validation(Required=false)]
        public long? LocCity { get; set; }

        [NameInMap("locCityName")]
        [Validation(Required=false)]
        public string LocCityName { get; set; }

        [NameInMap("locProvince")]
        [Validation(Required=false)]
        public long? LocProvince { get; set; }

        [NameInMap("locProvinceName")]
        [Validation(Required=false)]
        public string LocProvinceName { get; set; }

        [NameInMap("mobileNum")]
        [Validation(Required=false)]
        public string MobileNum { get; set; }

        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("organizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        [NameInMap("organizationCodeMediaId")]
        [Validation(Required=false)]
        public string OrganizationCodeMediaId { get; set; }

        [NameInMap("registLocation")]
        [Validation(Required=false)]
        public string RegistLocation { get; set; }

        [NameInMap("registNum")]
        [Validation(Required=false)]
        public string RegistNum { get; set; }

        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("unifiedSocialCredit")]
        [Validation(Required=false)]
        public string UnifiedSocialCredit { get; set; }

    }

}

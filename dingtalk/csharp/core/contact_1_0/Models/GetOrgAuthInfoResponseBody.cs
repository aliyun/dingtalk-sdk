// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetOrgAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("authLevel")]
        [Validation(Required=false)]
        public long? AuthLevel { get; set; }

        [NameInMap("legalPerson")]
        [Validation(Required=false)]
        public string LegalPerson { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("licenseOrgName")]
        [Validation(Required=false)]
        public string LicenseOrgName { get; set; }

        [NameInMap("licenseUrl")]
        [Validation(Required=false)]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("organizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        [NameInMap("registrationNum")]
        [Validation(Required=false)]
        public string RegistrationNum { get; set; }

        [NameInMap("unifiedSocialCredit")]
        [Validation(Required=false)]
        public string UnifiedSocialCredit { get; set; }

    }

}

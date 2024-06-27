// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class SaveBenefitLicenseRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("licenses")]
        [Validation(Required=false)]
        public List<SaveBenefitLicenseRequestLicenses> Licenses { get; set; }
        public class SaveBenefitLicenseRequestLicenses : TeaModel {
            [NameInMap("licenseUserId")]
            [Validation(Required=false)]
            public string LicenseUserId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("saveUserId")]
        [Validation(Required=false)]
        public string SaveUserId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class ListBenefitLicenseResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListBenefitLicenseResponseBodyResult> Result { get; set; }
        public class ListBenefitLicenseResponseBodyResult : TeaModel {
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
            public List<ListBenefitLicenseResponseBodyResultLicenses> Licenses { get; set; }
            public class ListBenefitLicenseResponseBodyResultLicenses : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("licenseUserId")]
                [Validation(Required=false)]
                public string LicenseUserId { get; set; }

            }

        }

    }

}

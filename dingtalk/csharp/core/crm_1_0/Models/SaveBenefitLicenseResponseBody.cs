// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class SaveBenefitLicenseResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SaveBenefitLicenseResponseBodyResult Result { get; set; }
        public class SaveBenefitLicenseResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>B_ACCOUNT_NUMBER</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("licenses")]
            [Validation(Required=false)]
            public List<SaveBenefitLicenseResponseBodyResultLicenses> Licenses { get; set; }
            public class SaveBenefitLicenseResponseBodyResultLicenses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>license账号信息</para>
                /// </summary>
                [NameInMap("licenseUserId")]
                [Validation(Required=false)]
                public string LicenseUserId { get; set; }

            }

        }

    }

}

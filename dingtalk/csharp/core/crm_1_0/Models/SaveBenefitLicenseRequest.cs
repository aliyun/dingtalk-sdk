// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class SaveBenefitLicenseRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B_ACCOUNT_NUMBER</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("licenses")]
        [Validation(Required=false)]
        public List<SaveBenefitLicenseRequestLicenses> Licenses { get; set; }
        public class SaveBenefitLicenseRequestLicenses : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>licenseStaffId</para>
            /// </summary>
            [NameInMap("licenseUserId")]
            [Validation(Required=false)]
            public string LicenseUserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>staffId</para>
        /// </summary>
        [NameInMap("saveUserId")]
        [Validation(Required=false)]
        public string SaveUserId { get; set; }

    }

}

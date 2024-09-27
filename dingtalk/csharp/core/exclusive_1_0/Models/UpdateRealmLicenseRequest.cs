// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class UpdateRealmLicenseRequest : TeaModel {
        [NameInMap("detailList")]
        [Validation(Required=false)]
        public List<UpdateRealmLicenseRequestDetailList> DetailList { get; set; }
        public class UpdateRealmLicenseRequestDetailList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("licenseType")]
            [Validation(Required=false)]
            public int? LicenseType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

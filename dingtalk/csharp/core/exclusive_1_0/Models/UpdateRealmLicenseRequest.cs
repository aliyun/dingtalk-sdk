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
            [NameInMap("licenseType")]
            [Validation(Required=false)]
            public int? LicenseType { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

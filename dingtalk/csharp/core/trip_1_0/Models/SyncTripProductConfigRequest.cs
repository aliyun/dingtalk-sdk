// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncTripProductConfigRequest : TeaModel {
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("tripProductConfigList")]
        [Validation(Required=false)]
        public List<SyncTripProductConfigRequestTripProductConfigList> TripProductConfigList { get; set; }
        public class SyncTripProductConfigRequestTripProductConfigList : TeaModel {
            [NameInMap("allVisible")]
            [Validation(Required=false)]
            public bool? AllVisible { get; set; }

            [NameInMap("deptVisibleScopes")]
            [Validation(Required=false)]
            public List<string> DeptVisibleScopes { get; set; }

            [NameInMap("openStatus")]
            [Validation(Required=false)]
            public bool? OpenStatus { get; set; }

            [NameInMap("productType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("roleVisibleScopes")]
            [Validation(Required=false)]
            public List<string> RoleVisibleScopes { get; set; }

            [NameInMap("staffVisibleScopes")]
            [Validation(Required=false)]
            public List<string> StaffVisibleScopes { get; set; }

            [NameInMap("tmcInfos")]
            [Validation(Required=false)]
            public List<SyncTripProductConfigRequestTripProductConfigListTmcInfos> TmcInfos { get; set; }
            public class SyncTripProductConfigRequestTripProductConfigListTmcInfos : TeaModel {
                [NameInMap("categoryType")]
                [Validation(Required=false)]
                public string CategoryType { get; set; }

                [NameInMap("gmtOrgPay")]
                [Validation(Required=false)]
                public string GmtOrgPay { get; set; }

                [NameInMap("payType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("tmcCorpId")]
                [Validation(Required=false)]
                public string TmcCorpId { get; set; }

            }

        }

    }

}

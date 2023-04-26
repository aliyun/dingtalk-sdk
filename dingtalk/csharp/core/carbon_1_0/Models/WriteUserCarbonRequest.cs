// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models
{
    public class WriteUserCarbonRequest : TeaModel {
        [NameInMap("userDetailsList")]
        [Validation(Required=false)]
        public List<WriteUserCarbonRequestUserDetailsList> UserDetailsList { get; set; }
        public class WriteUserCarbonRequestUserDetailsList : TeaModel {
            [NameInMap("actionEndTime")]
            [Validation(Required=false)]
            public string ActionEndTime { get; set; }

            [NameInMap("actionId")]
            [Validation(Required=false)]
            public string ActionId { get; set; }

            [NameInMap("actionStartTime")]
            [Validation(Required=false)]
            public string ActionStartTime { get; set; }

            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("carbonAmount")]
            [Validation(Required=false)]
            public string CarbonAmount { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}

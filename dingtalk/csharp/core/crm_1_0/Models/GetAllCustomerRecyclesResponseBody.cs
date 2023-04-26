// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetAllCustomerRecyclesResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("resultList")]
        [Validation(Required=false)]
        public List<GetAllCustomerRecyclesResponseBodyResultList> ResultList { get; set; }
        public class GetAllCustomerRecyclesResponseBodyResultList : TeaModel {
            [NameInMap("customerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            [NameInMap("followUpActionTime")]
            [Validation(Required=false)]
            public string FollowUpActionTime { get; set; }

            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            [NameInMap("notifyTime")]
            [Validation(Required=false)]
            public string NotifyTime { get; set; }

            [NameInMap("recycleRuleId")]
            [Validation(Required=false)]
            public long? RecycleRuleId { get; set; }

            [NameInMap("recycleTime")]
            [Validation(Required=false)]
            public string RecycleTime { get; set; }

        }

    }

}

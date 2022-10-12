// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetAllCustomerRecyclesResponseBody : TeaModel {
        /// <summary>
        /// 是否还有下一页。
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一页的游标。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 数据列表。
        /// </summary>
        [NameInMap("resultList")]
        [Validation(Required=false)]
        public List<GetAllCustomerRecyclesResponseBodyResultList> ResultList { get; set; }
        public class GetAllCustomerRecyclesResponseBodyResultList : TeaModel {
            /// <summary>
            /// 客户ID
            /// </summary>
            [NameInMap("customerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// 上次跟进时间
            /// </summary>
            [NameInMap("followUpActionTime")]
            [Validation(Required=false)]
            public string FollowUpActionTime { get; set; }

            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// 掉保提醒时间
            /// </summary>
            [NameInMap("notifyTime")]
            [Validation(Required=false)]
            public string NotifyTime { get; set; }

            /// <summary>
            /// 掉保规则ID
            /// </summary>
            [NameInMap("recycleRuleId")]
            [Validation(Required=false)]
            public long? RecycleRuleId { get; set; }

            /// <summary>
            /// 掉保时间
            /// </summary>
            [NameInMap("recycleTime")]
            [Validation(Required=false)]
            public string RecycleTime { get; set; }

        }

    }

}

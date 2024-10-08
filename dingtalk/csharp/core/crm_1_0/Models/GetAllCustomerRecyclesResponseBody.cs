// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetAllCustomerRecyclesResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("resultList")]
        [Validation(Required=false)]
        public List<GetAllCustomerRecyclesResponseBodyResultList> ResultList { get; set; }
        public class GetAllCustomerRecyclesResponseBodyResultList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("customerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-24T09:30Z</para>
            /// </summary>
            [NameInMap("followUpActionTime")]
            [Validation(Required=false)]
            public string FollowUpActionTime { get; set; }

            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-24T09:30Z</para>
            /// </summary>
            [NameInMap("notifyTime")]
            [Validation(Required=false)]
            public string NotifyTime { get; set; }

            [NameInMap("recycleRuleId")]
            [Validation(Required=false)]
            public long? RecycleRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-24T09:30Z</para>
            /// </summary>
            [NameInMap("recycleTime")]
            [Validation(Required=false)]
            public string RecycleTime { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryAccountTradeByPageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ACC_XXXXX</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1730778990150</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public QueryAccountTradeByPageRequestFilter Filter { get; set; }
        public class QueryAccountTradeByPageRequestFilter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("endAmount")]
            [Validation(Required=false)]
            public string EndAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>钉钉</para>
            /// </summary>
            [NameInMap("otherAccountName")]
            [Validation(Required=false)]
            public string OtherAccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("startAmount")]
            [Validation(Required=false)]
            public string StartAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("tradeType")]
            [Validation(Required=false)]
            public string TradeType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1730778990150</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}

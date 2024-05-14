// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ListOrderResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListOrderResponseBodyList> List { get; set; }
        public class ListOrderResponseBodyList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("actualAmount")]
            [Validation(Required=false)]
            public long? ActualAmount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("buyerId")]
            [Validation(Required=false)]
            public string BuyerId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("orderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("payTime")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            [NameInMap("refundNo")]
            [Validation(Required=false)]
            public string RefundNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public long? Scene { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("tradeNo")]
            [Validation(Required=false)]
            public string TradeNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

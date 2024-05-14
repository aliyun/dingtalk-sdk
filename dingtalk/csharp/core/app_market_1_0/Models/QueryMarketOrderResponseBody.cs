// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class QueryMarketOrderResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizOrderId")]
        [Validation(Required=false)]
        public long? BizOrderId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("endTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("goodsCode")]
        [Validation(Required=false)]
        public string GoodsCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("goodsName")]
        [Validation(Required=false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("inAppOrder")]
        [Validation(Required=false)]
        public bool? InAppOrder { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("itemCode")]
        [Validation(Required=false)]
        public string ItemCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("itemName")]
        [Validation(Required=false)]
        public string ItemName { get; set; }

        [NameInMap("paidTimestamp")]
        [Validation(Required=false)]
        public long? PaidTimestamp { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        [NameInMap("startTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalActualPayFee")]
        [Validation(Required=false)]
        public long? TotalActualPayFee { get; set; }

    }

}

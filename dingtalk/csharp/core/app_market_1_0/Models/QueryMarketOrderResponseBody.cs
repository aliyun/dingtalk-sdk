// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class QueryMarketOrderResponseBody : TeaModel {
        [NameInMap("bizOrderId")]
        [Validation(Required=false)]
        public long? BizOrderId { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("endTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        [NameInMap("goodsCode")]
        [Validation(Required=false)]
        public string GoodsCode { get; set; }

        [NameInMap("goodsName")]
        [Validation(Required=false)]
        public string GoodsName { get; set; }

        [NameInMap("inAppOrder")]
        [Validation(Required=false)]
        public bool? InAppOrder { get; set; }

        [NameInMap("itemCode")]
        [Validation(Required=false)]
        public string ItemCode { get; set; }

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

        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("totalActualPayFee")]
        [Validation(Required=false)]
        public long? TotalActualPayFee { get; set; }

    }

}

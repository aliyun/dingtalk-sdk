// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryOrderResponseBody : TeaModel {
        [NameInMap("actualAmount")]
        [Validation(Required=false)]
        public long? ActualAmount { get; set; }

        [NameInMap("alipayAppId")]
        [Validation(Required=false)]
        public string AlipayAppId { get; set; }

        [NameInMap("closeTime")]
        [Validation(Required=false)]
        public string CloseTime { get; set; }

        [NameInMap("closeTimestamp")]
        [Validation(Required=false)]
        public long? CloseTimestamp { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("labelAmount")]
        [Validation(Required=false)]
        public long? LabelAmount { get; set; }

        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("merchantMergeOrderNo")]
        [Validation(Required=false)]
        public string MerchantMergeOrderNo { get; set; }

        [NameInMap("merchantOrderNo")]
        [Validation(Required=false)]
        public string MerchantOrderNo { get; set; }

        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("outerUserId")]
        [Validation(Required=false)]
        public string OuterUserId { get; set; }

        [NameInMap("payLogonId")]
        [Validation(Required=false)]
        public string PayLogonId { get; set; }

        [NameInMap("payStatus")]
        [Validation(Required=false)]
        public int? PayStatus { get; set; }

        [NameInMap("payTime")]
        [Validation(Required=false)]
        public string PayTime { get; set; }

        [NameInMap("payTimestamp")]
        [Validation(Required=false)]
        public long? PayTimestamp { get; set; }

        [NameInMap("payType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("refundAmount")]
        [Validation(Required=false)]
        public long? RefundAmount { get; set; }

        [NameInMap("refundStatus")]
        [Validation(Required=false)]
        public int? RefundStatus { get; set; }

        [NameInMap("refundTime")]
        [Validation(Required=false)]
        public string RefundTime { get; set; }

        [NameInMap("refundTimestamp")]
        [Validation(Required=false)]
        public long? RefundTimestamp { get; set; }

        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("tradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

    }

}

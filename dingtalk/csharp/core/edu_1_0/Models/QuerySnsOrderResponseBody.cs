// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QuerySnsOrderResponseBody : TeaModel {
        [NameInMap("actualAmount")]
        [Validation(Required=false)]
        public long? ActualAmount { get; set; }

        /// <summary>
        /// 支付宝应用id。
        /// </summary>
        [NameInMap("alipayAppId")]
        [Validation(Required=false)]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// 订单关闭时间
        /// </summary>
        [NameInMap("closeTime")]
        [Validation(Required=false)]
        public string CloseTime { get; set; }

        /// <summary>
        /// 订单关闭时间戳
        /// </summary>
        [NameInMap("closeTimestamp")]
        [Validation(Required=false)]
        public long? CloseTimestamp { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 订单创建时间戳
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("labelAmount")]
        [Validation(Required=false)]
        public long? LabelAmount { get; set; }

        /// <summary>
        /// 商户id。
        /// </summary>
        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户聚合支付订单号。
        /// </summary>
        [NameInMap("merchantMergeOrderNo")]
        [Validation(Required=false)]
        public string MerchantMergeOrderNo { get; set; }

        /// <summary>
        /// 商户订单号。
        /// </summary>
        [NameInMap("merchantOrderNo")]
        [Validation(Required=false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单号。
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单类型。
        /// </summary>
        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// 用户唯一id。
        /// </summary>
        [NameInMap("outerUserId")]
        [Validation(Required=false)]
        public string OuterUserId { get; set; }

        /// <summary>
        /// 买家支付登陆id。
        /// </summary>
        [NameInMap("payLogonId")]
        [Validation(Required=false)]
        public string PayLogonId { get; set; }

        [NameInMap("payStatus")]
        [Validation(Required=false)]
        public int? PayStatus { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        [NameInMap("payTime")]
        [Validation(Required=false)]
        public string PayTime { get; set; }

        /// <summary>
        /// 订单支付时间戳
        /// </summary>
        [NameInMap("payTimestamp")]
        [Validation(Required=false)]
        public long? PayTimestamp { get; set; }

        /// <summary>
        /// 买家支付渠道类型。
        /// </summary>
        [NameInMap("payType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("refundAmount")]
        [Validation(Required=false)]
        public long? RefundAmount { get; set; }

        [NameInMap("refundStatus")]
        [Validation(Required=false)]
        public int? RefundStatus { get; set; }

        /// <summary>
        /// 订单退款时间
        /// </summary>
        [NameInMap("refundTime")]
        [Validation(Required=false)]
        public string RefundTime { get; set; }

        /// <summary>
        /// 订单退款时间戳
        /// </summary>
        [NameInMap("refundTimestamp")]
        [Validation(Required=false)]
        public long? RefundTimestamp { get; set; }

        /// <summary>
        /// 订单标题。
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// 交易流水号。
        /// </summary>
        [NameInMap("tradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

    }

}

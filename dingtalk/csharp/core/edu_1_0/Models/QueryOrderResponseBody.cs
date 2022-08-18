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

        /// <summary>
        /// 支付宝应用id。
        /// </summary>
        [NameInMap("alipayAppId")]
        [Validation(Required=false)]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// 订单关单时间。
        /// </summary>
        [NameInMap("closeTime")]
        [Validation(Required=false)]
        public long? CloseTime { get; set; }

        /// <summary>
        /// 订单创建时间。
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 扩展字段。
        /// </summary>
        [NameInMap("feature")]
        [Validation(Required=false)]
        public string Feature { get; set; }

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
        /// 买家支付id。
        /// </summary>
        [NameInMap("payId")]
        [Validation(Required=false)]
        public string PayId { get; set; }

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
        /// 订单支付时间。
        /// </summary>
        [NameInMap("payTime")]
        [Validation(Required=false)]
        public long? PayTime { get; set; }

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
        /// 订单退款时间。
        /// </summary>
        [NameInMap("refundTime")]
        [Validation(Required=false)]
        public long? RefundTime { get; set; }

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

        /// <summary>
        /// 用户唯一id。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

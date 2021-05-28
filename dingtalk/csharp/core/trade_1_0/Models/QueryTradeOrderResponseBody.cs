// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0.Models
{
    public class QueryTradeOrderResponseBody : TeaModel {
        /// <summary>
        /// ISV的组织ID
        /// </summary>
        [NameInMap("isvCropId")]
        [Validation(Required=false)]
        public string IsvCropId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [NameInMap("articleName")]
        [Validation(Required=false)]
        public string ArticleName { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [NameInMap("articleCode")]
        [Validation(Required=false)]
        public string ArticleCode { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [NameInMap("articleItemName")]
        [Validation(Required=false)]
        public string ArticleItemName { get; set; }

        /// <summary>
        /// 规格编码
        /// </summary>
        [NameInMap("articleItemCode")]
        [Validation(Required=false)]
        public string ArticleItemCode { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [NameInMap("outerOrderId")]
        [Validation(Required=false)]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// 原价（单位：分）
        /// </summary>
        [NameInMap("fee")]
        [Validation(Required=false)]
        public long? Fee { get; set; }

        /// <summary>
        /// 实际支付的价格（单位：分）
        /// </summary>
        [NameInMap("payFee")]
        [Validation(Required=false)]
        public long? PayFee { get; set; }

        /// <summary>
        /// 订单创建时间（单位：ms）
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 订单退款时间（单位：ms）
        /// </summary>
        [NameInMap("refundTime")]
        [Validation(Required=false)]
        public long? RefundTime { get; set; }

        /// <summary>
        /// 订单关闭时间（单位：ms）
        /// </summary>
        [NameInMap("closeTime")]
        [Validation(Required=false)]
        public long? CloseTime { get; set; }

        /// <summary>
        /// 订单支付时间（单位：ms）
        /// </summary>
        [NameInMap("payTime")]
        [Validation(Required=false)]
        public long? PayTime { get; set; }

        /// <summary>
        /// 订单状态：-1表示已关闭、0表示未支付、1表示已支付、2表示已退款
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}

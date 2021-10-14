// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class QueryMarketOrderResponseBody : TeaModel {
        /// <summary>
        /// 订单ID
        /// </summary>
        [NameInMap("bizOrderId")]
        [Validation(Required=false)]
        public long? BizOrderId { get; set; }

        /// <summary>
        /// 组织ID
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// 生效结束时间
        /// </summary>
        [NameInMap("endTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 商品Code
        /// </summary>
        [NameInMap("goodsCode")]
        [Validation(Required=false)]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [NameInMap("goodsName")]
        [Validation(Required=false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// 是否内购订单
        /// </summary>
        [NameInMap("inAppOrder")]
        [Validation(Required=false)]
        public bool? InAppOrder { get; set; }

        /// <summary>
        /// 规格编码
        /// </summary>
        [NameInMap("itemCode")]
        [Validation(Required=false)]
        public string ItemCode { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [NameInMap("itemName")]
        [Validation(Required=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// 支付时间戳
        /// </summary>
        [NameInMap("paidTimestamp")]
        [Validation(Required=false)]
        public long? PaidTimestamp { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// 开始生效时间
        /// </summary>
        [NameInMap("startTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 订单状态(0:订单关闭； 3：订单支付；4：订单创建)
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// 订单实付金额(单位分)
        /// </summary>
        [NameInMap("totalActualPayFee")]
        [Validation(Required=false)]
        public long? TotalActualPayFee { get; set; }

    }

}

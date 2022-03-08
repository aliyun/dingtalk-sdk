// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class ChannelOrdersRequest : TeaModel {
        /// <summary>
        /// 商品id
        /// </summary>
        [NameInMap("itemCode")]
        [Validation(Required=false)]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [NameInMap("itemName")]
        [Validation(Required=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [NameInMap("orderCreateTime")]
        [Validation(Required=false)]
        public float? OrderCreateTime { get; set; }

        /// <summary>
        /// isv方的订单Id（用于幂等，请保证唯一性）
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付金额（以分为单位，仅作记录，不作为凭证）
        /// </summary>
        [NameInMap("payFee")]
        [Validation(Required=false)]
        public float? PayFee { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public float? Quantity { get; set; }

    }

}

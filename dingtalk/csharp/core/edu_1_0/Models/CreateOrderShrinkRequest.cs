// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateOrderShrinkRequest : TeaModel {
        /// <summary>
        /// 实付金额（优惠计算后）
        /// </summary>
        [NameInMap("actualAmount")]
        [Validation(Required=false)]
        public long? ActualAmount { get; set; }

        /// <summary>
        /// 订单明细信息，来源于商户系统或APP的商品信息。
        /// </summary>
        [NameInMap("detailList")]
        [Validation(Required=false)]
        public string DetailListShrink { get; set; }

        /// <summary>
        /// 录脸token
        /// </summary>
        [NameInMap("ftoken")]
        [Validation(Required=false)]
        public string Ftoken { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// 交易加签
        /// </summary>
        [NameInMap("terminalParams")]
        [Validation(Required=false)]
        public string TerminalParams { get; set; }

        /// <summary>
        /// 应付价格
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public long? TotalAmount { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

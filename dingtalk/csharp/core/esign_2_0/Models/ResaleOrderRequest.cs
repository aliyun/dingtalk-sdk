// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class ResaleOrderRequest : TeaModel {
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
        /// 购买数量（电子合同份数）
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public float? Quantity { get; set; }

        /// <summary>
        /// 合同生效起始时间
        /// </summary>
        [NameInMap("serviceStartTime")]
        [Validation(Required=false)]
        public float? ServiceStartTime { get; set; }

        /// <summary>
        /// 合同失效截止日期，默认有效时间一年
        /// </summary>
        [NameInMap("serviceStopTime")]
        [Validation(Required=false)]
        public float? ServiceStopTime { get; set; }

    }

}

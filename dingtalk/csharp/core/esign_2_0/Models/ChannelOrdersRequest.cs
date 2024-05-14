// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class ChannelOrdersRequest : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orderCreateTime")]
        [Validation(Required=false)]
        public float? OrderCreateTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("payFee")]
        [Validation(Required=false)]
        public float? PayFee { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public float? Quantity { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class ResaleOrderRequest : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public float? Quantity { get; set; }

        [NameInMap("serviceStartTime")]
        [Validation(Required=false)]
        public float? ServiceStartTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("serviceStopTime")]
        [Validation(Required=false)]
        public float? ServiceStopTime { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CancelUserOrderResponseBody : TeaModel {
        /// <summary>
        /// 应用id。
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 商户id。
        /// </summary>
        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

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

        [NameInMap("payStatus")]
        [Validation(Required=false)]
        public int? PayStatus { get; set; }

        [NameInMap("refundStatus")]
        [Validation(Required=false)]
        public int? RefundStatus { get; set; }

        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public long? TotalAmount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class CreateAcquireRefundOrderResponseBody : TeaModel {
        /// <summary>
        /// 外部退款单号
        /// </summary>
        [NameInMap("outRefundNo")]
        [Validation(Required=false)]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 钉钉退款单号
        /// </summary>
        [NameInMap("refundOrderNo")]
        [Validation(Required=false)]
        public string RefundOrderNo { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryRegisterOrderRequest : TeaModel {
        /// <summary>
        /// 主机构编号
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        /// <summary>
        /// 申请单号，和外部流水号至少一个必填
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部流水号，和申请单编号至少一个必填
        /// </summary>
        [NameInMap("outTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 子机构编号
        /// </summary>
        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

    }

}

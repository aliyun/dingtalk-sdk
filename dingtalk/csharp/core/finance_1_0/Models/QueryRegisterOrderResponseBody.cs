// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryRegisterOrderResponseBody : TeaModel {
        /// <summary>
        /// 失败原因
        /// </summary>
        [NameInMap("failReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        [NameInMap("gmtAudit")]
        [Validation(Required=false)]
        public string GmtAudit { get; set; }

        /// <summary>
        /// 主机构编号
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        /// <summary>
        /// 申请单号
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [NameInMap("outTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 子机构编号
        /// </summary>
        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        /// <summary>
        /// 子机构名称
        /// </summary>
        [NameInMap("subInstName")]
        [Validation(Required=false)]
        public string SubInstName { get; set; }

    }

}

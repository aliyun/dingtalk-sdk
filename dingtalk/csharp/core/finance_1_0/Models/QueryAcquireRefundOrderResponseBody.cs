// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryAcquireRefundOrderResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtRefund")]
        [Validation(Required=false)]
        public string GmtRefund { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("originOutTradeNo")]
        [Validation(Required=false)]
        public string OriginOutTradeNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outRefundNo")]
        [Validation(Required=false)]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("payChannelAccountNo")]
        [Validation(Required=false)]
        public string PayChannelAccountNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("payerUserId")]
        [Validation(Required=false)]
        public string PayerUserId { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}

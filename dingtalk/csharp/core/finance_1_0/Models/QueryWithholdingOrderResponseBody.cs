// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryWithholdingOrderResponseBody : TeaModel {
        /// <summary>
        /// 代扣金额（元）
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// 订单创建日期
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 付款完成日期
        /// </summary>
        [NameInMap("gmtPay")]
        [Validation(Required=false)]
        public string GmtPay { get; set; }

        /// <summary>
        /// 主机构编号
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        /// <summary>
        /// 钉钉订单号
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [NameInMap("outTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

        /// <summary>
        /// 支付渠道支付账号（脱敏后返回）
        /// </summary>
        [NameInMap("payChannelAccountNo")]
        [Validation(Required=false)]
        public string PayChannelAccountNo { get; set; }

        /// <summary>
        /// 付款人staffId
        /// </summary>
        [NameInMap("payerStaffId")]
        [Validation(Required=false)]
        public string PayerStaffId { get; set; }

        /// <summary>
        /// 代扣备注
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 状态
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
        /// 代扣标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}

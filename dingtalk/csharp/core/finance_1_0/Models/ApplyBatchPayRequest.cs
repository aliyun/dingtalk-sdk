// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class ApplyBatchPayRequest : TeaModel {
        /// <summary>
        /// 支付账号唯一id
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 钉钉订单号(和商户批次号一一对应)
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数
        /// </summary>
        [NameInMap("passBackParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> PassBackParams { get; set; }

        /// <summary>
        /// 支付终端
        /// </summary>
        [NameInMap("payTerminal")]
        [Validation(Required=false)]
        public string PayTerminal { get; set; }

        /// <summary>
        /// 回调url
        /// </summary>
        [NameInMap("returnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 支付发起人staffId
        /// </summary>
        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// 订单总金额（必填）, 单位为：元
        /// </summary>
        [NameInMap("transAmount")]
        [Validation(Required=false)]
        public string TransAmount { get; set; }

        /// <summary>
        /// 转账过期时间
        /// </summary>
        [NameInMap("transExpireTime")]
        [Validation(Required=false)]
        public string TransExpireTime { get; set; }

    }

}

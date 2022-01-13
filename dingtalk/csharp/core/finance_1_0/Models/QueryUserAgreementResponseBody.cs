// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryUserAgreementResponseBody : TeaModel {
        /// <summary>
        /// 协议编号
        /// </summary>
        [NameInMap("agreementNo")]
        [Validation(Required=false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 实际过期日期
        /// </summary>
        [NameInMap("gmtExpire")]
        [Validation(Required=false)]
        public string GmtExpire { get; set; }

        /// <summary>
        /// 实际签约日期
        /// </summary>
        [NameInMap("gmtSign")]
        [Validation(Required=false)]
        public string GmtSign { get; set; }

        /// <summary>
        /// 实际生效日期
        /// </summary>
        [NameInMap("gmtValid")]
        [Validation(Required=false)]
        public string GmtValid { get; set; }

        /// <summary>
        /// 主机构id
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

        /// <summary>
        /// 实际支付账户名（脱敏）
        /// </summary>
        [NameInMap("payChannelAccountName")]
        [Validation(Required=false)]
        public string PayChannelAccountName { get; set; }

        /// <summary>
        /// 实际支付账号（脱敏）
        /// </summary>
        [NameInMap("payChannelAccountNo")]
        [Validation(Required=false)]
        public string PayChannelAccountNo { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 子机构id
        /// </summary>
        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

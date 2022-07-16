// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateReceiptVoucherStatusRequest : TeaModel {
        /// <summary>
        /// 账期
        /// </summary>
        [NameInMap("accountPeriod")]
        [Validation(Required=false)]
        public string AccountPeriod { get; set; }

        /// <summary>
        /// 操作类型 add 添加凭证关系、delete 删除凭证关系
        /// </summary>
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 审批单据ID
        /// </summary>
        [NameInMap("receiptId")]
        [Validation(Required=false)]
        public string ReceiptId { get; set; }

        /// <summary>
        /// 凭证CODE
        /// </summary>
        [NameInMap("voucherCode")]
        [Validation(Required=false)]
        public string VoucherCode { get; set; }

        /// <summary>
        /// 凭证ID
        /// </summary>
        [NameInMap("voucherId")]
        [Validation(Required=false)]
        public string VoucherId { get; set; }

    }

}

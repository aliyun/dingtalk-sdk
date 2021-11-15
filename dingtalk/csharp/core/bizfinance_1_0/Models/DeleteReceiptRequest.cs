// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class DeleteReceiptRequest : TeaModel {
        /// <summary>
        /// 单据列表，最长不超过10条
        /// </summary>
        [NameInMap("receipts")]
        [Validation(Required=false)]
        public List<DeleteReceiptRequestReceipts> Receipts { get; set; }
        public class DeleteReceiptRequestReceipts : TeaModel {
            /// <summary>
            /// 修改者工号
            /// </summary>
            [NameInMap("deleteUserId")]
            [Validation(Required=false)]
            public string DeleteUserId { get; set; }

            /// <summary>
            /// 单据唯一编号
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 单据类型：1付款单，2收款单
            /// </summary>
            [NameInMap("receiptType")]
            [Validation(Required=false)]
            public long? ReceiptType { get; set; }

        }

    }

}

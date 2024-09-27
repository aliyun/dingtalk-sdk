// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class DeleteReceiptRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receipts")]
        [Validation(Required=false)]
        public List<DeleteReceiptRequestReceipts> Receipts { get; set; }
        public class DeleteReceiptRequestReceipts : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd_efgh</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emp_xxx</para>
            /// </summary>
            [NameInMap("deleteUserId")]
            [Validation(Required=false)]
            public string DeleteUserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("receiptType")]
            [Validation(Required=false)]
            public long? ReceiptType { get; set; }

        }

    }

}

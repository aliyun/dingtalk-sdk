// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryBatchTradeDetailListResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("batchTradeDetailList")]
        [Validation(Required=false)]
        public List<QueryBatchTradeDetailListResponseBodyBatchTradeDetailList> BatchTradeDetailList { get; set; }
        public class QueryBatchTradeDetailListResponseBodyBatchTradeDetailList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("detailNo")]
            [Validation(Required=false)]
            public string DetailNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("payeeAccountName")]
            [Validation(Required=false)]
            public string PayeeAccountName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("payeeAccountNo")]
            [Validation(Required=false)]
            public string PayeeAccountNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("payeeAccountType")]
            [Validation(Required=false)]
            public string PayeeAccountType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("serialNo")]
            [Validation(Required=false)]
            public long? SerialNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalPageNumber")]
        [Validation(Required=false)]
        public int? TotalPageNumber { get; set; }

    }

}

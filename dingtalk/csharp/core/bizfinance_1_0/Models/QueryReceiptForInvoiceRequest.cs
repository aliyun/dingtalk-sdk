// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptForInvoiceRequest : TeaModel {
        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 发票筛选条件
        /// </summary>
        [NameInMap("invoiceFilter")]
        [Validation(Required=false)]
        public QueryReceiptForInvoiceRequestInvoiceFilter InvoiceFilter { get; set; }
        public class QueryReceiptForInvoiceRequestInvoiceFilter : TeaModel {
            [NameInMap("financeType")]
            [Validation(Required=false)]
            public string FinanceType { get; set; }
            [NameInMap("relationStatus")]
            [Validation(Required=false)]
            public string RelationStatus { get; set; }
        };

        /// <summary>
        /// 分页参数，从1 开始
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页参数，每页查询个数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 单据状态，审批中 RUNNING，已完成 COMPLETED
        /// </summary>
        [NameInMap("receiptStatus")]
        [Validation(Required=false)]
        public string ReceiptStatus { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 单据标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}

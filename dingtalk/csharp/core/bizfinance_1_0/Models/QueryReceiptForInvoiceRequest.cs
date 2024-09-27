// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptForInvoiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("accountantBookId")]
        [Validation(Required=false)]
        public string AccountantBookId { get; set; }

        [NameInMap("applyStatusList")]
        [Validation(Required=false)]
        public List<string> ApplyStatusList { get; set; }

        [NameInMap("bizStatusList")]
        [Validation(Required=false)]
        public List<string> BizStatusList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COM_DEFAULT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("receiptStatusList")]
        [Validation(Required=false)]
        public List<string> ReceiptStatusList { get; set; }

        [NameInMap("searchParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> SearchParams { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}

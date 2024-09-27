// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptsBaseInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("accountantBookId")]
        [Validation(Required=false)]
        public string AccountantBookId { get; set; }

        [NameInMap("amountEnd")]
        [Validation(Required=false)]
        public double? AmountEnd { get; set; }

        [NameInMap("amountStart")]
        [Validation(Required=false)]
        public double? AmountStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COM_DEFAULT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16000000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16000000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("timeFilterField")]
        [Validation(Required=false)]
        public string TimeFilterField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>收款单</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("voucherStatus")]
        [Validation(Required=false)]
        public string VoucherStatus { get; set; }

    }

}

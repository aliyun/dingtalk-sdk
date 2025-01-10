// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class CheckVoucherStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>COM_DEFUALT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1631526550994</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VAT_IN</para>
        /// </summary>
        [NameInMap("financeType")]
        [Validation(Required=false)]
        public string FinanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3121234560</para>
        /// </summary>
        [NameInMap("invoiceCode")]
        [Validation(Required=false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("invoiceNo")]
        [Validation(Required=false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1631526550994</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678901</para>
        /// </summary>
        [NameInMap("taxNo")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VERIFIED</para>
        /// </summary>
        [NameInMap("verifyStatus")]
        [Validation(Required=false)]
        public string VerifyStatus { get; set; }

    }

}

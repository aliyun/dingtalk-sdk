// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetInvoiceByPageRequest : TeaModel {
        [NameInMap("request")]
        [Validation(Required=false)]
        public GetInvoiceByPageRequestRequest Request { get; set; }
        public class GetInvoiceByPageRequestRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("accountantBookId")]
            [Validation(Required=false)]
            public string AccountantBookId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COM_DEFAULT</para>
            /// </summary>
            [NameInMap("companyCode")]
            [Validation(Required=false)]
            public string CompanyCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("financeType")]
            [Validation(Required=false)]
            public string FinanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-11</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111111111</para>
            /// </summary>
            [NameInMap("taxNo")]
            [Validation(Required=false)]
            public string TaxNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ABC</para>
            /// </summary>
            [NameInMap("verifyStatus")]
            [Validation(Required=false)]
            public string VerifyStatus { get; set; }

        }

    }

}

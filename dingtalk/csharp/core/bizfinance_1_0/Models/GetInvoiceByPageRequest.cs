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
            [NameInMap("accountantBookId")]
            [Validation(Required=false)]
            public string AccountantBookId { get; set; }

            [NameInMap("companyCode")]
            [Validation(Required=false)]
            public string CompanyCode { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("financeType")]
            [Validation(Required=false)]
            public string FinanceType { get; set; }

            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("taxNo")]
            [Validation(Required=false)]
            public string TaxNo { get; set; }

            [NameInMap("verifyStatus")]
            [Validation(Required=false)]
            public string VerifyStatus { get; set; }

        }

    }

}

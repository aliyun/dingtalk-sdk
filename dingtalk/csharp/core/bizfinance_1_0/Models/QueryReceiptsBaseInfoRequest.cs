// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptsBaseInfoRequest : TeaModel {
        [NameInMap("accountantBookId")]
        [Validation(Required=false)]
        public string AccountantBookId { get; set; }

        [NameInMap("amountEnd")]
        [Validation(Required=false)]
        public double? AmountEnd { get; set; }

        [NameInMap("amountStart")]
        [Validation(Required=false)]
        public double? AmountStart { get; set; }

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

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("timeFilterField")]
        [Validation(Required=false)]
        public string TimeFilterField { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("voucherStatus")]
        [Validation(Required=false)]
        public string VoucherStatus { get; set; }

    }

}

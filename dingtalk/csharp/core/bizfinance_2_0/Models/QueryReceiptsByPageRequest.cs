// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryReceiptsByPageRequest : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("modelIds")]
        [Validation(Required=false)]
        public List<string> ModelIds { get; set; }

        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("timeFilterField")]
        [Validation(Required=false)]
        public string TimeFilterField { get; set; }

    }

}

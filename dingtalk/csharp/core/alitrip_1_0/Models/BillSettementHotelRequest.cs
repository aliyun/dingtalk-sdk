// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class BillSettementHotelRequest : TeaModel {
        [NameInMap("category")]
        [Validation(Required=false)]
        public long? Category { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("periodEnd")]
        [Validation(Required=false)]
        public string PeriodEnd { get; set; }

        [NameInMap("periodStart")]
        [Validation(Required=false)]
        public string PeriodStart { get; set; }

    }

}

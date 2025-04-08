// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class DataMarketServiceResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("totalQuota")]
        [Validation(Required=false)]
        public long? TotalQuota { get; set; }

        [NameInMap("usedQuota")]
        [Validation(Required=false)]
        public long? UsedQuota { get; set; }

    }

}

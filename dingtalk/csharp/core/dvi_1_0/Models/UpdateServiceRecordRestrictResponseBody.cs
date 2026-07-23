// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class UpdateServiceRecordRestrictResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateServiceRecordRestrictResponseBodyResult Result { get; set; }
        public class UpdateServiceRecordRestrictResponseBodyResult : TeaModel {
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            [NameInMap("failedRecordIds")]
            [Validation(Required=false)]
            public List<string> FailedRecordIds { get; set; }

            [NameInMap("successCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class UpdateAutoIssuePointResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateAutoIssuePointResponseBodyResult Result { get; set; }
        public class UpdateAutoIssuePointResponseBodyResult : TeaModel {
            [NameInMap("nextAutoIssuePointTime")]
            [Validation(Required=false)]
            public long? NextAutoIssuePointTime { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjobs_1_0.Models
{
    public class PostResumeRequest : TeaModel {
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        [NameInMap("userIdentify")]
        [Validation(Required=false)]
        public string UserIdentify { get; set; }

    }

}

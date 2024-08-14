// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjobs_1_0.Models
{
    public class CreateResumeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateResumeResponseBodyResult Result { get; set; }
        public class CreateResumeResponseBodyResult : TeaModel {
            [NameInMap("resumeId")]
            [Validation(Required=false)]
            public string ResumeId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

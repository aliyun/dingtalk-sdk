// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class LiandanTextImageGetRequest : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        [NameInMap("requestSource")]
        [Validation(Required=false)]
        public string RequestSource { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

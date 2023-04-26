// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class PageListObjectiveProgressResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public PageListObjectiveProgressResponseBodyContent Content { get; set; }
        public class PageListObjectiveProgressResponseBodyContent : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("progressList")]
            [Validation(Required=false)]
            public List<OpenProgressDTO> ProgressList { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

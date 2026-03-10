// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_search_ask_1_0.Models
{
    public class SubmitAiTaskRequest : TeaModel {
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<SubmitAiTaskRequestMessages> Messages { get; set; }
        public class SubmitAiTaskRequestMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

    }

}

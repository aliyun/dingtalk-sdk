// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class PromptTemplatesOperateResponseBody : TeaModel {
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("placeholderCount")]
        [Validation(Required=false)]
        public int? PlaceholderCount { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}

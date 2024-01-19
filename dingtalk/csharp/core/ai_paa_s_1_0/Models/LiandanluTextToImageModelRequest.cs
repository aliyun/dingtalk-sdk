// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class LiandanluTextToImageModelRequest : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        [NameInMap("number")]
        [Validation(Required=false)]
        public long? Number { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

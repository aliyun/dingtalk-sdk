// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class ExclusiveModelCompleteServiceRequest : TeaModel {
        [NameInMap("enable_search")]
        [Validation(Required=false)]
        public bool? EnableSearch { get; set; }

        [NameInMap("max_tokens")]
        [Validation(Required=false)]
        public int? MaxTokens { get; set; }

        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<ExclusiveModelCompleteServiceRequestMessages> Messages { get; set; }
        public class ExclusiveModelCompleteServiceRequestMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("temperature")]
        [Validation(Required=false)]
        public double? Temperature { get; set; }

        [NameInMap("top_p")]
        [Validation(Required=false)]
        public double? TopP { get; set; }

    }

}

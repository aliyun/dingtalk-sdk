// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainLabelTaskMetaResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<HrbrainLabelTaskMetaResponseBodyContent> Content { get; set; }
        public class HrbrainLabelTaskMetaResponseBodyContent : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("isSystem")]
            [Validation(Required=false)]
            public string IsSystem { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("tagConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> TagConfig { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

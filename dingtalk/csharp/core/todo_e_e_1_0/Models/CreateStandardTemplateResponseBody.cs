// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class CreateStandardTemplateResponseBody : TeaModel {
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<CreateStandardTemplateResponseBodyActions> Actions { get; set; }
        public class CreateStandardTemplateResponseBodyActions : TeaModel {
            [NameInMap("actionKey")]
            [Validation(Required=false)]
            public string ActionKey { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("needReason")]
            [Validation(Required=false)]
            public bool? NeedReason { get; set; }

            [NameInMap("needReasonRequired")]
            [Validation(Required=false)]
            public bool? NeedReasonRequired { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            [NameInMap("styleType")]
            [Validation(Required=false)]
            public long? StyleType { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("templateKey")]
        [Validation(Required=false)]
        public string TemplateKey { get; set; }

    }

}

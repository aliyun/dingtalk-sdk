// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateTemplateResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateTemplateResponseBodyData Data { get; set; }
        public class CreateTemplateResponseBodyData : TeaModel {
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

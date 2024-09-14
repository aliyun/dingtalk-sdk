// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CopyTemplateResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CopyTemplateResponseBodyData Data { get; set; }
        public class CopyTemplateResponseBodyData : TeaModel {
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

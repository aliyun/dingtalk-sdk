// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class RecallAuditTemplateResponseBody : TeaModel {
        [NameInMap("recallResult")]
        [Validation(Required=false)]
        public List<RecallAuditTemplateResponseBodyRecallResult> RecallResult { get; set; }
        public class RecallAuditTemplateResponseBodyRecallResult : TeaModel {
            [NameInMap("templateKey")]
            [Validation(Required=false)]
            public string TemplateKey { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

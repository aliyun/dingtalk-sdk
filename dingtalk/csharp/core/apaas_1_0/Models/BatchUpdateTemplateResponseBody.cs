// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class BatchUpdateTemplateResponseBody : TeaModel {
        [NameInMap("updateResultList")]
        [Validation(Required=false)]
        public List<BatchUpdateTemplateResponseBodyUpdateResultList> UpdateResultList { get; set; }
        public class BatchUpdateTemplateResponseBodyUpdateResultList : TeaModel {
            [NameInMap("templateKey")]
            [Validation(Required=false)]
            public string TemplateKey { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

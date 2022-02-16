// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class BatchQueryByTemplateKeyRequest : TeaModel {
        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("templateKeys")]
        [Validation(Required=false)]
        public List<string> TemplateKeys { get; set; }

    }

}

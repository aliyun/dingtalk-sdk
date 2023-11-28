// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QuerySchemaAndProcessResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QuerySchemaAndProcessResponseBodyResult Result { get; set; }
        public class QuerySchemaAndProcessResponseBodyResult : TeaModel {
            [NameInMap("appType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("handSignEnable")]
            [Validation(Required=false)]
            public string HandSignEnable { get; set; }

            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("processConfig")]
            [Validation(Required=false)]
            public string ProcessConfig { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class QueryTripProcessTemplatesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryTripProcessTemplatesResponseBodyResult Result { get; set; }
        public class QueryTripProcessTemplatesResponseBodyResult : TeaModel {
            [NameInMap("schemas")]
            [Validation(Required=false)]
            public List<QueryTripProcessTemplatesResponseBodyResultSchemas> Schemas { get; set; }
            public class QueryTripProcessTemplatesResponseBodyResultSchemas : TeaModel {
                [NameInMap("processCode")]
                [Validation(Required=false)]
                public string ProcessCode { get; set; }

                [NameInMap("processName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

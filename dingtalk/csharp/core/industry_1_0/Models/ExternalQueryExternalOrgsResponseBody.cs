// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ExternalQueryExternalOrgsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ExternalQueryExternalOrgsResponseBodyResult> Result { get; set; }
        public class ExternalQueryExternalOrgsResponseBodyResult : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

        }

    }

}

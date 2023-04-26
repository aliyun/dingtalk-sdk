// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryCorpPointsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryCorpPointsResponseBodyResult Result { get; set; }
        public class QueryCorpPointsResponseBodyResult : TeaModel {
            [NameInMap("amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

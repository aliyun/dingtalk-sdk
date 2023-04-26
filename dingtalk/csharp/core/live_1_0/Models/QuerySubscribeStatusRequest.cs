// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class QuerySubscribeStatusRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public QuerySubscribeStatusRequestBody Body { get; set; }
        public class QuerySubscribeStatusRequestBody : TeaModel {
            [NameInMap("liveIds")]
            [Validation(Required=false)]
            public List<string> LiveIds { get; set; }

        }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalBizDataQueryResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public AgoalBizDataQueryResponseBodyContent Content { get; set; }
        public class AgoalBizDataQueryResponseBodyContent : TeaModel {
            [NameInMap("bizInfos")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> BizInfos { get; set; }

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

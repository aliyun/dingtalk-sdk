// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalIndicatorBatchQueryResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<AgoalIndicatorBatchQueryResponseBodyResult> Result { get; set; }
        public class AgoalIndicatorBatchQueryResponseBodyResult : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

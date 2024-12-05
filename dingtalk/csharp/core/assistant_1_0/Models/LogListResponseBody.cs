// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class LogListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public LogListResponseBodyResult Result { get; set; }
        public class LogListResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<LogListResponseBodyResultList> List { get; set; }
            public class LogListResponseBodyResultList : TeaModel {
                [NameInMap("actionNames")]
                [Validation(Required=false)]
                public string ActionNames { get; set; }

                [NameInMap("customChannel")]
                [Validation(Required=false)]
                public string CustomChannel { get; set; }

                [NameInMap("input")]
                [Validation(Required=false)]
                public string Input { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

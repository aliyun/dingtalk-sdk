// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class GetAskDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAskDetailResponseBodyResult Result { get; set; }
        public class GetAskDetailResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<GetAskDetailResponseBodyResultList> List { get; set; }
            public class GetAskDetailResponseBodyResultList : TeaModel {
                [NameInMap("answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                [NameInMap("answerResult")]
                [Validation(Required=false)]
                public string AnswerResult { get; set; }

                [NameInMap("commentTags")]
                [Validation(Required=false)]
                public List<string> CommentTags { get; set; }

                [NameInMap("isMarkResolved")]
                [Validation(Required=false)]
                public bool? IsMarkResolved { get; set; }

                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                [NameInMap("references")]
                [Validation(Required=false)]
                public List<GetAskDetailResponseBodyResultListReferences> References { get; set; }
                public class GetAskDetailResponseBodyResultListReferences : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

            [NameInMap("nextCursor")]
            [Validation(Required=false)]
            public long? NextCursor { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

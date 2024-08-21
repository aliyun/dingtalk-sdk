// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetRelatedViewTabDataResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetRelatedViewTabDataResponseBodyResult Result { get; set; }
        public class GetRelatedViewTabDataResponseBodyResult : TeaModel {
            [NameInMap("page")]
            [Validation(Required=false)]
            public GetRelatedViewTabDataResponseBodyResultPage Page { get; set; }
            public class GetRelatedViewTabDataResponseBodyResultPage : TeaModel {
                [NameInMap("hasMore")]
                [Validation(Required=false)]
                public bool? HasMore { get; set; }

                [NameInMap("list")]
                [Validation(Required=false)]
                public List<GetRelatedViewTabDataResponseBodyResultPageList> List { get; set; }
                public class GetRelatedViewTabDataResponseBodyResultPageList : TeaModel {
                    [NameInMap("abstractMessage")]
                    [Validation(Required=false)]
                    public string AbstractMessage { get; set; }

                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("nextToken")]
                [Validation(Required=false)]
                public long? NextToken { get; set; }

                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

    }

}

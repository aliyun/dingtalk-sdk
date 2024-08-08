// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetRelatedViewTabDataResponseBody : TeaModel {
        [NameInMap("relatedViewTabDataResponse")]
        [Validation(Required=false)]
        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponse RelatedViewTabDataResponse { get; set; }
        public class GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponse : TeaModel {
            [NameInMap("relatedViewTabPageData")]
            [Validation(Required=false)]
            public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData RelatedViewTabPageData { get; set; }
            public class GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData : TeaModel {
                [NameInMap("hasMore")]
                [Validation(Required=false)]
                public bool? HasMore { get; set; }

                [NameInMap("list")]
                [Validation(Required=false)]
                public List<GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList> List { get; set; }
                public class GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList : TeaModel {
                    [NameInMap("abstractMessage")]
                    [Validation(Required=false)]
                    public string AbstractMessage { get; set; }

                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

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

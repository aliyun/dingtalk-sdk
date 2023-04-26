// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class PageFeedResponseBody : TeaModel {
        [NameInMap("feedList")]
        [Validation(Required=false)]
        public List<PageFeedResponseBodyFeedList> FeedList { get; set; }
        public class PageFeedResponseBodyFeedList : TeaModel {
            [NameInMap("feedCategory")]
            [Validation(Required=false)]
            public string FeedCategory { get; set; }

            [NameInMap("feedId")]
            [Validation(Required=false)]
            public string FeedId { get; set; }

            [NameInMap("feedType")]
            [Validation(Required=false)]
            public int? FeedType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("thumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public int? NextCursor { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class GetFeedResponseBody : TeaModel {
        [NameInMap("feedId")]
        [Validation(Required=false)]
        public string FeedId { get; set; }

        [NameInMap("feedItem")]
        [Validation(Required=false)]
        public List<GetFeedResponseBodyFeedItem> FeedItem { get; set; }
        public class GetFeedResponseBodyFeedItem : TeaModel {
            [NameInMap("durationMillis")]
            [Validation(Required=false)]
            public long? DurationMillis { get; set; }

            [NameInMap("feedContentType")]
            [Validation(Required=false)]
            public int? FeedContentType { get; set; }

            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}

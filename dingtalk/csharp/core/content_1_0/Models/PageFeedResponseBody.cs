// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class PageFeedResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("feedList")]
        [Validation(Required=false)]
        public List<PageFeedResponseBodyFeedList> FeedList { get; set; }
        public class PageFeedResponseBodyFeedList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("feedCategory")]
            [Validation(Required=false)]
            public string FeedCategory { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("feedId")]
            [Validation(Required=false)]
            public string FeedId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("feedType")]
            [Validation(Required=false)]
            public int? FeedType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("thumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public int? NextCursor { get; set; }

    }

}

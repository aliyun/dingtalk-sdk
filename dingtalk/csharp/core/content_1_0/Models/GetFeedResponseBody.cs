// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class GetFeedResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("feedId")]
        [Validation(Required=false)]
        public string FeedId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("feedItem")]
        [Validation(Required=false)]
        public List<GetFeedResponseBodyFeedItem> FeedItem { get; set; }
        public class GetFeedResponseBodyFeedItem : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("durationMillis")]
            [Validation(Required=false)]
            public long? DurationMillis { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("feedContentType")]
            [Validation(Required=false)]
            public int? FeedContentType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}

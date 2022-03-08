// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class GetFeedResponseBody : TeaModel {
        /// <summary>
        /// 内容Id
        /// </summary>
        [NameInMap("feedId")]
        [Validation(Required=false)]
        public string FeedId { get; set; }

        /// <summary>
        /// 子内容
        /// </summary>
        [NameInMap("feedItem")]
        [Validation(Required=false)]
        public List<GetFeedResponseBodyFeedItem> FeedItem { get; set; }
        public class GetFeedResponseBodyFeedItem : TeaModel {
            /// <summary>
            /// 子内容的持续时长，单位为毫秒
            /// </summary>
            [NameInMap("durationMillis")]
            [Validation(Required=false)]
            public long? DurationMillis { get; set; }

            /// <summary>
            /// 内容类型，0表示直播，1表示图文，2表示视频，3表示音频
            /// </summary>
            [NameInMap("feedContentType")]
            [Validation(Required=false)]
            public int? FeedContentType { get; set; }

            /// <summary>
            /// 子内容Id
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// 子内容标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 子内容的跳转链接
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}

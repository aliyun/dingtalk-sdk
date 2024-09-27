// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class GetFeedResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3d******-1cd2-<b><b>-ba1d-8</b></b>**3c6dc</para>
        /// </summary>
        [NameInMap("feedId")]
        [Validation(Required=false)]
        public string FeedId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("feedItem")]
        [Validation(Required=false)]
        public List<GetFeedResponseBodyFeedItem> FeedItem { get; set; }
        public class GetFeedResponseBodyFeedItem : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9320</para>
            /// </summary>
            [NameInMap("durationMillis")]
            [Validation(Required=false)]
            public long? DurationMillis { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("feedContentType")]
            [Validation(Required=false)]
            public int? FeedContentType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08<b><b>b5-2442-</b></b>-bd56-99cf****8861</para>
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>子内容标题</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://h5.dingtalk.com/live/video_lesson.htm?feedId=66****03-a825-****-9501-b1eeb****a8d&mcnId=1832**********06173&feedProperty=2&itemId=08****b5-2442-****-bd56-99c*****8861&dd_nav_bgcolor=FF2C2D2F#/video">https://h5.dingtalk.com/live/video_lesson.htm?feedId=66****03-a825-****-9501-b1eeb****a8d&amp;mcnId=1832**********06173&amp;feedProperty=2&amp;itemId=08****b5-2442-****-bd56-99c*****8861&amp;dd_nav_bgcolor=FF2C2D2F#/video</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}

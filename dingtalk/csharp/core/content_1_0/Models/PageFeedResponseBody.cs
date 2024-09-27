// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class PageFeedResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("feedList")]
        [Validation(Required=false)]
        public List<PageFeedResponseBodyFeedList> FeedList { get; set; }
        public class PageFeedResponseBodyFeedList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000257</para>
            /// </summary>
            [NameInMap("feedCategory")]
            [Validation(Required=false)]
            public string FeedCategory { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("feedType")]
            [Validation(Required=false)]
            public int? FeedType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>名称</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://static.dingtalk.com/media/**************NAlg_600_337.jpg">https://static.dingtalk.com/media/**************NAlg_600_337.jpg</a></para>
            /// </summary>
            [NameInMap("thumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://h5.dingtalk.com/live/video_lesson.htm?spm=a1zdd.*******.0.0.3e9617129vSDL8&feedId=5e*****-17ec-45f1-8cc0-e******4a3&mcnId=183206*******06173&feedProperty=1&itemId=5ef7*****-17ec-45f1-8cc0-e64*****954a3&dd_nav_bgcolor=FF2****F#/video">https://h5.dingtalk.com/live/video_lesson.htm?spm=a1zdd.*******.0.0.3e9617129vSDL8&amp;feedId=5e*****-17ec-45f1-8cc0-e******4a3&amp;mcnId=183206*******06173&amp;feedProperty=1&amp;itemId=5ef7*****-17ec-45f1-8cc0-e64*****954a3&amp;dd_nav_bgcolor=FF2****F#/video</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public int? NextCursor { get; set; }

    }

}

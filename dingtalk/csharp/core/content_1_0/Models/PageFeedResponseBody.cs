// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class PageFeedResponseBody : TeaModel {
        /// <summary>
        /// 课程列表
        /// </summary>
        [NameInMap("feedList")]
        [Validation(Required=false)]
        public List<PageFeedResponseBodyFeedList> FeedList { get; set; }
        public class PageFeedResponseBodyFeedList : TeaModel {
            /// <summary>
            /// 内容Id
            /// </summary>
            [NameInMap("feedId")]
            [Validation(Required=false)]
            public string FeedId { get; set; }

            /// <summary>
            /// 内容名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 跳转Url，跳转到职场学堂后台页面
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// 内容类型，0：免费内容 4：平价内容 5：专栏内容 6：训练营内容
            /// </summary>
            [NameInMap("feedType")]
            [Validation(Required=false)]
            public int? FeedType { get; set; }

            /// <summary>
            /// 封面URL
            /// </summary>
            [NameInMap("thumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// 内容分类，请见https://developers.dingtalk.com/document/app/appendix-content
            /// </summary>
            [NameInMap("feedCategory")]
            [Validation(Required=false)]
            public string FeedCategory { get; set; }

        }

        /// <summary>
        /// 分页参数：下一页的起始位置
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public int? NextCursor { get; set; }

        /// <summary>
        /// 分页参数：是否还有下一页，false表示没有下一页
        /// </summary>
        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

    }

}

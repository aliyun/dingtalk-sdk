// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetDentryThumbnailsResponseBody : TeaModel {
        /// <summary>
        /// 缩略图获取结果列表
        /// 最大size:
        /// 	30
        /// </summary>
        [NameInMap("resultItems")]
        [Validation(Required=false)]
        public List<GetDentryThumbnailsResponseBodyResultItems> ResultItems { get; set; }
        public class GetDentryThumbnailsResponseBodyResultItems : TeaModel {
            /// <summary>
            /// 源文件(夹)id
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// 错误原因
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// 源文件(夹)空间id
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// 是否成功获取到缩略图
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// 缩略图信息
            /// </summary>
            [NameInMap("thumbnail")]
            [Validation(Required=false)]
            public GetDentryThumbnailsResponseBodyResultItemsThumbnail Thumbnail { get; set; }
            public class GetDentryThumbnailsResponseBodyResultItemsThumbnail : TeaModel {
                /// <summary>
                /// 缩略图高度
                /// </summary>
                [NameInMap("height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// 缩略图url
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// 缩略图宽度
                /// </summary>
                [NameInMap("width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

        }

    }

}

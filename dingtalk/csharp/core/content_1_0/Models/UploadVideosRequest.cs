// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class UploadVideosRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UploadVideosRequestBody> Body { get; set; }
        public class UploadVideosRequestBody : TeaModel {
            [NameInMap("authorIconUrl")]
            [Validation(Required=false)]
            public string AuthorIconUrl { get; set; }

            [NameInMap("authorId")]
            [Validation(Required=false)]
            public string AuthorId { get; set; }

            [NameInMap("authorName")]
            [Validation(Required=false)]
            public string AuthorName { get; set; }

            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("jumpIconUrl")]
            [Validation(Required=false)]
            public string JumpIconUrl { get; set; }

            [NameInMap("jumpTitle")]
            [Validation(Required=false)]
            public string JumpTitle { get; set; }

            [NameInMap("jumpUrl")]
            [Validation(Required=false)]
            public string JumpUrl { get; set; }

            [NameInMap("videoDuration")]
            [Validation(Required=false)]
            public string VideoDuration { get; set; }

            [NameInMap("videoHeight")]
            [Validation(Required=false)]
            public string VideoHeight { get; set; }

            [NameInMap("videoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

            [NameInMap("videoTitle")]
            [Validation(Required=false)]
            public string VideoTitle { get; set; }

            [NameInMap("videoWidth")]
            [Validation(Required=false)]
            public string VideoWidth { get; set; }

            [NameInMap("webpUrl")]
            [Validation(Required=false)]
            public string WebpUrl { get; set; }

        }

    }

}

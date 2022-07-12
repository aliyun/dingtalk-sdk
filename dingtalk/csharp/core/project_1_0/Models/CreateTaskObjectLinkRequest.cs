// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateTaskObjectLinkRequest : TeaModel {
        /// <summary>
        /// 关联链接对象
        /// </summary>
        [NameInMap("linkedData")]
        [Validation(Required=false)]
        public CreateTaskObjectLinkRequestLinkedData LinkedData { get; set; }
        public class CreateTaskObjectLinkRequestLinkedData : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("thumbnailUrl")]
            [Validation(Required=false)]
            public string ThumbnailUrl { get; set; }
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

    }

}

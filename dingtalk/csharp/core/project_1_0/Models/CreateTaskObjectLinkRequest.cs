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
            /// <summary>
            /// 关联对象描述
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 关联对象头像url
            /// </summary>
            [NameInMap("thumbnailUrl")]
            [Validation(Required=false)]
            public string ThumbnailUrl { get; set; }

            /// <summary>
            /// 关联对象标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 关联对象链接url
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}

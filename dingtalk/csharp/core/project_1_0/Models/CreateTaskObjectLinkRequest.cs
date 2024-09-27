// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateTaskObjectLinkRequest : TeaModel {
        [NameInMap("linkedData")]
        [Validation(Required=false)]
        public CreateTaskObjectLinkRequestLinkedData LinkedData { get; set; }
        public class CreateTaskObjectLinkRequestLinkedData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>我是内容</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://abc.com/url">https://abc.com/url</a></para>
            /// </summary>
            [NameInMap("thumbnailUrl")]
            [Validation(Required=false)]
            public string ThumbnailUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>我是标题</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://abcd.com/url">https://abcd.com/url</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}

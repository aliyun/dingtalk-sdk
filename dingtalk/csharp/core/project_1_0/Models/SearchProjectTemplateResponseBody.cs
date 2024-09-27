// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchProjectTemplateResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchProjectTemplateResponseBodyResult> Result { get; set; }
        public class SearchProjectTemplateResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-13T07:36:50.318Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>我是描述内容</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62e0a88c0axxxx</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isDemo")]
            [Validation(Required=false)]
            public bool? IsDemo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.xxx.com/xxxx">https://www.xxx.com/xxxx</a></para>
            /// </summary>
            [NameInMap("logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>模板1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-13T07:36:50.318Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>organization</para>
            /// </summary>
            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

    }

}

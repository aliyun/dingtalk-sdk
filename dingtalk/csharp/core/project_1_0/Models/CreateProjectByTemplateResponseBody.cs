// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectByTemplateResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateProjectByTemplateResponseBodyResult Result { get; set; }
        public class CreateProjectByTemplateResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-01T09:50:31.275Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62e7a1e721d20b5aexxx</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.xxx.com/xxxxx">https://www.xxx.com/xxxxx</a></para>
            /// </summary>
            [NameInMap("logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>项目1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}

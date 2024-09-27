// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskContentResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateTaskContentResponseBodyResult Result { get; set; }
        public class UpdateTaskContentResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>更改后的标题</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}

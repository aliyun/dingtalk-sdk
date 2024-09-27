// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateTaskObjectLinkResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateTaskObjectLinkResponseBodyResult Result { get; set; }
        public class CreateTaskObjectLinkResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-08-13T07:36:50.318Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("objectLinkId")]
            [Validation(Required=false)]
            public string ObjectLinkId { get; set; }

        }

    }

}

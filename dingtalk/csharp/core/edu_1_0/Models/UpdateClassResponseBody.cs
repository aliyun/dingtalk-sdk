// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateClassResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateClassResponseBodyResult Result { get; set; }
        public class UpdateClassResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>234324</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

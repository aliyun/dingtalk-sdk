// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateGuardianResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateGuardianResponseBodyResult Result { get; set; }
        public class UpdateGuardianResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>234234234</para>
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>234234234</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

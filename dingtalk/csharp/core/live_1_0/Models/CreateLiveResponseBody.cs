// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class CreateLiveResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateLiveResponseBodyResult Result { get; set; }
        public class CreateLiveResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1a353547-040d-4095-bb93-404bc5d47920</para>
            /// </summary>
            [NameInMap("liveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }

        }

    }

}

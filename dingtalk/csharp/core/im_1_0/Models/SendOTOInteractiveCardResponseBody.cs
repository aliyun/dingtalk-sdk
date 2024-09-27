// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendOTOInteractiveCardResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SendOTOInteractiveCardResponseBodyResult Result { get; set; }
        public class SendOTOInteractiveCardResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("processQueryKey")]
            [Validation(Required=false)]
            public string ProcessQueryKey { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendInteractiveCardResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SendInteractiveCardResponseBodyResult Result { get; set; }
        public class SendInteractiveCardResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
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

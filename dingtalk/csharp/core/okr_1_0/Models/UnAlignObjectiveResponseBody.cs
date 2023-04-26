// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UnAlignObjectiveResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public UnAlignObjectiveResponseBodyData Data { get; set; }
        public class UnAlignObjectiveResponseBodyData : TeaModel {
            [NameInMap("alignId")]
            [Validation(Required=false)]
            public Stream AlignId { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public Stream Id { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

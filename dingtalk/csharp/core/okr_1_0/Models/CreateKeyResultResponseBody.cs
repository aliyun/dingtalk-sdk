// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class CreateKeyResultResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateKeyResultResponseBodyData Data { get; set; }
        public class CreateKeyResultResponseBodyData : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public Stream Id { get; set; }

            [NameInMap("position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            [NameInMap("weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

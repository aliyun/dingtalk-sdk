// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class AuthUrlResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public AuthUrlResponseBodyData Data { get; set; }
        public class AuthUrlResponseBodyData : TeaModel {
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}

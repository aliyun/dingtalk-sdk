// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class GetProcessStartUrlResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProcessStartUrlResponseBodyData Data { get; set; }
        public class GetProcessStartUrlResponseBodyData : TeaModel {
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
        };

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}

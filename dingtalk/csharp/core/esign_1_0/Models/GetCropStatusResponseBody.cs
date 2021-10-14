// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class GetCropStatusResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetCropStatusResponseBodyData Data { get; set; }
        public class GetCropStatusResponseBodyData : TeaModel {
            [NameInMap("authStatus")]
            [Validation(Required=false)]
            public string AuthStatus { get; set; }
            [NameInMap("installStatus")]
            [Validation(Required=false)]
            public string InstallStatus { get; set; }
        };

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}

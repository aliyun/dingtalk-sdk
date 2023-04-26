// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetOfficialAccountOTOMessageResultResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetOfficialAccountOTOMessageResultResponseBodyResult Result { get; set; }
        public class GetOfficialAccountOTOMessageResultResponseBodyResult : TeaModel {
            [NameInMap("readUserIdList")]
            [Validation(Required=false)]
            public List<string> ReadUserIdList { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

    }

}

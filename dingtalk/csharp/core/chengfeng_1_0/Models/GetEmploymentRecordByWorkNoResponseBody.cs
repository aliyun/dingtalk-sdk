// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetEmploymentRecordByWorkNoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<CfEmploymentRecordResp> Content { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

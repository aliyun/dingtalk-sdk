// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchCreateClueDataResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<BatchCreateClueDataResponseBodyResult> Result { get; set; }
        public class BatchCreateClueDataResponseBodyResult : TeaModel {
            [NameInMap("clueId")]
            [Validation(Required=false)]
            public string ClueId { get; set; }

            [NameInMap("dataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("resultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

        }

    }

}

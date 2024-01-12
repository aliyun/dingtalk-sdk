// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataDeleteResponseBody : TeaModel {
        [NameInMap("allSuccess")]
        [Validation(Required=false)]
        public bool? AllSuccess { get; set; }

        [NameInMap("failResult")]
        [Validation(Required=false)]
        public List<MasterDataDeleteResponseBodyFailResult> FailResult { get; set; }
        public class MasterDataDeleteResponseBodyFailResult : TeaModel {
            [NameInMap("bizUK")]
            [Validation(Required=false)]
            public string BizUK { get; set; }

            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}

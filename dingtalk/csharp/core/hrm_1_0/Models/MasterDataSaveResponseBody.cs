// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataSaveResponseBody : TeaModel {
        [NameInMap("allSuccess")]
        [Validation(Required=false)]
        public bool? AllSuccess { get; set; }

        [NameInMap("failResult")]
        [Validation(Required=false)]
        public List<MasterDataSaveResponseBodyFailResult> FailResult { get; set; }
        public class MasterDataSaveResponseBodyFailResult : TeaModel {
            [NameInMap("bizUk")]
            [Validation(Required=false)]
            public string BizUk { get; set; }

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

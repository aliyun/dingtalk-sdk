// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmeter_1_0.Models
{
    public class GetResourceUseInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetResourceUseInfoResponseBodyResult> Result { get; set; }
        public class GetResourceUseInfoResponseBodyResult : TeaModel {
            [NameInMap("quotaNum")]
            [Validation(Required=false)]
            public long? QuotaNum { get; set; }

            [NameInMap("usedNum")]
            [Validation(Required=false)]
            public long? UsedNum { get; set; }

        }

    }

}

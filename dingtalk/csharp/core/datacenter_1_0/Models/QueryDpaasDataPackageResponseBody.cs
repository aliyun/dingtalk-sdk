// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryDpaasDataPackageResponseBody : TeaModel {
        [NameInMap("buy")]
        [Validation(Required=false)]
        public bool? Buy { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("usedNum")]
        [Validation(Required=false)]
        public long? UsedNum { get; set; }

        [NameInMap("whiteCustomer")]
        [Validation(Required=false)]
        public bool? WhiteCustomer { get; set; }

    }

}

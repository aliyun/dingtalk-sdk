// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmProcessRegularRequest : TeaModel {
        [NameInMap("operationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        [NameInMap("regularDate")]
        [Validation(Required=false)]
        public long? RegularDate { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

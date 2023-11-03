// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0.Models
{
    public class RevertPointRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public RevertPointRequestBody Body { get; set; }
        public class RevertPointRequestBody : TeaModel {
            [NameInMap("pointPoolCode")]
            [Validation(Required=false)]
            public string PointPoolCode { get; set; }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

    }

}

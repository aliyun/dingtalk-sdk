// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ShiftAddResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ShiftAddResponseBodyResult Result { get; set; }
        public class ShiftAddResponseBodyResult : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("shiftId")]
            [Validation(Required=false)]
            public long? ShiftId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

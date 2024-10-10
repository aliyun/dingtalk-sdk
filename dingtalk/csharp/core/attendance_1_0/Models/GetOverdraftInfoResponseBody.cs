// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetOverdraftInfoResponseBody : TeaModel {
        [NameInMap("overdraftList")]
        [Validation(Required=false)]
        public List<GetOverdraftInfoResponseBodyOverdraftList> OverdraftList { get; set; }
        public class GetOverdraftInfoResponseBodyOverdraftList : TeaModel {
            [NameInMap("overdraft")]
            [Validation(Required=false)]
            public int? Overdraft { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

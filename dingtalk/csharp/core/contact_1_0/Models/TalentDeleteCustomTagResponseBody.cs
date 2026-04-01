// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TalentDeleteCustomTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentDeleteCustomTagResponseBodyResult Result { get; set; }
        public class TalentDeleteCustomTagResponseBodyResult : TeaModel {
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}

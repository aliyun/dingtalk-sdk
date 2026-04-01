// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TalentAddCustomTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentAddCustomTagResponseBodyResult Result { get; set; }
        public class TalentAddCustomTagResponseBodyResult : TeaModel {
            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}

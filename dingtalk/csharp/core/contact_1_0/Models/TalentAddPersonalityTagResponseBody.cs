// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TalentAddPersonalityTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentAddPersonalityTagResponseBodyResult Result { get; set; }
        public class TalentAddPersonalityTagResponseBodyResult : TeaModel {
            [NameInMap("categoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}

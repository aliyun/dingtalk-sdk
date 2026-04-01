// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TalentAddObjectiveTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentAddObjectiveTagResponseBodyResult Result { get; set; }
        public class TalentAddObjectiveTagResponseBodyResult : TeaModel {
            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}

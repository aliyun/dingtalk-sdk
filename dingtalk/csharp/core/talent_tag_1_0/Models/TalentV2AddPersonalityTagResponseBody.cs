// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktalent_tag_1_0.Models
{
    public class TalentV2AddPersonalityTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentV2AddPersonalityTagResponseBodyResult Result { get; set; }
        public class TalentV2AddPersonalityTagResponseBodyResult : TeaModel {
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

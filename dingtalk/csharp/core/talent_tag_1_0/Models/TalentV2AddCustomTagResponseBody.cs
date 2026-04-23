// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktalent_tag_1_0.Models
{
    public class TalentV2AddCustomTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentV2AddCustomTagResponseBodyResult Result { get; set; }
        public class TalentV2AddCustomTagResponseBodyResult : TeaModel {
            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}

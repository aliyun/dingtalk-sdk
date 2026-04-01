// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TalentQueryCustomTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentQueryCustomTagResponseBodyResult Result { get; set; }
        public class TalentQueryCustomTagResponseBodyResult : TeaModel {
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<TalentQueryCustomTagResponseBodyResultTags> Tags { get; set; }
            public class TalentQueryCustomTagResponseBodyResultTags : TeaModel {
                [NameInMap("sortOrder")]
                [Validation(Required=false)]
                public int? SortOrder { get; set; }

                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

                [NameInMap("tagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

        }

    }

}

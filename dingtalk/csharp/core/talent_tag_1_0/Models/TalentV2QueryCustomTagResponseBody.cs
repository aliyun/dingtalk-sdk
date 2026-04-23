// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktalent_tag_1_0.Models
{
    public class TalentV2QueryCustomTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentV2QueryCustomTagResponseBodyResult Result { get; set; }
        public class TalentV2QueryCustomTagResponseBodyResult : TeaModel {
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<TalentV2QueryCustomTagResponseBodyResultTags> Tags { get; set; }
            public class TalentV2QueryCustomTagResponseBodyResultTags : TeaModel {
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

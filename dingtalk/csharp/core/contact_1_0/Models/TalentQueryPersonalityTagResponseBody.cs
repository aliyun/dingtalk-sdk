// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TalentQueryPersonalityTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TalentQueryPersonalityTagResponseBodyResult Result { get; set; }
        public class TalentQueryPersonalityTagResponseBodyResult : TeaModel {
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<TalentQueryPersonalityTagResponseBodyResultTags> Tags { get; set; }
            public class TalentQueryPersonalityTagResponseBodyResultTags : TeaModel {
                [NameInMap("categoryCode")]
                [Validation(Required=false)]
                public string CategoryCode { get; set; }

                [NameInMap("categoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                [NameInMap("categorySortOrder")]
                [Validation(Required=false)]
                public int? CategorySortOrder { get; set; }

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

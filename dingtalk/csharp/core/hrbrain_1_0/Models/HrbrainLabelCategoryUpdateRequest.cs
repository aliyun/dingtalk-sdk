// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainLabelCategoryUpdateRequest : TeaModel {
        [NameInMap("categoryVo")]
        [Validation(Required=false)]
        public HrbrainLabelCategoryUpdateRequestCategoryVo CategoryVo { get; set; }
        public class HrbrainLabelCategoryUpdateRequestCategoryVo : TeaModel {
            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<HrbrainLabelCategoryUpdateRequestCategoryVoCategories> Categories { get; set; }
            public class HrbrainLabelCategoryUpdateRequestCategoryVoCategories : TeaModel {
                [NameInMap("children")]
                [Validation(Required=false)]
                public List<object> Children { get; set; }

                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("pCode")]
                [Validation(Required=false)]
                public string PCode { get; set; }

                [NameInMap("sortSize")]
                [Validation(Required=false)]
                public string SortSize { get; set; }

            }

        }

    }

}

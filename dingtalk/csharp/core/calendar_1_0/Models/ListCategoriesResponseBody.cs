// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListCategoriesResponseBody : TeaModel {
        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<ListCategoriesResponseBodyCategories> Categories { get; set; }
        public class ListCategoriesResponseBodyCategories : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("openCategoryId")]
            [Validation(Required=false)]
            public string OpenCategoryId { get; set; }

        }

    }

}

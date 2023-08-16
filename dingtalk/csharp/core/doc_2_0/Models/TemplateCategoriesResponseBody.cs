// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class TemplateCategoriesResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<TemplateCategoriesResponseBodyList> List { get; set; }
        public class TemplateCategoriesResponseBodyList : TeaModel {
            [NameInMap("categoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("sort")]
            [Validation(Required=false)]
            public string Sort { get; set; }

        }

    }

}

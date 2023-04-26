// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class QueryTemplateCategorysResponseBody : TeaModel {
        [NameInMap("categoryList")]
        [Validation(Required=false)]
        public List<QueryTemplateCategorysResponseBodyCategoryList> CategoryList { get; set; }
        public class QueryTemplateCategorysResponseBodyCategoryList : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class QueryTemplateCategorysResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("categoryList")]
        [Validation(Required=false)]
        public List<QueryTemplateCategorysResponseBodyCategoryList> CategoryList { get; set; }
        public class QueryTemplateCategorysResponseBodyCategoryList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}

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
            /// <summary>
            /// 分类编码
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 分类名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}

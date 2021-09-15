// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryCategoryByPageResponseBody : TeaModel {
        /// <summary>
        /// resultList
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCategoryByPageResponseBodyList> List { get; set; }
        public class QueryCategoryByPageResponseBodyList : TeaModel {
            /// <summary>
            /// 类别code
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 类型:income收入，expense支出
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 名字
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 是否为目录
            /// </summary>
            [NameInMap("isDir")]
            [Validation(Required=false)]
            public bool? IsDir { get; set; }

            /// <summary>
            /// 父类别code
            /// </summary>
            [NameInMap("parentCode")]
            [Validation(Required=false)]
            public string ParentCode { get; set; }

            /// <summary>
            /// 状态:valid,invalid,deleted
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

    }

}

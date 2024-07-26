// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryCategoryByPageResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCategoryByPageResponseBodyList> List { get; set; }
        public class QueryCategoryByPageResponseBodyList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("isDir")]
            [Validation(Required=false)]
            public bool? IsDir { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("parentCode")]
            [Validation(Required=false)]
            public string ParentCode { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}

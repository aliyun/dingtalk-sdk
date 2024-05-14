// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryProjectByPageResponseBody : TeaModel {
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
        public List<QueryProjectByPageResponseBodyList> List { get; set; }
        public class QueryProjectByPageResponseBodyList : TeaModel {
            [NameInMap("caode")]
            [Validation(Required=false)]
            public string Caode { get; set; }

            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("projectCode")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("userDefineCode")]
            [Validation(Required=false)]
            public string UserDefineCode { get; set; }

        }

    }

}

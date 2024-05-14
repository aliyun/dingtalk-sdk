// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserExtendValuesResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryUserExtendValuesResponseBodyContent> Content { get; set; }
        public class QueryUserExtendValuesResponseBodyContent : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userCode")]
            [Validation(Required=false)]
            public string UserCode { get; set; }

            [NameInMap("userExtendDisplayName")]
            [Validation(Required=false)]
            public string UserExtendDisplayName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userExtendKey")]
            [Validation(Required=false)]
            public string UserExtendKey { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userExtendValue")]
            [Validation(Required=false)]
            public string UserExtendValue { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

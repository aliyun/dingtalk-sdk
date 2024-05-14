// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserExtInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryUserExtInfoResponseBodyContent> Content { get; set; }
        public class QueryUserExtInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userCode")]
            [Validation(Required=false)]
            public string UserCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
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

    }

}

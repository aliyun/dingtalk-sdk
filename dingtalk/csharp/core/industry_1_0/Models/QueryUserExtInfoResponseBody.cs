// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserExtInfoResponseBody : TeaModel {
        /// <summary>
        /// 扩展属性
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryUserExtInfoResponseBodyContent> Content { get; set; }
        public class QueryUserExtInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// 扩展属性Key
            /// </summary>
            [NameInMap("userExtendKey")]
            [Validation(Required=false)]
            public string UserExtendKey { get; set; }

            /// <summary>
            /// 扩展属性值
            /// </summary>
            [NameInMap("userExtendValue")]
            [Validation(Required=false)]
            public string UserExtendValue { get; set; }

            /// <summary>
            /// 扩展属性描述
            /// </summary>
            [NameInMap("userExtendDisplayName")]
            [Validation(Required=false)]
            public string UserExtendDisplayName { get; set; }

        }

    }

}

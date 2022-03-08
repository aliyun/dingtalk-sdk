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
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// 组织id
            /// </summary>
            [NameInMap("orgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// 状态：0-有效，1-无效
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 用户标识
            /// </summary>
            [NameInMap("userCode")]
            [Validation(Required=false)]
            public string UserCode { get; set; }

            /// <summary>
            /// 扩展属性描述
            /// </summary>
            [NameInMap("userExtendDisplayName")]
            [Validation(Required=false)]
            public string UserExtendDisplayName { get; set; }

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

        }

    }

}

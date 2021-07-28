// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserProbCodeDictionaryResponseBody : TeaModel {
        /// <summary>
        /// code列表
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryUserProbCodeDictionaryResponseBodyContent> Content { get; set; }
        public class QueryUserProbCodeDictionaryResponseBodyContent : TeaModel {
            /// <summary>
            /// 固定字段标识
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 分类
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// 展示名字
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

    }

}

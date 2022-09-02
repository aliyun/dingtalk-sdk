// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetRecycleBinResponseBody : TeaModel {
        /// <summary>
        /// 回收站信息
        /// </summary>
        [NameInMap("recycleBin")]
        [Validation(Required=false)]
        public GetRecycleBinResponseBodyRecycleBin RecycleBin { get; set; }
        public class GetRecycleBinResponseBodyRecycleBin : TeaModel {
            /// <summary>
            /// 回收站id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 回收站范围类型
            /// 枚举值:
            /// 	ORG: 企业
            /// 	APP: 应用
            /// 	SPACE: 空间
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// 回收站范围id
            /// 根据recycleBinScope传入对应的企业、应用、空间ID
            /// </summary>
            [NameInMap("scopeId")]
            [Validation(Required=false)]
            public string ScopeId { get; set; }

        }

    }

}

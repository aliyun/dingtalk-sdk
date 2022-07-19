// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetRecycleBinRequest : TeaModel {
        /// <summary>
        /// 回收站范围类型
        /// 枚举值:
        /// 	ORG: 企业
        /// 	APP: 应用
        /// 	SPACE: 空间
        /// </summary>
        [NameInMap("recycleBinScope")]
        [Validation(Required=false)]
        public string RecycleBinScope { get; set; }

        /// <summary>
        /// 回收站范围id
        /// 根据recycleBinScope传入对应的企业、应用、空间ID
        /// </summary>
        [NameInMap("scopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

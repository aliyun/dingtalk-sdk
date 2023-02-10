// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class UnsubscribeEventRequest : TeaModel {
        /// <summary>
        /// 订阅范围
        /// 枚举值:
        /// 	ORG: 企业
        /// 	SPACE: 空间
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// 订阅范围对应的id
        /// scope为ORG时，scopeId对应的是企业id
        /// scope为SPACE时，scopeId对应的是空间id
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

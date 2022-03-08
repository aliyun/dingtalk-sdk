// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserExtendValuesRequest : TeaModel {
        /// <summary>
        /// 用户拓展key
        /// </summary>
        [NameInMap("userExtendKey")]
        [Validation(Required=false)]
        public string UserExtendKey { get; set; }

        /// <summary>
        /// userId列表
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}

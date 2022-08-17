// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class QuerySubscribeStatusRequest : TeaModel {
        /// <summary>
        /// post请求体, 开放平台建议以对象形式存储
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public QuerySubscribeStatusRequestBody Body { get; set; }
        public class QuerySubscribeStatusRequestBody : TeaModel {
            [NameInMap("liveIds")]
            [Validation(Required=false)]
            public List<string> LiveIds { get; set; }
        };

        /// <summary>
        /// 用户id（主播id）
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

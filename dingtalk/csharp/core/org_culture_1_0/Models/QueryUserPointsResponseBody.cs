// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryUserPointsResponseBody : TeaModel {
        /// <summary>
        /// 响应数据
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryUserPointsResponseBodyResult Result { get; set; }
        public class QueryUserPointsResponseBodyResult : TeaModel {
            [NameInMap("amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }
        };

        /// <summary>
        /// 请求响应状态
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

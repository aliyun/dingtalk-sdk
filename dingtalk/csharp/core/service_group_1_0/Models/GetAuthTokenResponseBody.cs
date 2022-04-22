// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetAuthTokenResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("dingOpenErrcode")]
        [Validation(Required=false)]
        public int? DingOpenErrcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 返回的对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAuthTokenResponseBodyResult Result { get; set; }
        public class GetAuthTokenResponseBodyResult : TeaModel {
            [NameInMap("authToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }
            [NameInMap("channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }
            [NameInMap("effectiveTime")]
            [Validation(Required=false)]
            public long? EffectiveTime { get; set; }
            [NameInMap("serverId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }
            [NameInMap("serverName")]
            [Validation(Required=false)]
            public string ServerName { get; set; }
        };

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

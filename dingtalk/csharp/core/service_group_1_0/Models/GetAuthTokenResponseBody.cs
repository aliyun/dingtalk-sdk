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
            /// <summary>
            /// token
            /// </summary>
            [NameInMap("authToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// 小二渠道来源 DT/LINKS
            /// </summary>
            [NameInMap("channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// token有效期秒
            /// </summary>
            [NameInMap("effectiveTime")]
            [Validation(Required=false)]
            public long? EffectiveTime { get; set; }

            /// <summary>
            /// 小二id
            /// </summary>
            [NameInMap("serverId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// 小二名称
            /// </summary>
            [NameInMap("serverName")]
            [Validation(Required=false)]
            public string ServerName { get; set; }

        }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

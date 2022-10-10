// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateStsTokenResponseBody : TeaModel {
        /// <summary>
        /// keyId
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// KeySecret
        /// </summary>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// 过期时间，默认1小时过期
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 授权的token
        /// </summary>
        [NameInMap("securityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

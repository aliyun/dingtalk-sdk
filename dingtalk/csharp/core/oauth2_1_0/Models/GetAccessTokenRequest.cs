/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetAccessTokenRequest : TeaModel {
        /// <summary>
        /// 应用id
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// 应用密码
        /// </summary>
        [NameInMap("appSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

    }

}

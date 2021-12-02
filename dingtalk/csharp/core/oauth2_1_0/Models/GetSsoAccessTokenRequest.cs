// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetSsoAccessTokenRequest : TeaModel {
        /// <summary>
        /// 企业id
        /// </summary>
        [NameInMap("corpid")]
        [Validation(Required=false)]
        public string Corpid { get; set; }

        /// <summary>
        /// sso密码
        /// </summary>
        [NameInMap("ssoSecret")]
        [Validation(Required=false)]
        public string SsoSecret { get; set; }

    }

}

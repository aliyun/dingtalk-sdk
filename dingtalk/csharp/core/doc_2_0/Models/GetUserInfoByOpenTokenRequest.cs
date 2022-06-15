// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetUserInfoByOpenTokenRequest : TeaModel {
        /// <summary>
        /// 文档docKey，标识一篇文档的key。
        /// </summary>
        [NameInMap("docKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

        /// <summary>
        /// 文档颁发给三方应用的 OpenToken，用于三方应用在文档中的免登。
        /// </summary>
        [NameInMap("openToken")]
        [Validation(Required=false)]
        public string OpenToken { get; set; }

    }

}

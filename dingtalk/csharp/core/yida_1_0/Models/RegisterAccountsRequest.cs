// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class RegisterAccountsRequest : TeaModel {
        /// <summary>
        /// 组织id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 访问秘钥
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 激活码
        /// </summary>
        [NameInMap("activeCode")]
        [Validation(Required=false)]
        public string ActiveCode { get; set; }

    }

}

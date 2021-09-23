// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class SearchActivationCodeRequest : TeaModel {
        /// <summary>
        /// 访问key
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 用户的uid
        /// </summary>
        [NameInMap("callerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

    }

}

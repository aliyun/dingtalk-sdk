// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class SearchActivationCodeRequest : TeaModel {
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("callerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

    }

}

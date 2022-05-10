// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveAndSubmitAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// 密匙ID
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// OSS链接
        /// </summary>
        [NameInMap("oss")]
        [Validation(Required=false)]
        public string Oss { get; set; }

    }

}

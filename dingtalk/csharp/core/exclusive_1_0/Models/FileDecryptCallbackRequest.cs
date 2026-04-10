// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class FileDecryptCallbackRequest : TeaModel {
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("decryptFileSize")]
        [Validation(Required=false)]
        public long? DecryptFileSize { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}

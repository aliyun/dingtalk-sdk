// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class GetImportEncryptPublicKeyResponseBody : TeaModel {
        [NameInMap("algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("expireAt")]
        [Validation(Required=false)]
        public long? ExpireAt { get; set; }

        [NameInMap("keyVersion")]
        [Validation(Required=false)]
        public string KeyVersion { get; set; }

        [NameInMap("publicKeyPem")]
        [Validation(Required=false)]
        public string PublicKeyPem { get; set; }

    }

}

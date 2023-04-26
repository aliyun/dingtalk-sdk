// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class FileStorageActiveStorageResponseBody : TeaModel {
        [NameInMap("createDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        [NameInMap("fileStorageOpenStatus")]
        [Validation(Required=false)]
        public int? FileStorageOpenStatus { get; set; }

        [NameInMap("storageStatus")]
        [Validation(Required=false)]
        public int? StorageStatus { get; set; }

        [NameInMap("usedQuota")]
        [Validation(Required=false)]
        public long? UsedQuota { get; set; }

    }

}

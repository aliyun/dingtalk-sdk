// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class FileStorageCheckConnectionResponseBody : TeaModel {
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("checkState")]
        [Validation(Required=false)]
        public int? CheckState { get; set; }

        [NameInMap("oss")]
        [Validation(Required=false)]
        public string Oss { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class FileStorageCheckConnectionResponseBody : TeaModel {
        /// <summary>
        /// 密匙ID
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 检测oss状态 0正常1异常
        /// </summary>
        [NameInMap("checkState")]
        [Validation(Required=false)]
        public int? CheckState { get; set; }

        /// <summary>
        /// OSS链接
        /// </summary>
        [NameInMap("oss")]
        [Validation(Required=false)]
        public string Oss { get; set; }

    }

}

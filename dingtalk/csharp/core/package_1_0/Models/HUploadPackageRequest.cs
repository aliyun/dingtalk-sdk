// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpackage_1_0.Models
{
    public class HUploadPackageRequest : TeaModel {
        /// <summary>
        /// 离线包ID
        /// </summary>
        [NameInMap("miniAppId")]
        [Validation(Required=false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 离线包资源OSS Key
        /// </summary>
        [NameInMap("ossObjectKey")]
        [Validation(Required=false)]
        public string OssObjectKey { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class RollbackInnerAppVersionRequest : TeaModel {
        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("opUnionId")]
        [Validation(Required=false)]
        public string OpUnionId { get; set; }

        /// <summary>
        /// 小程序版本id
        /// </summary>
        [NameInMap("versionId")]
        [Validation(Required=false)]
        public long? VersionId { get; set; }

    }

}

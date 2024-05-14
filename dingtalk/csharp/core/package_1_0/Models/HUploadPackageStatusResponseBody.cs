// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpackage_1_0.Models
{
    public class HUploadPackageStatusResponseBody : TeaModel {
        [NameInMap("buildTime")]
        [Validation(Required=false)]
        public long? BuildTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("finished")]
        [Validation(Required=false)]
        public bool? Finished { get; set; }

        [NameInMap("packageSize")]
        [Validation(Required=false)]
        public long? PackageSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

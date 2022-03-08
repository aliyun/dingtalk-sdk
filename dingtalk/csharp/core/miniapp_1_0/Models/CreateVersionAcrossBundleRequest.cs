// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminiapp_1_0.Models
{
    public class CreateVersionAcrossBundleRequest : TeaModel {
        /// <summary>
        /// bundleId
        /// </summary>
        [NameInMap("bundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("miniAppId")]
        [Validation(Required=false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// sourceBundleId
        /// </summary>
        [NameInMap("sourceBundleId")]
        [Validation(Required=false)]
        public string SourceBundleId { get; set; }

        /// <summary>
        /// sourceVersion
        /// </summary>
        [NameInMap("sourceVersion")]
        [Validation(Required=false)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// version
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

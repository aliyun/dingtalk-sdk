// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminiapp_1_0.Models
{
    public class ListAvaiableVersionResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<ListAvaiableVersionResponseBodyVersions> Versions { get; set; }
        public class ListAvaiableVersionResponseBodyVersions : TeaModel {
            [NameInMap("packageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            [NameInMap("packageSize")]
            [Validation(Required=false)]
            public string PackageSize { get; set; }

            [NameInMap("buildStatus")]
            [Validation(Required=false)]
            public long? BuildStatus { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("h5Bundle")]
            [Validation(Required=false)]
            public string H5Bundle { get; set; }

        }

    }

}

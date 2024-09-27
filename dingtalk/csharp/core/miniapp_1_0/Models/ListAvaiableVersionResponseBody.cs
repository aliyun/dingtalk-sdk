// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminiapp_1_0.Models
{
    public class ListAvaiableVersionResponseBody : TeaModel {
        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<ListAvaiableVersionResponseBodyVersions> Versions { get; set; }
        public class ListAvaiableVersionResponseBodyVersions : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("buildStatus")]
            [Validation(Required=false)]
            public long? BuildStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("h5Bundle")]
            [Validation(Required=false)]
            public string H5Bundle { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("packageSize")]
            [Validation(Required=false)]
            public string PackageSize { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("packageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}

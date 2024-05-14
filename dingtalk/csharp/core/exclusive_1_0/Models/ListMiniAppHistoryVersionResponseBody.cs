// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListMiniAppHistoryVersionResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListMiniAppHistoryVersionResponseBodyList> List { get; set; }
        public class ListMiniAppHistoryVersionResponseBodyList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("buildStatus")]
            [Validation(Required=false)]
            public long? BuildStatus { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("h5Bundle")]
            [Validation(Required=false)]
            public string H5Bundle { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("packageSize")]
            [Validation(Required=false)]
            public string PackageSize { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("packageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}

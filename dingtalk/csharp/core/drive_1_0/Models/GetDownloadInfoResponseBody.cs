// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetDownloadInfoResponseBody : TeaModel {
        [NameInMap("downloadInfo")]
        [Validation(Required=false)]
        public GetDownloadInfoResponseBodyDownloadInfo DownloadInfo { get; set; }
        public class GetDownloadInfoResponseBodyDownloadInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("expirationSeconds")]
            [Validation(Required=false)]
            public int? ExpirationSeconds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, object> Headers { get; set; }

            [NameInMap("internalResourceUrl")]
            [Validation(Required=false)]
            public string InternalResourceUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("resourceUrl")]
            [Validation(Required=false)]
            public string ResourceUrl { get; set; }

        }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}

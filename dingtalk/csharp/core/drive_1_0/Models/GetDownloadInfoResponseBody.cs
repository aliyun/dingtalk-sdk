// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetDownloadInfoResponseBody : TeaModel {
        /// <summary>
        /// 下载加签url信息
        /// </summary>
        [NameInMap("downloadInfo")]
        [Validation(Required=false)]
        public GetDownloadInfoResponseBodyDownloadInfo DownloadInfo { get; set; }
        public class GetDownloadInfoResponseBodyDownloadInfo : TeaModel {
            /// <summary>
            /// 加签url过期时间
            /// </summary>
            [NameInMap("expirationSeconds")]
            [Validation(Required=false)]
            public int? ExpirationSeconds { get; set; }

            /// <summary>
            /// headers
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, object> Headers { get; set; }

            /// <summary>
            /// 内网加签url
            /// </summary>
            [NameInMap("internalResourceUrl")]
            [Validation(Required=false)]
            public string InternalResourceUrl { get; set; }

            /// <summary>
            /// 加签url
            /// </summary>
            [NameInMap("resourceUrl")]
            [Validation(Required=false)]
            public string ResourceUrl { get; set; }

        }

        /// <summary>
        /// 文件所存储的区域
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}

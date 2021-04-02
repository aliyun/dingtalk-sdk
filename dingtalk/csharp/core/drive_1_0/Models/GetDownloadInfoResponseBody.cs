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
        [NameInMap("presignedUrlDownloadInfo")]
        [Validation(Required=false)]
        public GetDownloadInfoResponseBodyPresignedUrlDownloadInfo PresignedUrlDownloadInfo { get; set; }
        public class GetDownloadInfoResponseBodyPresignedUrlDownloadInfo : TeaModel {
            [NameInMap("resourceUrl")]
            [Validation(Required=false)]
            public string ResourceUrl { get; set; }
            [NameInMap("expiration")]
            [Validation(Required=false)]
            public int? Expiration { get; set; }
        };

    }

}

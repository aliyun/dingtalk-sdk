// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetFileDownloadInfoResponseBody : TeaModel {
        /// <summary>
        /// Header加签信息, 当protocol等于HEADER_SIGNATURE时，此字段生效
        /// </summary>
        [NameInMap("headerSignatureInfo")]
        [Validation(Required=false)]
        public GetFileDownloadInfoResponseBodyHeaderSignatureInfo HeaderSignatureInfo { get; set; }
        public class GetFileDownloadInfoResponseBodyHeaderSignatureInfo : TeaModel {
            [NameInMap("expirationSeconds")]
            [Validation(Required=false)]
            public int? ExpirationSeconds { get; set; }
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }
            [NameInMap("internalResourceUrls")]
            [Validation(Required=false)]
            public List<string> InternalResourceUrls { get; set; }
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("resourceUrls")]
            [Validation(Required=false)]
            public List<string> ResourceUrls { get; set; }
        };

        /// <summary>
        /// 文件下载协议
        /// 枚举值:
        /// 	HEADER_SIGNATURE: Header加签
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}

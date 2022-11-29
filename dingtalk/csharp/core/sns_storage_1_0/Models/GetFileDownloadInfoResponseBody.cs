// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksns_storage_1_0.Models
{
    public class GetFileDownloadInfoResponseBody : TeaModel {
        /// <summary>
        /// Header加签信息, 当protocol等于HEADER_SIGNATURE时，此字段生效
        /// </summary>
        [NameInMap("headerSignatureInfo")]
        [Validation(Required=false)]
        public GetFileDownloadInfoResponseBodyHeaderSignatureInfo HeaderSignatureInfo { get; set; }
        public class GetFileDownloadInfoResponseBodyHeaderSignatureInfo : TeaModel {
            /// <summary>
            /// 过期时间，单位秒
            /// </summary>
            [NameInMap("expirationSeconds")]
            [Validation(Required=false)]
            public int? ExpirationSeconds { get; set; }

            /// <summary>
            /// 请求头
            /// 最大size:
            /// 	20
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// 内网URL, 在网络连通的情况下，使用内网URL可加速服务器间上传
            /// 最大size:
            /// 	10
            /// </summary>
            [NameInMap("internalResourceUrls")]
            [Validation(Required=false)]
            public List<string> InternalResourceUrls { get; set; }

            /// <summary>
            /// 地域
            /// 枚举值:
            /// 	ZHANGJIAKOU: 张家口
            /// 	SHENZHEN: 深圳
            /// 	SHANGHAI: 上海
            /// 	SINGAPORE: 新加坡
            /// 	UNKNOWN: 未知
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// 多个上传下载URL, 前面url优先
            /// 最大size:
            /// 	10
            /// </summary>
            [NameInMap("resourceUrls")]
            [Validation(Required=false)]
            public List<string> ResourceUrls { get; set; }

        }

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

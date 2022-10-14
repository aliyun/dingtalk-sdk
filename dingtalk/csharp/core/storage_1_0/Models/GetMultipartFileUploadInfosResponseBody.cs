// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetMultipartFileUploadInfosResponseBody : TeaModel {
        /// <summary>
        /// 分片Header加签上传信息列表
        /// </summary>
        [NameInMap("multipartHeaderSignatureInfos")]
        [Validation(Required=false)]
        public List<GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos> MultipartHeaderSignatureInfos { get; set; }
        public class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos : TeaModel {
            /// <summary>
            /// header信息
            /// </summary>
            [NameInMap("headerSignatureInfo")]
            [Validation(Required=false)]
            public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo HeaderSignatureInfo { get; set; }
            public class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo : TeaModel {
                /// <summary>
                /// 过期时间，单位秒
                /// </summary>
                [NameInMap("expirationSeconds")]
                [Validation(Required=false)]
                public int? ExpirationSeconds { get; set; }

                /// <summary>
                /// 请求头
                /// </summary>
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// 内网URL, 在网络连通的情况下，使用内网URL可加速服务器间上传
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
                /// </summary>
                [NameInMap("resourceUrls")]
                [Validation(Required=false)]
                public List<string> ResourceUrls { get; set; }

            }

            /// <summary>
            /// 分片number
            /// </summary>
            [NameInMap("partNumber")]
            [Validation(Required=false)]
            public int? PartNumber { get; set; }

        }

    }

}

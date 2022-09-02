// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetUploadInfoResponseBody : TeaModel {
        [NameInMap("headerSignatureUploadInfo")]
        [Validation(Required=false)]
        public GetUploadInfoResponseBodyHeaderSignatureUploadInfo HeaderSignatureUploadInfo { get; set; }
        public class GetUploadInfoResponseBodyHeaderSignatureUploadInfo : TeaModel {
            /// <summary>
            /// 过期秒数
            /// </summary>
            [NameInMap("expirationSeconds")]
            [Validation(Required=false)]
            public int? ExpirationSeconds { get; set; }

            /// <summary>
            /// header加签信息
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, object> Headers { get; set; }

            /// <summary>
            /// 内网上传地址
            /// </summary>
            [NameInMap("internalResourceUrl")]
            [Validation(Required=false)]
            public string InternalResourceUrl { get; set; }

            /// <summary>
            /// mediaId
            /// </summary>
            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// 上传地址
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

        [NameInMap("stsUploadInfo")]
        [Validation(Required=false)]
        public GetUploadInfoResponseBodyStsUploadInfo StsUploadInfo { get; set; }
        public class GetUploadInfoResponseBodyStsUploadInfo : TeaModel {
            /// <summary>
            /// accessKeyId
            /// </summary>
            [NameInMap("accessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// accessKeySecret
            /// </summary>
            [NameInMap("accessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// accessToken
            /// </summary>
            [NameInMap("accessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// accessTokenExpiration
            /// </summary>
            [NameInMap("accessTokenExpirationMillis")]
            [Validation(Required=false)]
            public long? AccessTokenExpirationMillis { get; set; }

            /// <summary>
            /// bucket
            /// </summary>
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// endPoint
            /// </summary>
            [NameInMap("endPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            /// <summary>
            /// 内网endPoint
            /// </summary>
            [NameInMap("internalEndPoint")]
            [Validation(Required=false)]
            public string InternalEndPoint { get; set; }

            /// <summary>
            /// mediaId
            /// </summary>
            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

    }

}

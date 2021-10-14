// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class GetFileUploadInfoResponseBody : TeaModel {
        /// <summary>
        /// OSS上传所需信息：accessKeyId
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// OSS上传所需信息：accessKeySecret
        /// </summary>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// OSS上传所需信息：accessToken
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// accessToken有效期截止时间（单位：毫秒），需要在此时间之前完成文件上传
        /// </summary>
        [NameInMap("accessTokenExpirationMillis")]
        [Validation(Required=false)]
        public long? AccessTokenExpirationMillis { get; set; }

        /// <summary>
        /// OSS上传所需信息：bucket
        /// </summary>
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// OSS上传所需信息：endPoint
        /// </summary>
        [NameInMap("endPoint")]
        [Validation(Required=false)]
        public string EndPoint { get; set; }

        /// <summary>
        /// 文件mediaId
        /// </summary>
        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

    }

}

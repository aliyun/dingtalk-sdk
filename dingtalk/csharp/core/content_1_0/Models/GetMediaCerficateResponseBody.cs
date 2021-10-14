// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class GetMediaCerficateResponseBody : TeaModel {
        /// <summary>
        /// 媒体文件ID
        /// </summary>
        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// 上传授权密钥ID
        /// </summary>
        [NameInMap("ossAccessKeyId")]
        [Validation(Required=false)]
        public string OssAccessKeyId { get; set; }

        /// <summary>
        /// 上传授权密钥
        /// </summary>
        [NameInMap("ossAccessKeySecret")]
        [Validation(Required=false)]
        public string OssAccessKeySecret { get; set; }

        /// <summary>
        /// OSS Bucket名称
        /// </summary>
        [NameInMap("ossBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// OSS区域地址
        /// </summary>
        [NameInMap("ossEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// 凭证有效时间(单位秒)，当上传凭证过期时，需要重新使用本次返回的videoId重新调用接口进行凭证刷新
        /// </summary>
        [NameInMap("ossExpiration")]
        [Validation(Required=false)]
        public string OssExpiration { get; set; }

        /// <summary>
        /// 分配的媒体文件名
        /// </summary>
        [NameInMap("ossFileName")]
        [Validation(Required=false)]
        public string OssFileName { get; set; }

        /// <summary>
        /// 上传授权安全令牌
        /// </summary>
        [NameInMap("ossSecurityToken")]
        [Validation(Required=false)]
        public string OssSecurityToken { get; set; }

    }

}

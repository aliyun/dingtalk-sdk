// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpackage_1_0.Models
{
    public class GetUploadTokenResponseBody : TeaModel {
        /// <summary>
        /// 阿里云OSS SDK初始化配置项
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 阿里云OSS SDK初始化配置项
        /// </summary>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// 阿里云OSS SDK初始化配置项
        /// </summary>
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// 阿里云OSS SDK初始化配置项
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 阿里云OSS SDK初始化配置项
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// 阿里云OSS SDK初始化配置项
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 阿里云OSS SDK初始化配置项
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// 阿里云OSS SDK初始化配置项
        /// </summary>
        [NameInMap("stsToken")]
        [Validation(Required=false)]
        public string StsToken { get; set; }

    }

}

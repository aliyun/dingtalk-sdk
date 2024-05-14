// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class GetMediaCerficateResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ossAccessKeyId")]
        [Validation(Required=false)]
        public string OssAccessKeyId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ossAccessKeySecret")]
        [Validation(Required=false)]
        public string OssAccessKeySecret { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ossBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ossEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ossExpiration")]
        [Validation(Required=false)]
        public string OssExpiration { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ossFileName")]
        [Validation(Required=false)]
        public string OssFileName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ossSecurityToken")]
        [Validation(Required=false)]
        public string OssSecurityToken { get; set; }

    }

}

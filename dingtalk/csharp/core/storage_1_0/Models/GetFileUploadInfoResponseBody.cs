// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetFileUploadInfoResponseBody : TeaModel {
        /// <summary>
        /// Header加签上传信息, 当protocol等于HEADER_SIGNATURE时，此字段生效
        /// </summary>
        [NameInMap("headerSignatureInfo")]
        [Validation(Required=false)]
        public GetFileUploadInfoResponseBodyHeaderSignatureInfo HeaderSignatureInfo { get; set; }
        public class GetFileUploadInfoResponseBodyHeaderSignatureInfo : TeaModel {
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
        /// 上传协议，根据不同上传类型返回对应的信息.
        /// 枚举值:
        /// 	HEADER_SIGNATURE: Header加签
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// 文件存储类型
        /// 枚举值:
        /// 	DINGTALK: 钉钉统一存储驱动
        /// 	ALIDOC: 钉钉文档存储驱动
        /// 	SHANJI: 闪记存储驱动
        /// 	UNKNOWN: 未知驱动
        /// </summary>
        [NameInMap("storageDriver")]
        [Validation(Required=false)]
        public string StorageDriver { get; set; }

        /// <summary>
        /// 上传唯一标识
        /// </summary>
        [NameInMap("uploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

    }

}

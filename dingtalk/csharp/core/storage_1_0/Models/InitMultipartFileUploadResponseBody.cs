// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class InitMultipartFileUploadResponseBody : TeaModel {
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

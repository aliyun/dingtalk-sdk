// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class FileStorageActiveStorageResponseBody : TeaModel {
        /// <summary>
        /// oss开启时间
        /// </summary>
        [NameInMap("createDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        /// <summary>
        /// 是否开启专属存储 0开启1关闭
        /// </summary>
        [NameInMap("fileStorageOpenStatus")]
        [Validation(Required=false)]
        public int? FileStorageOpenStatus { get; set; }

        /// <summary>
        /// 存储状态 0正常1异常
        /// </summary>
        [NameInMap("storageStatus")]
        [Validation(Required=false)]
        public int? StorageStatus { get; set; }

        /// <summary>
        /// 已经使用的容量Bytes
        /// </summary>
        [NameInMap("usedQuota")]
        [Validation(Required=false)]
        public long? UsedQuota { get; set; }

    }

}

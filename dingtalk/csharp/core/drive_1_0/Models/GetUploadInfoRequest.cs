// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetUploadInfoRequest : TeaModel {
        /// <summary>
        /// 文件名称冲突策略
        /// </summary>
        [NameInMap("addConflictPolicy")]
        [Validation(Required=false)]
        public string AddConflictPolicy { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// 文件md5
        /// </summary>
        [NameInMap("md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// mediaId
        /// </summary>
        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

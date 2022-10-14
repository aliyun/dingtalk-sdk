// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetMultipartFileUploadInfosRequest : TeaModel {
        /// <summary>
        /// 分片id列表
        /// 分片id取值: 1~10000
        /// 分片大小限制: 100KB~5GB
        /// </summary>
        [NameInMap("partNumbers")]
        [Validation(Required=false)]
        public List<int?> PartNumbers { get; set; }

        /// <summary>
        /// 上传唯一标识
        /// </summary>
        [NameInMap("uploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

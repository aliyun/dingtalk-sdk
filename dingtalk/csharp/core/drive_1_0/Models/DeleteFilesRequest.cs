// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class DeleteFilesRequest : TeaModel {
        /// <summary>
        /// 删除策略
        /// </summary>
        [NameInMap("deletePolicy")]
        [Validation(Required=false)]
        public string DeletePolicy { get; set; }

        /// <summary>
        /// 文件id列表
        /// </summary>
        [NameInMap("fileIds")]
        [Validation(Required=false)]
        public List<string> FileIds { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class MoveFileRequest : TeaModel {
        /// <summary>
        /// 目标空间id
        /// </summary>
        [NameInMap("targetSpaceId")]
        [Validation(Required=false)]
        public string TargetSpaceId { get; set; }

        /// <summary>
        /// 目标父目录id
        /// </summary>
        [NameInMap("targetParentId")]
        [Validation(Required=false)]
        public string TargetParentId { get; set; }

        /// <summary>
        /// 文件名冲突策略
        /// </summary>
        [NameInMap("addConflictPolicy")]
        [Validation(Required=false)]
        public string AddConflictPolicy { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

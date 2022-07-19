// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class CopyDentryRequest : TeaModel {
        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public CopyDentryRequestOption Option { get; set; }
        public class CopyDentryRequestOption : TeaModel {
            [NameInMap("conflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }
        };

        /// <summary>
        /// 目标文件夹id, 根目录id值为0
        /// </summary>
        [NameInMap("targetFolderId")]
        [Validation(Required=false)]
        public string TargetFolderId { get; set; }

        /// <summary>
        /// 目标文件夹空间id
        /// </summary>
        [NameInMap("targetSpaceId")]
        [Validation(Required=false)]
        public string TargetSpaceId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

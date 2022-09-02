// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RestoreRecycleItemRequest : TeaModel {
        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public RestoreRecycleItemRequestOption Option { get; set; }
        public class RestoreRecycleItemRequestOption : TeaModel {
            /// <summary>
            /// 文件名称冲突策略
            /// 还原时原路径可能已经存在同名的文件
            /// 枚举值:
            /// 	AUTO_RENAME: 自动重命名
            /// 	OVERWRITE: 覆盖
            /// 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
            /// 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
            /// 默认值:
            /// 	AUTO_RENAME
            /// </summary>
            [NameInMap("conflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }

        }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class AddFolderRequest : TeaModel {
        /// <summary>
        /// 名称(文件名+后缀), 规则：
        /// 1. 头尾不能包含空格，否则会自动去除
        /// 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
        /// 3. 不能以"."结尾
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public AddFolderRequestOption Option { get; set; }
        public class AddFolderRequestOption : TeaModel {
            /// <summary>
            /// 文件夹在应用上的属性, 一个应用最多只能设置3个属性
            /// 最大size:
            /// 	3
            /// </summary>
            [NameInMap("appProperties")]
            [Validation(Required=false)]
            public List<AddFolderRequestOptionAppProperties> AppProperties { get; set; }
            public class AddFolderRequestOptionAppProperties : TeaModel {
                /// <summary>
                /// 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 属性值
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// 属性可见范围
                /// 枚举值:
                /// 	PUBLIC: 该属性所有App可见
                /// 	PRIVATE: 该属性仅其归属App可见
                /// </summary>
                [NameInMap("visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

            /// <summary>
            /// 文件夹名称冲突策略
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

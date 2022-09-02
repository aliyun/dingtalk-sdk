// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class AddSpaceRequest : TeaModel {
        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public AddSpaceRequestOption Option { get; set; }
        public class AddSpaceRequestOption : TeaModel {
            /// <summary>
            /// 空间能力项, 默认表示不设置拓展能力项
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public AddSpaceRequestOptionCapabilities Capabilities { get; set; }
            public class AddSpaceRequestOptionCapabilities : TeaModel {
                /// <summary>
                /// 是否进最近使用, 默认不支持
                /// 默认值:
                /// 	false
                /// </summary>
                [NameInMap("canRecordRecentFile")]
                [Validation(Required=false)]
                public bool? CanRecordRecentFile { get; set; }

                /// <summary>
                /// 是否支持重命名空间名称, 默认不支持
                /// 默认值:
                /// 	false
                /// </summary>
                [NameInMap("canRename")]
                [Validation(Required=false)]
                public bool? CanRename { get; set; }

                /// <summary>
                /// 是否支持搜索, 默认不支持
                /// 默认值:
                /// 	false
                /// </summary>
                [NameInMap("canSearch")]
                [Validation(Required=false)]
                public bool? CanSearch { get; set; }

            }

            /// <summary>
            /// 空间名称，默认无空间名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// owner类型, 空间Owner可以是用户或应用
            /// 如果是应用类型，需要单独授权
            /// 枚举值:
            /// 	USER: 用户类型
            /// 	APP: App类型
            /// 默认值:
            /// 	USER
            /// </summary>
            [NameInMap("ownerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// 空间能使用最大容量, 默认表示无最大容量
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// 空间场景，详见 Space.scene 字段. 不指定默认值是default
            /// 只能由数字和字母组成
            /// 默认值:
            /// 	default
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// 空间场景Id，详见 Space.sceneId 字段. 不指定默认值是0
            /// 只能由数字和字母组成
            /// 默认值:
            /// 	0
            /// </summary>
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

        }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

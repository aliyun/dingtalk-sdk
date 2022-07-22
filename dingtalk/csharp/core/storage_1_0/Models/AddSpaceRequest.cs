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
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ownerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }
            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }
        };

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

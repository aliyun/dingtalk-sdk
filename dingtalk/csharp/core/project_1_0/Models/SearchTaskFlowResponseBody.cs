// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchTaskFlowResponseBody : TeaModel {
        /// <summary>
        /// 工作流列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchTaskFlowResponseBodyResult> Result { get; set; }
        public class SearchTaskFlowResponseBodyResult : TeaModel {
            /// <summary>
            /// 绑定对象Id，此接口为项目id。
            /// </summary>
            [NameInMap("boundToObjectId")]
            [Validation(Required=false)]
            public string BoundToObjectId { get; set; }

            /// <summary>
            /// 绑定类型，增加项目成员默认是project。
            /// </summary>
            [NameInMap("boundToObjectType")]
            [Validation(Required=false)]
            public string BoundToObjectType { get; set; }

            /// <summary>
            /// 创建时间。
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 创建者id。
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 是否已删除。
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// 工作流名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 工作流ID。
            /// </summary>
            [NameInMap("taskflowId")]
            [Validation(Required=false)]
            public string TaskflowId { get; set; }

            /// <summary>
            /// 更新时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}

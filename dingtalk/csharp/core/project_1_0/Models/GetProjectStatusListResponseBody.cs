// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetProjectStatusListResponseBody : TeaModel {
        /// <summary>
        /// 项目状态历史列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetProjectStatusListResponseBodyResult> Result { get; set; }
        public class GetProjectStatusListResponseBodyResult : TeaModel {
            /// <summary>
            /// 项目状态内容。
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 创建时间。
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 项目状态创建人ID。
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 项目状态指标：'normal','risky','urgent'。
            /// </summary>
            [NameInMap("degree")]
            [Validation(Required=false)]
            public string Degree { get; set; }

            /// <summary>
            /// 项目状态名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 项目ID。
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

        }

    }

}

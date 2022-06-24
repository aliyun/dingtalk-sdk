// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetOrganizationPriorityListResponseBody : TeaModel {
        /// <summary>
        /// 优先级列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetOrganizationPriorityListResponseBodyResult> Result { get; set; }
        public class GetOrganizationPriorityListResponseBodyResult : TeaModel {
            /// <summary>
            /// 颜色
            /// </summary>
            [NameInMap("color")]
            [Validation(Required=false)]
            public string Color { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 优先级值
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// id
            /// </summary>
            [NameInMap("priorityId")]
            [Validation(Required=false)]
            public string PriorityId { get; set; }

        }

    }

}

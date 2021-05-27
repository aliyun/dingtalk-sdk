// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class ListWorkBenchGroupResponseBody : TeaModel {
        /// <summary>
        /// 应用列表
        /// </summary>
        [NameInMap("groupList")]
        [Validation(Required=false)]
        public List<ListWorkBenchGroupResponseBodyGroupList> GroupList { get; set; }
        public class ListWorkBenchGroupResponseBodyGroupList : TeaModel {
            /// <summary>
            /// 分组名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 分组id
            /// </summary>
            [NameInMap("componentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

        }

    }

}

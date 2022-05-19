// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class DeleteSpaceResponseBody : TeaModel {
        /// <summary>
        /// 失败列表
        /// </summary>
        [NameInMap("delFailedDept")]
        [Validation(Required=false)]
        public List<DeleteSpaceResponseBodyDelFailedDept> DelFailedDept { get; set; }
        public class DeleteSpaceResponseBodyDelFailedDept : TeaModel {
            /// <summary>
            /// 部门id
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

        }

        /// <summary>
        /// 删除成功数量
        /// </summary>
        [NameInMap("delSuccessCount")]
        [Validation(Required=false)]
        public bool? DelSuccessCount { get; set; }

    }

}

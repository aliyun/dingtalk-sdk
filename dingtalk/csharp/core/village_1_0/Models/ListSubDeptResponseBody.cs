// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListSubDeptResponseBody : TeaModel {
        /// <summary>
        /// 返回列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListSubDeptResponseBodyResult> Result { get; set; }
        public class ListSubDeptResponseBodyResult : TeaModel {
            /// <summary>
            /// 部门ID
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// 部门名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}

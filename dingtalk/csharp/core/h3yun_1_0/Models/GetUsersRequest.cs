// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetUsersRequest : TeaModel {
        /// <summary>
        /// 部门id。
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 是否递归获取子级部门下的用户。默认值为false
        /// </summary>
        [NameInMap("isRecursive")]
        [Validation(Required=false)]
        public bool? IsRecursive { get; set; }

    }

}

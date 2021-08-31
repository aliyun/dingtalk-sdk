// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListSubDeptIdsResponseBody : TeaModel {
        /// <summary>
        /// 下属组织的子部门 ID 列表
        /// </summary>
        [NameInMap("departmentIdList")]
        [Validation(Required=false)]
        public List<long?> DepartmentIdList { get; set; }

    }

}

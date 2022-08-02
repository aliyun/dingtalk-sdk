// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeListDeptManagerRequest : TeaModel {
        /// <summary>
        /// 部门id
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 单页的条目数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}

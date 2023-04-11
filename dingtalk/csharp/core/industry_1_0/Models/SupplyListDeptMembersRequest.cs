// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyListDeptMembersRequest : TeaModel {
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

        /// <summary>
        /// 供应链部门id
        /// </summary>
        [NameInMap("supplyDeptId")]
        [Validation(Required=false)]
        public long? SupplyDeptId { get; set; }

    }

}

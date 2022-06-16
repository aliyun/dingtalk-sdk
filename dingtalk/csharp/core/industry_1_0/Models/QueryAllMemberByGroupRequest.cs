// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryAllMemberByGroupRequest : TeaModel {
        /// <summary>
        /// 按月查询标识
        /// </summary>
        [NameInMap("monthMark")]
        [Validation(Required=false)]
        public string MonthMark { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 分页查询分页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

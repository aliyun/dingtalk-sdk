// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetProjectGroupRequest : TeaModel {
        /// <summary>
        /// 分页大小，最小1，默认10，最大1000
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 查看者ID
        /// </summary>
        [NameInMap("viewerId")]
        [Validation(Required=false)]
        public string ViewerId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class UpdatePartnerVisibilityRequest : TeaModel {
        /// <summary>
        /// 可见的部门id
        /// </summary>
        [NameInMap("deptIds")]
        [Validation(Required=false)]
        public List<long?> DeptIds { get; set; }

        /// <summary>
        /// 标签id
        /// </summary>
        [NameInMap("labelId")]
        [Validation(Required=false)]
        public long? LabelId { get; set; }

        /// <summary>
        /// 可见的员工id
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}

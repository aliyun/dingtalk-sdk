// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeRemoveManagerRequest : TeaModel {
        /// <summary>
        /// 部门id
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// 是否强制移除
        /// </summary>
        [NameInMap("isForce")]
        [Validation(Required=false)]
        public bool? IsForce { get; set; }

        /// <summary>
        /// userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class AddResidentDepartmentRequest : TeaModel {
        /// <summary>
        /// 部门名字
        /// </summary>
        [NameInMap("departmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 是否为组
        /// </summary>
        [NameInMap("isResidenceGroup")]
        [Validation(Required=false)]
        public bool? IsResidenceGroup { get; set; }

        /// <summary>
        /// 父部门id
        /// </summary>
        [NameInMap("parentDepartmentId")]
        [Validation(Required=false)]
        public long? ParentDepartmentId { get; set; }

    }

}

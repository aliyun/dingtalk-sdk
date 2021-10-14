// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetDeptResponseBody : TeaModel {
        /// <summary>
        /// 下属组织的部门ID
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [NameInMap("departmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 部门是否来自关联组织
        /// </summary>
        [NameInMap("fromUnionOrg")]
        [Validation(Required=false)]
        public bool? FromUnionOrg { get; set; }

        /// <summary>
        /// 在父部门中的次序值
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public long? Order { get; set; }

        /// <summary>
        /// 父部门id
        /// </summary>
        [NameInMap("parentDepartmentId")]
        [Validation(Required=false)]
        public long? ParentDepartmentId { get; set; }

    }

}

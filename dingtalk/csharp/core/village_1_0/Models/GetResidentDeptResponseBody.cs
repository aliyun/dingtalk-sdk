// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetResidentDeptResponseBody : TeaModel {
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
        /// 部门类型
        /// </summary>
        [NameInMap("deptType")]
        [Validation(Required=false)]
        public string DeptType { get; set; }

        /// <summary>
        /// 通讯录架构类型
        /// </summary>
        [NameInMap("contactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

        /// <summary>
        /// 部门属性
        /// </summary>
        [NameInMap("feature")]
        [Validation(Required=false)]
        public string Feature { get; set; }

    }

}

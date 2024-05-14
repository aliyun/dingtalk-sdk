// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetResidentDeptResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("contactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("departmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptType")]
        [Validation(Required=false)]
        public string DeptType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("feature")]
        [Validation(Required=false)]
        public string Feature { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetResidentDeptResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("departmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deptType")]
        [Validation(Required=false)]
        public string DeptType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("feature")]
        [Validation(Required=false)]
        public string Feature { get; set; }

    }

}

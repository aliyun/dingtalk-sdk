// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetDeptResponseBody : TeaModel {
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
        [NameInMap("fromUnionOrg")]
        [Validation(Required=false)]
        public bool? FromUnionOrg { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public long? Order { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("parentDepartmentId")]
        [Validation(Required=false)]
        public long? ParentDepartmentId { get; set; }

    }

}

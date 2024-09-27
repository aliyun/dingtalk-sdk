// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetOrganizationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>部门id。获取指定部门及其下的子部门（以及子部门的子部门等等，递归获取）。 如果不填，默认获取全量组织架构</para>
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

    }

}

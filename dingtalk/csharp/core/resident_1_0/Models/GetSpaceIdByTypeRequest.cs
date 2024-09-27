// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class GetSpaceIdByTypeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROPERTY_STAFF_DEPT</para>
        /// </summary>
        [NameInMap("departmentType")]
        [Validation(Required=false)]
        public string DepartmentType { get; set; }

    }

}

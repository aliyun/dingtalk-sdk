// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryDepartmentExtendInfoRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptCode")]
        [Validation(Required=false)]
        public long? DeptCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("propCode")]
        [Validation(Required=false)]
        public string PropCode { get; set; }

    }

}

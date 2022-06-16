// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryDepartmentExtendInfoRequest : TeaModel {
        /// <summary>
        /// 科室或医疗组code
        /// </summary>
        [NameInMap("deptCode")]
        [Validation(Required=false)]
        public long? DeptCode { get; set; }

        /// <summary>
        /// 扩展属性code
        /// </summary>
        [NameInMap("propCode")]
        [Validation(Required=false)]
        public string PropCode { get; set; }

    }

}

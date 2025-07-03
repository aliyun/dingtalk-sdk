// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksalary_1_0.Models
{
    public class GetSalaryGroupResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetSalaryGroupResponseBodyResult> Result { get; set; }
        public class GetSalaryGroupResponseBodyResult : TeaModel {
            [NameInMap("enableFlag")]
            [Validation(Required=false)]
            public bool? EnableFlag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SalaryItemGroupIdxxx</para>
            /// </summary>
            [NameInMap("salaryGroupId")]
            [Validation(Required=false)]
            public string SalaryGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("salaryGroupName")]
            [Validation(Required=false)]
            public string SalaryGroupName { get; set; }

        }

    }

}

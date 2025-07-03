// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksalary_1_0.Models
{
    public class GetSalaryItemGroupResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetSalaryItemGroupResponseBodyResult> Result { get; set; }
        public class GetSalaryItemGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SalaryItemGroupIdxxx</para>
            /// </summary>
            [NameInMap("salaryItemGroupId")]
            [Validation(Required=false)]
            public string SalaryItemGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>浮动薪资xx</para>
            /// </summary>
            [NameInMap("salaryItemGroupName")]
            [Validation(Required=false)]
            public string SalaryItemGroupName { get; set; }

        }

    }

}

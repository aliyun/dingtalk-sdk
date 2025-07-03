// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksalary_1_0.Models
{
    public class GetSalaryItemResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetSalaryItemResponseBodyResult> Result { get; set; }
        public class GetSalaryItemResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SalaryItemIdxxx</para>
            /// </summary>
            [NameInMap("salaryItemId")]
            [Validation(Required=false)]
            public string SalaryItemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>绩效xx</para>
            /// </summary>
            [NameInMap("salaryItemName")]
            [Validation(Required=false)]
            public string SalaryItemName { get; set; }

        }

    }

}

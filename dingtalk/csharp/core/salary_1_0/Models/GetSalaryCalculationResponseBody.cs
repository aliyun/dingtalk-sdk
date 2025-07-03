// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksalary_1_0.Models
{
    public class GetSalaryCalculationResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSalaryCalculationResponseBodyResult Result { get; set; }
        public class GetSalaryCalculationResponseBodyResult : TeaModel {
            [NameInMap("calStatus")]
            [Validation(Required=false)]
            public bool? CalStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-01</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NONE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}

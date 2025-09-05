// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class UpdateVacationQuotaResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<UpdateVacationQuotaResponseBodyResult> Result { get; set; }
        public class UpdateVacationQuotaResponseBodyResult : TeaModel {
            [NameInMap("quota")]
            [Validation(Required=false)]
            public UpdateVacationQuotaResponseBodyResultQuota Quota { get; set; }
            public class UpdateVacationQuotaResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>f84a2829-d245-4312-9ff2-0653e5b3abb2</para>
                /// </summary>
                [NameInMap("leaveCode")]
                [Validation(Required=false)]
                public string LeaveCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019</para>
                /// </summary>
                [NameInMap("quotaCycle")]
                [Validation(Required=false)]
                public string QuotaCycle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user01</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>假期类型不存在</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

    }

}

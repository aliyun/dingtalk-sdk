// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class UpdateVacationQuotaRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateVacationQuotaRequestBody> Body { get; set; }
        public class UpdateVacationQuotaRequestBody : TeaModel {
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1753851001000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
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

            [NameInMap("quotaNumPerDay")]
            [Validation(Required=false)]
            public int? QuotaNumPerDay { get; set; }

            [NameInMap("quotaNumPerHour")]
            [Validation(Required=false)]
            public int? QuotaNumPerHour { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1653851001000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}

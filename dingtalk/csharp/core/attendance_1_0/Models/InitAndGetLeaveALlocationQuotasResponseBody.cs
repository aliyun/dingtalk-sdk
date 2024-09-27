// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class InitAndGetLeaveALlocationQuotasResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<InitAndGetLeaveALlocationQuotasResponseBodyResult> Result { get; set; }
        public class InitAndGetLeaveALlocationQuotasResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1753851001000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c00ced14-xxxxxd438748</para>
            /// </summary>
            [NameInMap("leaveCode")]
            [Validation(Required=false)]
            public string LeaveCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022</para>
            /// </summary>
            [NameInMap("quotaCycle")]
            [Validation(Required=false)]
            public string QuotaCycle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b13cc5b0--xxxx5b0</para>
            /// </summary>
            [NameInMap("quotaId")]
            [Validation(Required=false)]
            public string QuotaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>700</para>
            /// </summary>
            [NameInMap("quotaNumPerDay")]
            [Validation(Required=false)]
            public long? QuotaNumPerDay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("quotaNumPerHour")]
            [Validation(Required=false)]
            public long? QuotaNumPerHour { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1653851001000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("usedNumPerDay")]
            [Validation(Required=false)]
            public long? UsedNumPerDay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("usedNumPerHour")]
            [Validation(Required=false)]
            public long? UsedNumPerHour { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

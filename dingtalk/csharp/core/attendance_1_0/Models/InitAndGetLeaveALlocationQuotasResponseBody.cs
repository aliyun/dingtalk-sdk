// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class InitAndGetLeaveALlocationQuotasResponseBody : TeaModel {
        /// <summary>
        /// 返回结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<InitAndGetLeaveALlocationQuotasResponseBodyResult> Result { get; set; }
        public class InitAndGetLeaveALlocationQuotasResponseBodyResult : TeaModel {
            /// <summary>
            /// 额度有效期结束时间。
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 假期类型标识。
            /// </summary>
            [NameInMap("leaveCode")]
            [Validation(Required=false)]
            public string LeaveCode { get; set; }

            /// <summary>
            /// 年度。
            /// </summary>
            [NameInMap("quotaCycle")]
            [Validation(Required=false)]
            public string QuotaCycle { get; set; }

            /// <summary>
            /// 余额标识。
            /// </summary>
            [NameInMap("quotaId")]
            [Validation(Required=false)]
            public string QuotaId { get; set; }

            /// <summary>
            /// 以天计算额度总数。
            /// </summary>
            [NameInMap("quotaNumPerDay")]
            [Validation(Required=false)]
            public long? QuotaNumPerDay { get; set; }

            /// <summary>
            /// 以小时计算额度总数。
            /// </summary>
            [NameInMap("quotaNumPerHour")]
            [Validation(Required=false)]
            public long? QuotaNumPerHour { get; set; }

            /// <summary>
            /// 额度有效期开始时间。
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 用过的配额天数。
            /// </summary>
            [NameInMap("usedNumPerDay")]
            [Validation(Required=false)]
            public long? UsedNumPerDay { get; set; }

            /// <summary>
            /// 用过的配额小时数。
            /// </summary>
            [NameInMap("usedNumPerHour")]
            [Validation(Required=false)]
            public long? UsedNumPerHour { get; set; }

            /// <summary>
            /// 用户id。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

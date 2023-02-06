// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetLeaveRecordsResponseBody : TeaModel {
        /// <summary>
        /// 返回结果。
        /// 
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetLeaveRecordsResponseBodyResult Result { get; set; }
        public class GetLeaveRecordsResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否有更多结果。
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// 假期消费记录列表。
            /// </summary>
            [NameInMap("leaveRecords")]
            [Validation(Required=false)]
            public List<GetLeaveRecordsResponseBodyResultLeaveRecords> LeaveRecords { get; set; }
            public class GetLeaveRecordsResponseBodyResultLeaveRecords : TeaModel {
                /// <summary>
                /// 计算类型。
                /// </summary>
                [NameInMap("calType")]
                [Validation(Required=false)]
                public string CalType { get; set; }

                /// <summary>
                /// 额度有效期结束时间或请假结束时间，毫秒级时间戳。
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// 记录创建时间。
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// 记录修改时间。
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// 假期类型唯一标识。
                /// </summary>
                [NameInMap("leaveCode")]
                [Validation(Required=false)]
                public string LeaveCode { get; set; }

                /// <summary>
                /// 原因。
                /// </summary>
                [NameInMap("leaveReason")]
                [Validation(Required=false)]
                public string LeaveReason { get; set; }

                /// <summary>
                /// 假期记录类型。
                /// </summary>
                [NameInMap("leaveRecordType")]
                [Validation(Required=false)]
                public string LeaveRecordType { get; set; }

                /// <summary>
                /// 请假状态。
                /// </summary>
                [NameInMap("leaveStatus")]
                [Validation(Required=false)]
                public string LeaveStatus { get; set; }

                /// <summary>
                /// 显示单位。
                /// </summary>
                [NameInMap("leaveViewUnit")]
                [Validation(Required=false)]
                public string LeaveViewUnit { get; set; }

                /// <summary>
                /// 额度唯一标识。
                /// </summary>
                [NameInMap("quotaId")]
                [Validation(Required=false)]
                public string QuotaId { get; set; }

                /// <summary>
                /// 假期记录唯一标识。
                /// </summary>
                [NameInMap("recordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// 以天计算的消费额度。
                /// </summary>
                [NameInMap("recordNumPerDay")]
                [Validation(Required=false)]
                public long? RecordNumPerDay { get; set; }

                /// <summary>
                /// 以小时计算的消费额度。
                /// </summary>
                [NameInMap("recordNumPerHour")]
                [Validation(Required=false)]
                public long? RecordNumPerHour { get; set; }

                /// <summary>
                /// 额度有效期开始时间或请假开始时间，毫秒级时间戳。
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// 员工userId。
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// 是否正确访问。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

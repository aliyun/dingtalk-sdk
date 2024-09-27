// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetLeaveRecordsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetLeaveRecordsResponseBodyResult Result { get; set; }
        public class GetLeaveRecordsResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("leaveRecords")]
            [Validation(Required=false)]
            public List<GetLeaveRecordsResponseBodyResultLeaveRecords> LeaveRecords { get; set; }
            public class GetLeaveRecordsResponseBodyResultLeaveRecords : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>add</para>
                /// </summary>
                [NameInMap("calType")]
                [Validation(Required=false)]
                public string CalType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1753851001000</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1653851001000</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1753851001000</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f84a2dxxxx</para>
                /// </summary>
                [NameInMap("leaveCode")]
                [Validation(Required=false)]
                public string LeaveCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>管理员导入</para>
                /// </summary>
                [NameInMap("leaveReason")]
                [Validation(Required=false)]
                public string LeaveReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>update</para>
                /// </summary>
                [NameInMap("leaveRecordType")]
                [Validation(Required=false)]
                public string LeaveRecordType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>init</para>
                /// </summary>
                [NameInMap("leaveStatus")]
                [Validation(Required=false)]
                public string LeaveStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>day</para>
                /// </summary>
                [NameInMap("leaveViewUnit")]
                [Validation(Required=false)]
                public string LeaveViewUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>manage223</para>
                /// </summary>
                [NameInMap("opUserId")]
                [Validation(Required=false)]
                public string OpUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>db1d74xxxxbaa</para>
                /// </summary>
                [NameInMap("quotaId")]
                [Validation(Required=false)]
                public string QuotaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>db1d74xxxxbaa</para>
                /// </summary>
                [NameInMap("recordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("recordNumPerDay")]
                [Validation(Required=false)]
                public long? RecordNumPerDay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("recordNumPerHour")]
                [Validation(Required=false)]
                public long? RecordNumPerHour { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1653851001000</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

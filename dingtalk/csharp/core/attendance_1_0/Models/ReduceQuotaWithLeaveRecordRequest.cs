// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ReduceQuotaWithLeaveRecordRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asdfaad-asdfadfa-asdfa</para>
        /// </summary>
        [NameInMap("leaveCode")]
        [Validation(Required=false)]
        public string LeaveCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123342345</para>
        /// </summary>
        [NameInMap("outerId")]
        [Validation(Required=false)]
        public string OuterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("quotaNum")]
        [Validation(Required=false)]
        public int? QuotaNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>家中有事请假1天</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class CalculateDurationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public long? BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("calculateModel")]
        [Validation(Required=false)]
        public long? CalculateModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("durationUnit")]
        [Validation(Required=false)]
        public string DurationUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-08-15</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public string FromTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e2dsad-34dfa-2vas23da</para>
        /// </summary>
        [NameInMap("leaveCode")]
        [Validation(Required=false)]
        public string LeaveCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-08-15</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public string ToTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

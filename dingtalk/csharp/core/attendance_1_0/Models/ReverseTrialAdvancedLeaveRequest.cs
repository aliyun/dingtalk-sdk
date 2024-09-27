// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ReverseTrialAdvancedLeaveRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>manager234</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("servCode")]
        [Validation(Required=false)]
        public long? ServCode { get; set; }

    }

}

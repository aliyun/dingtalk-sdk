// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetManageProcessByStaffIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetManageProcessByStaffIdResponseBodyResult> Result { get; set; }
        public class GetManageProcessByStaffIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("attendanceType")]
            [Validation(Required=false)]
            public int? AttendanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>通用审批</para>
            /// </summary>
            [NameInMap("flowTitle")]
            [Validation(Required=false)]
            public string FlowTitle { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-14 14:24:59</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>common</para>
            /// </summary>
            [NameInMap("iconName")]
            [Validation(Required=false)]
            public string IconName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://gw.alicdn.com/tfs/xxxx-112-112.png">https://gw.alicdn.com/tfs/xxxx-112-112.png</a></para>
            /// </summary>
            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("newProcess")]
            [Validation(Required=false)]
            public bool? NewProcess { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROC-44E84FC1-16E2-4A69-BB3C-xxxx</para>
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetManageProcessByStaffIdResponseBody : TeaModel {
        /// <summary>
        /// 返回结果列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetManageProcessByStaffIdResponseBodyResult> Result { get; set; }
        public class GetManageProcessByStaffIdResponseBodyResult : TeaModel {
            /// <summary>
            /// 关联考勤类型，取值。
            /// 
            /// 0：无
            /// 1：补卡申请
            /// 2：请假
            /// </summary>
            [NameInMap("attendanceType")]
            [Validation(Required=false)]
            public int? AttendanceType { get; set; }

            /// <summary>
            /// 模版名称。
            /// </summary>
            [NameInMap("flowTitle")]
            [Validation(Required=false)]
            public string FlowTitle { get; set; }

            /// <summary>
            /// 修改时间。
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// 模板图标名。
            /// </summary>
            [NameInMap("iconName")]
            [Validation(Required=false)]
            public string IconName { get; set; }

            /// <summary>
            /// 图标URL地址。
            /// </summary>
            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// 是否新模版。
            /// </summary>
            [NameInMap("newProcess")]
            [Validation(Required=false)]
            public bool? NewProcess { get; set; }

            /// <summary>
            /// 模版code。
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

        /// <summary>
        /// 接口调用是否成功。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

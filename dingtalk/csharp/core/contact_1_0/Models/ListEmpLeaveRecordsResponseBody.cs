// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListEmpLeaveRecordsResponseBody : TeaModel {
        /// <summary>
        /// 分页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 离职记录列表
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ListEmpLeaveRecordsResponseBodyRecords> Records { get; set; }
        public class ListEmpLeaveRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// 员工userid
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 员工名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 国际电话区号
            /// </summary>
            [NameInMap("stateCode")]
            [Validation(Required=false)]
            public string StateCode { get; set; }

            /// <summary>
            /// 手机号码
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// 离职时间
            /// </summary>
            [NameInMap("leaveTime")]
            [Validation(Required=false)]
            public string LeaveTime { get; set; }

            /// <summary>
            /// 离职原因(oapi-开放平台删除，cancel-注销，leave-主动离职，unknown-未知原因，delete-管理员删除）
            /// </summary>
            [NameInMap("leaveReason")]
            [Validation(Required=false)]
            public string LeaveReason { get; set; }

        }

    }

}

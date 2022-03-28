// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryHrmEmployeeDismissionInfoResponseBody : TeaModel {
        /// <summary>
        /// 名称列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryHrmEmployeeDismissionInfoResponseBodyResult> Result { get; set; }
        public class QueryHrmEmployeeDismissionInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// 离职部门列表
            /// </summary>
            [NameInMap("deptList")]
            [Validation(Required=false)]
            public List<QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList> DeptList { get; set; }
            public class QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList : TeaModel {
                /// <summary>
                /// 部门id
                /// </summary>
                [NameInMap("dept_id")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// 部门路径
                /// </summary>
                [NameInMap("dept_path")]
                [Validation(Required=false)]
                public string DeptPath { get; set; }

            }

            /// <summary>
            /// 离职交接人
            /// </summary>
            [NameInMap("handoverUserId")]
            [Validation(Required=false)]
            public string HandoverUserId { get; set; }

            /// <summary>
            /// 最后工作日
            /// </summary>
            [NameInMap("lastWorkDay")]
            [Validation(Required=false)]
            public long? LastWorkDay { get; set; }

            /// <summary>
            /// 离职前主部门id
            /// </summary>
            [NameInMap("mainDeptId")]
            [Validation(Required=false)]
            public long? MainDeptId { get; set; }

            /// <summary>
            /// 离职前主部门名称
            /// </summary>
            [NameInMap("mainDeptName")]
            [Validation(Required=false)]
            public string MainDeptName { get; set; }

            /// <summary>
            /// 离职原因-被动
            /// </summary>
            [NameInMap("passiveReason")]
            [Validation(Required=false)]
            public List<string> PassiveReason { get; set; }

            /// <summary>
            /// 离职前工作状态：1，待入职；2，试用期；3，正式
            /// </summary>
            [NameInMap("preStatus")]
            [Validation(Required=false)]
            public int? PreStatus { get; set; }

            /// <summary>
            /// 离职原因备注
            /// </summary>
            [NameInMap("reasonMemo")]
            [Validation(Required=false)]
            public string ReasonMemo { get; set; }

            /// <summary>
            /// 离职状态：1，待离职；2，已离职
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 员工id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 离职原因-主动
            /// </summary>
            [NameInMap("voluntaryReason")]
            [Validation(Required=false)]
            public List<string> VoluntaryReason { get; set; }

        }

    }

}

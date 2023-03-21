// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ListApproveByUsersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListApproveByUsersResponseBodyResult> Result { get; set; }
        public class ListApproveByUsersResponseBodyResult : TeaModel {
            /// <summary>
            /// 审批单自定义id
            /// </summary>
            [NameInMap("approveId")]
            [Validation(Required=false)]
            public string ApproveId { get; set; }

            /// <summary>
            /// 审批单开始时间原始格式
            /// </summary>
            [NameInMap("beginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// 审批单类型：
            /// ● 1：加班
            /// ● 2：出差、外出
            /// ● 3：请假
            /// ● 4:  补卡
            /// ● 5：外勤审批
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            /// <summary>
            /// 计算方法：
            /// ● 0：按自然日计算
            /// ● 1：按工作日计算
            /// </summary>
            [NameInMap("calculateModel")]
            [Validation(Required=false)]
            public int? CalculateModel { get; set; }

            /// <summary>
            /// 时长单位，支持格式如下：
            /// ● day
            /// ● halfDay
            /// ● hour
            /// 时间格式必须与时长单位对应：
            /// ● 2019-08-15对应day
            /// ● 2019-08-15 AM对应halfDay
            /// ● 2019-08-15 12:43对应hour
            /// </summary>
            [NameInMap("durationUnit")]
            [Validation(Required=false)]
            public string DurationUnit { get; set; }

            /// <summary>
            /// 审批单结束时间原始格式
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// 子类型名称，最大长度20个字符
            /// </summary>
            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// 审批单类型名称，最大长度20个字符
            /// </summary>
            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// 用户userid
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

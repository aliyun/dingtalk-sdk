// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetDingReportDeptSummaryResponseBody : TeaModel {
        /// <summary>
        /// 部门维度发布日志信息
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDingReportDeptSummaryResponseBodyData> Data { get; set; }
        public class GetDingReportDeptSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// 部门id
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// 部门名称
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// 最近1天累计创建日志数
            /// </summary>
            [NameInMap("dingReportSendCnt")]
            [Validation(Required=false)]
            public string DingReportSendCnt { get; set; }

            /// <summary>
            /// 最近1天累计创建日志人数
            /// </summary>
            [NameInMap("dingReportSendUsrCnt")]
            [Validation(Required=false)]
            public string DingReportSendUsrCnt { get; set; }

        }

        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一次请求的分页游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}

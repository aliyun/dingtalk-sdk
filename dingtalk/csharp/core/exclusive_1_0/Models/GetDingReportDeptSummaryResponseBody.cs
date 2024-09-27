// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetDingReportDeptSummaryResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDingReportDeptSummaryResponseBodyData> Data { get; set; }
        public class GetDingReportDeptSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>部门A</para>
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("dingReportSendCnt")]
            [Validation(Required=false)]
            public string DingReportSendCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("dingReportSendUsrCnt")]
            [Validation(Required=false)]
            public string DingReportSendUsrCnt { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetGeneralFormCreatedDeptSummaryResponseBody : TeaModel {
        /// <summary>
        /// 用户版本分布情况列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetGeneralFormCreatedDeptSummaryResponseBodyData> Data { get; set; }
        public class GetGeneralFormCreatedDeptSummaryResponseBodyData : TeaModel {
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
            /// 最近1天累计发布智能填表数
            /// </summary>
            [NameInMap("generalFormCreateCnt1d")]
            [Validation(Required=false)]
            public string GeneralFormCreateCnt1d { get; set; }

        }

        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一次请 求的分页游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}

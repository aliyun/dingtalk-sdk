// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetDocCreatedDeptSummaryResponseBody : TeaModel {
        /// <summary>
        /// 部门维度用户创建文档数
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDocCreatedDeptSummaryResponseBodyData> Data { get; set; }
        public class GetDocCreatedDeptSummaryResponseBodyData : TeaModel {
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
            /// 最近1天累计钉钉文档创建数
            /// </summary>
            [NameInMap("docCreatedCnt")]
            [Validation(Required=false)]
            public string DocCreatedCnt { get; set; }

        }

        /// <summary>
        /// 下一次请求的分页游标
        /// </summary>
        [NameInMap("nextId")]
        [Validation(Required=false)]
        public long? NextId { get; set; }

        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

    }

}

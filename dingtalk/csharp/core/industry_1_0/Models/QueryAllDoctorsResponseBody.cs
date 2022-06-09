// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryAllDoctorsResponseBody : TeaModel {
        /// <summary>
        /// 人员列表
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryAllDoctorsResponseBodyContent> Content { get; set; }
        public class QueryAllDoctorsResponseBodyContent : TeaModel {
            /// <summary>
            /// 考核医疗组id
            /// </summary>
            [NameInMap("assessGroupId")]
            [Validation(Required=false)]
            public string AssessGroupId { get; set; }

            /// <summary>
            /// 考核医疗组名称
            /// </summary>
            [NameInMap("assessGroupName")]
            [Validation(Required=false)]
            public string AssessGroupName { get; set; }

            /// <summary>
            /// 关联的部门id
            /// </summary>
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            /// <summary>
            /// 科室医疗组标识
            /// </summary>
            [NameInMap("deptType")]
            [Validation(Required=false)]
            public string DeptType { get; set; }

            /// <summary>
            /// 用户创建时间
            /// </summary>
            [NameInMap("gmtCreateStr")]
            [Validation(Required=false)]
            public string GmtCreateStr { get; set; }

            /// <summary>
            /// 用户最后修改时间
            /// </summary>
            [NameInMap("gmtModifiedStr")]
            [Validation(Required=false)]
            public string GmtModifiedStr { get; set; }

            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 工号
            /// </summary>
            [NameInMap("jobNum")]
            [Validation(Required=false)]
            public string JobNum { get; set; }

            /// <summary>
            /// 状态0-有效，1-删除
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 租户下staffId
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// 租户内staffId
            /// </summary>
            [NameInMap("userCode")]
            [Validation(Required=false)]
            public string UserCode { get; set; }

            /// <summary>
            /// 用户名称
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// 当前页码
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}

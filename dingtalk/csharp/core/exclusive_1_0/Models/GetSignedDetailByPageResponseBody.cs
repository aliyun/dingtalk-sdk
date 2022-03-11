// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetSignedDetailByPageResponseBody : TeaModel {
        /// <summary>
        /// 员工信息
        /// </summary>
        [NameInMap("auditSignedDetailDTOList")]
        [Validation(Required=false)]
        public List<GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList> AuditSignedDetailDTOList { get; set; }
        public class GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList : TeaModel {
            /// <summary>
            /// 部门名称
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// 邮件
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// 员工名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 手机号
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// 角色
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public string Roles { get; set; }

            /// <summary>
            /// 工号
            /// </summary>
            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

            /// <summary>
            /// 职位
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// 一页数据量
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 总数据量
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

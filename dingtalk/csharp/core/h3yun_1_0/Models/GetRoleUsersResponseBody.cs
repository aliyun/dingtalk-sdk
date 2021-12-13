// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetRoleUsersResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetRoleUsersResponseBodyData> Data { get; set; }
        public class GetRoleUsersResponseBodyData : TeaModel {
            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 用户名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 用户编码
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 性别.None=未指定，Man=男性，Female=女性
            /// </summary>
            [NameInMap("sex")]
            [Validation(Required=false)]
            public string Sex { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 手机号码
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// 邮箱
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// 所属部门id
            /// </summary>
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }

            /// <summary>
            /// 所属部门名称
            /// </summary>
            [NameInMap("departmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            /// <summary>
            /// 所属范围。Internal=内部，External=外部
            /// </summary>
            [NameInMap("domainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// 兼职部门id集合（含主部门id）
            /// </summary>
            [NameInMap("partDepartmentIds")]
            [Validation(Required=false)]
            public List<string> PartDepartmentIds { get; set; }

            /// <summary>
            /// 排序值
            /// </summary>
            [NameInMap("sortKey")]
            [Validation(Required=false)]
            public long? SortKey { get; set; }

        }

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}

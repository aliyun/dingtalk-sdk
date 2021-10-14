// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListDeptUsersResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// 用户列表
        /// </summary>
        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<ListDeptUsersResponseBodyUserList> UserList { get; set; }
        public class ListDeptUsersResponseBodyUserList : TeaModel {
            /// <summary>
            /// 用户ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// unionId
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("jobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 部门ID列表
            /// </summary>
            [NameInMap("departmentList")]
            [Validation(Required=false)]
            public List<long?> DepartmentList { get; set; }

            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

    }

}

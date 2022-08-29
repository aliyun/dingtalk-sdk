// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetATManageScopeResponseBody : TeaModel {
        /// <summary>
        /// 管理范围。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetATManageScopeResponseBodyResult> Result { get; set; }
        public class GetATManageScopeResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否有更多数据。  true：有  false：没有
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// 可见范围。boss/主管理员/管理范围包含根部门的管理员：all ，管理员/考勤组负责人：partial，无权限：none
            /// </summary>
            [NameInMap("manageScope")]
            [Validation(Required=false)]
            public string ManageScope { get; set; }

            /// <summary>
            /// 员工userid。只有manageScope为partial返回数据。
            /// </summary>
            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}

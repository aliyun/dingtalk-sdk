// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class GetDingPortalDetailResponseBody : TeaModel {
        /// <summary>
        /// 工作台ID
        /// </summary>
        [NameInMap("appUuid")]
        [Validation(Required=false)]
        public string AppUuid { get; set; }

        /// <summary>
        /// 工作台名称
        /// </summary>
        [NameInMap("dingPortalName")]
        [Validation(Required=false)]
        public string DingPortalName { get; set; }

        /// <summary>
        /// 工作台页面信息
        /// </summary>
        [NameInMap("pages")]
        [Validation(Required=false)]
        public List<GetDingPortalDetailResponseBodyPages> Pages { get; set; }
        public class GetDingPortalDetailResponseBodyPages : TeaModel {
            /// <summary>
            /// 是否全公司可见
            /// </summary>
            [NameInMap("allVisible")]
            [Validation(Required=false)]
            public bool? AllVisible { get; set; }

            /// <summary>
            /// 可见部门 ID 铺
            /// </summary>
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            /// <summary>
            /// 页面名称
            /// </summary>
            [NameInMap("pageName")]
            [Validation(Required=false)]
            public string PageName { get; set; }

            /// <summary>
            /// 页面ID
            /// </summary>
            [NameInMap("pageUuid")]
            [Validation(Required=false)]
            public string PageUuid { get; set; }

            /// <summary>
            /// 可见角色列表
            /// </summary>
            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<long?> RoleIds { get; set; }

            /// <summary>
            /// 可见员工 ID 列表
            /// </summary>
            [NameInMap("userids")]
            [Validation(Required=false)]
            public List<string> Userids { get; set; }

        }

    }

}

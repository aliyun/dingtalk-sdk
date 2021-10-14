// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListContactHideSettingsResponseBody : TeaModel {
        /// <summary>
        /// 是否还有数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 设置列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListContactHideSettingsResponseBodyList> List { get; set; }
        public class ListContactHideSettingsResponseBodyList : TeaModel {
            /// <summary>
            /// 设置名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 设置描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 要隐藏的员工列表
            /// </summary>
            [NameInMap("objectStaffIds")]
            [Validation(Required=false)]
            public List<string> ObjectStaffIds { get; set; }

            /// <summary>
            /// 要隐藏的部门列表
            /// </summary>
            [NameInMap("objectDeptIds")]
            [Validation(Required=false)]
            public List<long?> ObjectDeptIds { get; set; }

            /// <summary>
            /// 要影藏的角色列表
            /// </summary>
            [NameInMap("objectTagIds")]
            [Validation(Required=false)]
            public List<long?> ObjectTagIds { get; set; }

            /// <summary>
            /// 白名单用户列表
            /// </summary>
            [NameInMap("excludeStaffIds")]
            [Validation(Required=false)]
            public List<string> ExcludeStaffIds { get; set; }

            /// <summary>
            /// 白名单部门列表
            /// </summary>
            [NameInMap("excludeDeptIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeDeptIds { get; set; }

            /// <summary>
            /// 白名单角色列表
            /// </summary>
            [NameInMap("excludeTagIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeTagIds { get; set; }

            /// <summary>
            /// 规则是否生效
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// settingId
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        /// <summary>
        /// 下一次拉取数据时的offset
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListEmpAttributeVisibilityResponseBody : TeaModel {
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
        public List<ListEmpAttributeVisibilityResponseBodyList> List { get; set; }
        public class ListEmpAttributeVisibilityResponseBodyList : TeaModel {
            /// <summary>
            /// id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 设置时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// 名称
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
            /// 被查看的用户id列表
            /// </summary>
            [NameInMap("objectStaffIds")]
            [Validation(Required=false)]
            public List<string> ObjectStaffIds { get; set; }

            /// <summary>
            /// 被查看的部门id列表
            /// </summary>
            [NameInMap("objectDeptIds")]
            [Validation(Required=false)]
            public List<long?> ObjectDeptIds { get; set; }

            /// <summary>
            /// 被查看的角色id列表
            /// </summary>
            [NameInMap("objectTagIds")]
            [Validation(Required=false)]
            public List<long?> ObjectTagIds { get; set; }

            /// <summary>
            /// 隐藏的字段id列表
            /// </summary>
            [NameInMap("hideFields")]
            [Validation(Required=false)]
            public List<string> HideFields { get; set; }

            /// <summary>
            /// 白名单用户id列表
            /// </summary>
            [NameInMap("excludeStaffIds")]
            [Validation(Required=false)]
            public List<string> ExcludeStaffIds { get; set; }

            /// <summary>
            /// 白名单部门id列表
            /// </summary>
            [NameInMap("excludeDeptIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeDeptIds { get; set; }

            /// <summary>
            /// 白名单角色id列表
            /// </summary>
            [NameInMap("excludeTagIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeTagIds { get; set; }

            /// <summary>
            /// 是否生效
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

        /// <summary>
        /// 下一次拉取时的offset
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListContactRestrictSettingResponseBody : TeaModel {
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
        public List<ListContactRestrictSettingResponseBodyList> List { get; set; }
        public class ListContactRestrictSettingResponseBodyList : TeaModel {
            /// <summary>
            /// 是否生效
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// 规则描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 白名单用户deptId列表
            /// </summary>
            [NameInMap("excludeDeptIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeDeptIds { get; set; }

            /// <summary>
            /// 白名单用户tagId列表
            /// </summary>
            [NameInMap("excludeTagIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeTagIds { get; set; }

            /// <summary>
            /// 白名单用户userId列表
            /// </summary>
            [NameInMap("excludeUserIds")]
            [Validation(Required=false)]
            public List<string> ExcludeUserIds { get; set; }

            /// <summary>
            /// 设置id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 规则名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 主体用户deptId列表
            /// </summary>
            [NameInMap("subjectDeptIds")]
            [Validation(Required=false)]
            public List<long?> SubjectDeptIds { get; set; }

            /// <summary>
            /// 主体用户tagId列表
            /// </summary>
            [NameInMap("subjectTagIds")]
            [Validation(Required=false)]
            public List<long?> SubjectTagIds { get; set; }

            /// <summary>
            /// 主体用户userId列表
            /// </summary>
            [NameInMap("subjectUserIds")]
            [Validation(Required=false)]
            public List<string> SubjectUserIds { get; set; }

            /// <summary>
            /// 限制类型
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 下一次拉取数据时的token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}

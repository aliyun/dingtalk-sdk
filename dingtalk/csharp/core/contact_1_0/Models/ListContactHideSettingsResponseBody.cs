// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListContactHideSettingsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListContactHideSettingsResponseBodyList> List { get; set; }
        public class ListContactHideSettingsResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>影藏对deptA但是user1可见。</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("excludeDeptIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeDeptIds { get; set; }

            [NameInMap("excludeStaffIds")]
            [Validation(Required=false)]
            public List<string> ExcludeStaffIds { get; set; }

            [NameInMap("excludeTagIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeTagIds { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试规则</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("objectDeptIds")]
            [Validation(Required=false)]
            public List<long?> ObjectDeptIds { get; set; }

            [NameInMap("objectStaffIds")]
            [Validation(Required=false)]
            public List<string> ObjectStaffIds { get; set; }

            [NameInMap("objectTagIds")]
            [Validation(Required=false)]
            public List<long?> ObjectTagIds { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListContactRestrictSettingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListContactRestrictSettingResponseBodyList> List { get; set; }
        public class ListContactRestrictSettingResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("excludeDeptIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeDeptIds { get; set; }

            [NameInMap("excludeTagIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeTagIds { get; set; }

            [NameInMap("excludeUserIds")]
            [Validation(Required=false)]
            public List<string> ExcludeUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>contact restrict name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("restrictInSearch")]
            [Validation(Required=false)]
            public bool? RestrictInSearch { get; set; }

            [NameInMap("restrictInUserProfile")]
            [Validation(Required=false)]
            public bool? RestrictInUserProfile { get; set; }

            [NameInMap("subjectDeptIds")]
            [Validation(Required=false)]
            public List<long?> SubjectDeptIds { get; set; }

            [NameInMap("subjectTagIds")]
            [Validation(Required=false)]
            public List<long?> SubjectTagIds { get; set; }

            [NameInMap("subjectUserIds")]
            [Validation(Required=false)]
            public List<string> SubjectUserIds { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}

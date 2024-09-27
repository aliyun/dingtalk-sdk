// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListEmpAttributeVisibilityResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListEmpAttributeVisibilityResponseBodyList> List { get; set; }
        public class ListEmpAttributeVisibilityResponseBodyList : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

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

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("hideFields")]
            [Validation(Required=false)]
            public List<string> HideFields { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

    }

}

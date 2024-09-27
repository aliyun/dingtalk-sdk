// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryAllGroupsInDeptResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryAllGroupsInDeptResponseBodyContent> Content { get; set; }
        public class QueryAllGroupsInDeptResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>医疗组1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public long? TotalPages { get; set; }

    }

}

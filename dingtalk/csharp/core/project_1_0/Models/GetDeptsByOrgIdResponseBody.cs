// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetDeptsByOrgIdResponseBody : TeaModel {
        /// <summary>
        /// deptList
        /// </summary>
        [NameInMap("deptList")]
        [Validation(Required=false)]
        public List<GetDeptsByOrgIdResponseBodyDeptList> DeptList { get; set; }
        public class GetDeptsByOrgIdResponseBodyDeptList : TeaModel {
            /// <summary>
            /// id
            /// </summary>
            [NameInMap("dept_id")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// parentId
            /// </summary>
            [NameInMap("parent_id")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// name
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// hasMore
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// nextCursor
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}

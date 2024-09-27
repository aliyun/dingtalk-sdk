// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ListCollegeContactSubDeptsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListCollegeContactSubDeptsResponseBodyResult> Result { get; set; }
        public class ListCollegeContactSubDeptsResponseBodyResult : TeaModel {
            [NameInMap("autoAddUser")]
            [Validation(Required=false)]
            public bool? AutoAddUser { get; set; }

            [NameInMap("createDeptGroup")]
            [Validation(Required=false)]
            public bool? CreateDeptGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dept456</para>
            /// </summary>
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>456</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>contact_class_dept</para>
            /// </summary>
            [NameInMap("deptType")]
            [Validation(Required=false)]
            public string DeptType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("fromUnionOrg")]
            [Validation(Required=false)]
            public bool? FromUnionOrg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>软件工程</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>软件工程标识</para>
            /// </summary>
            [NameInMap("sourceIdentifier")]
            [Validation(Required=false)]
            public string SourceIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("struId")]
            [Validation(Required=false)]
            public long? StruId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>campus</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

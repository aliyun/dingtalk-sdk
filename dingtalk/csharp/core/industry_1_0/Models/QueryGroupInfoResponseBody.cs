// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryGroupInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryGroupInfoResponseBodyContent Content { get; set; }
        public class QueryGroupInfoResponseBodyContent : TeaModel {
            [NameInMap("extendInfos")]
            [Validation(Required=false)]
            public List<QueryGroupInfoResponseBodyContentExtendInfos> ExtendInfos { get; set; }
            public class QueryGroupInfoResponseBodyContentExtendInfos : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("deptCode")]
                [Validation(Required=false)]
                public string DeptCode { get; set; }

                [NameInMap("deptExtendDisplayName")]
                [Validation(Required=false)]
                public string DeptExtendDisplayName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("deptExtendKey")]
                [Validation(Required=false)]
                public string DeptExtendKey { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("deptExtendValue")]
                [Validation(Required=false)]
                public string DeptExtendValue { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("group")]
            [Validation(Required=false)]
            public QueryGroupInfoResponseBodyContentGroup Group { get; set; }
            public class QueryGroupInfoResponseBodyContentGroup : TeaModel {
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("deptStatus")]
                [Validation(Required=false)]
                public int? DeptStatus { get; set; }

                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("leader")]
                [Validation(Required=false)]
                public QueryGroupInfoResponseBodyContentGroupLeader Leader { get; set; }
                public class QueryGroupInfoResponseBodyContentGroupLeader : TeaModel {
                    [NameInMap("jobNumber")]
                    [Validation(Required=false)]
                    public string JobNumber { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("parentDeptCode")]
                [Validation(Required=false)]
                public string ParentDeptCode { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

        }

    }

}

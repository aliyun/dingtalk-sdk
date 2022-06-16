// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryGroupInfoResponseBody : TeaModel {
        /// <summary>
        /// 医疗组详情
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryGroupInfoResponseBodyContent Content { get; set; }
        public class QueryGroupInfoResponseBodyContent : TeaModel {
            [NameInMap("extendInfos")]
            [Validation(Required=false)]
            public List<QueryGroupInfoResponseBodyContentExtendInfos> ExtendInfos { get; set; }
            public class QueryGroupInfoResponseBodyContentExtendInfos : TeaModel {
                public string DeptCode { get; set; }
                public string DeptExtendDisplayName { get; set; }
                public string DeptExtendKey { get; set; }
                public string DeptExtendValue { get; set; }
                public string GmtCreateStr { get; set; }
                public string GmtModifiedStr { get; set; }
                public long? Id { get; set; }
                public int? Status { get; set; }
            }
            [NameInMap("group")]
            [Validation(Required=false)]
            public QueryGroupInfoResponseBodyContentGroup Group { get; set; }
            public class QueryGroupInfoResponseBodyContentGroup : TeaModel {
                /// <summary>
                /// 医疗组id
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// 医疗组状态
                /// </summary>
                [NameInMap("deptStatus")]
                [Validation(Required=false)]
                public int? DeptStatus { get; set; }

                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                /// <summary>
                /// 修改时间
                /// </summary>
                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                /// <summary>
                /// id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 组长
                /// </summary>
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
                };

                /// <summary>
                /// 医疗组名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 父code
                /// </summary>
                [NameInMap("parentDeptCode")]
                [Validation(Required=false)]
                public string ParentDeptCode { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }
        };

    }

}

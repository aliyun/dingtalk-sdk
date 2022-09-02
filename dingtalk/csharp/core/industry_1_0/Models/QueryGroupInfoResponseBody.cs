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
            /// <summary>
            /// 扩展信息
            /// </summary>
            [NameInMap("extendInfos")]
            [Validation(Required=false)]
            public List<QueryGroupInfoResponseBodyContentExtendInfos> ExtendInfos { get; set; }
            public class QueryGroupInfoResponseBodyContentExtendInfos : TeaModel {
                /// <summary>
                /// 医疗组code
                /// </summary>
                [NameInMap("deptCode")]
                [Validation(Required=false)]
                public string DeptCode { get; set; }

                /// <summary>
                /// 扩展属性显示名称
                /// </summary>
                [NameInMap("deptExtendDisplayName")]
                [Validation(Required=false)]
                public string DeptExtendDisplayName { get; set; }

                /// <summary>
                /// 扩展属性key
                /// </summary>
                [NameInMap("deptExtendKey")]
                [Validation(Required=false)]
                public string DeptExtendKey { get; set; }

                /// <summary>
                /// 扩展属性value
                /// </summary>
                [NameInMap("deptExtendValue")]
                [Validation(Required=false)]
                public string DeptExtendValue { get; set; }

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
                /// 状态
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// 医疗组
            /// </summary>
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
                    /// <summary>
                    /// 工号
                    /// </summary>
                    [NameInMap("jobNumber")]
                    [Validation(Required=false)]
                    public string JobNumber { get; set; }

                    /// <summary>
                    /// 组长名称
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 用户id
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

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

        }

    }

}

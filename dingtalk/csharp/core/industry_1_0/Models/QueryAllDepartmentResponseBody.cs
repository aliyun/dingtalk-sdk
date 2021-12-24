// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryAllDepartmentResponseBody : TeaModel {
        /// <summary>
        /// 科室列表
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryAllDepartmentResponseBodyContent> Content { get; set; }
        public class QueryAllDepartmentResponseBodyContent : TeaModel {
            /// <summary>
            /// 科室ID
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 科室名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 科室详情
            /// </summary>
            [NameInMap("deptAndExt")]
            [Validation(Required=false)]
            public QueryAllDepartmentResponseBodyContentDeptAndExt DeptAndExt { get; set; }
            public class QueryAllDepartmentResponseBodyContentDeptAndExt : TeaModel {
                [NameInMap("department")]
                [Validation(Required=false)]
                public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment Department { get; set; }
                public class QueryAllDepartmentResponseBodyContentDeptAndExtDepartment : TeaModel {
                    /// <summary>
                    /// 科室ID
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

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
                    /// 租户CorpID
                    /// </summary>
                    [NameInMap("corpId")]
                    [Validation(Required=false)]
                    public string CorpId { get; set; }

                    /// <summary>
                    /// 部门code
                    /// </summary>
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    /// <summary>
                    /// 部门类型：1-科室，2-医疗组
                    /// </summary>
                    [NameInMap("deptType")]
                    [Validation(Required=false)]
                    public int? DeptType { get; set; }

                    /// <summary>
                    /// 部门状态：0-正常，1-删除
                    /// </summary>
                    [NameInMap("deptStatus")]
                    [Validation(Required=false)]
                    public int? DeptStatus { get; set; }

                    /// <summary>
                    /// 父部门code（与dept_code来源保持一致）
                    /// </summary>
                    [NameInMap("parentDeptCode")]
                    [Validation(Required=false)]
                    public string ParentDeptCode { get; set; }

                    /// <summary>
                    /// 排序
                    /// </summary>
                    [NameInMap("deptOrder")]
                    [Validation(Required=false)]
                    public long? DeptOrder { get; set; }

                    /// <summary>
                    /// 备注
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// 科室名称，同name
                    /// </summary>
                    [NameInMap("deptName")]
                    [Validation(Required=false)]
                    public string DeptName { get; set; }

                    /// <summary>
                    /// 科室名称，同deptName
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 病区id列表
                    /// </summary>
                    [NameInMap("wardIdList")]
                    [Validation(Required=false)]
                    public List<QueryAllDepartmentResponseBodyContentDeptAndExtDepartmentWardIdList> WardIdList { get; set; }
                    public class QueryAllDepartmentResponseBodyContentDeptAndExtDepartmentWardIdList : TeaModel {
                        /// <summary>
                        /// 病区id
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                    }

                }
                [NameInMap("extendInfos")]
                [Validation(Required=false)]
                public List<QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos> ExtendInfos { get; set; }
                public class QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos : TeaModel {
                    public long? Id { get; set; }
                    public string GmtCreateStr { get; set; }
                    public string GmtModifiedStr { get; set; }
                    public string CorpId { get; set; }
                    public string DeptCode { get; set; }
                    public string DeptExtendKey { get; set; }
                    public string DeptExtendValue { get; set; }
                    public string DeptExtendDisplayName { get; set; }
                    public int? Status { get; set; }
                }
            };

            /// <summary>
            /// 医疗组列表
            /// </summary>
            [NameInMap("groupAndExtList")]
            [Validation(Required=false)]
            public List<QueryAllDepartmentResponseBodyContentGroupAndExtList> GroupAndExtList { get; set; }
            public class QueryAllDepartmentResponseBodyContentGroupAndExtList : TeaModel {
                /// <summary>
                /// 医疗组详细信息
                /// </summary>
                [NameInMap("group")]
                [Validation(Required=false)]
                public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup Group { get; set; }
                public class QueryAllDepartmentResponseBodyContentGroupAndExtListGroup : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                    [NameInMap("deptId")]
                    [Validation(Required=false)]
                    public long? DeptId { get; set; }
                    [NameInMap("gmtCreateStr")]
                    [Validation(Required=false)]
                    public string GmtCreateStr { get; set; }
                    [NameInMap("gmtModifiedStr")]
                    [Validation(Required=false)]
                    public string GmtModifiedStr { get; set; }
                    [NameInMap("corpId")]
                    [Validation(Required=false)]
                    public string CorpId { get; set; }
                    [NameInMap("leader")]
                    [Validation(Required=false)]
                    public QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader Leader { get; set; }
                    public class QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader : TeaModel {
                        /// <summary>
                        /// 姓名
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// 用户ID
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                        /// <summary>
                        /// 用户工号
                        /// </summary>
                        [NameInMap("jobNumber")]
                        [Validation(Required=false)]
                        public string JobNumber { get; set; }

                    }
                    [NameInMap("deptStatus")]
                    [Validation(Required=false)]
                    public int? DeptStatus { get; set; }
                    [NameInMap("parentDeptCode")]
                    [Validation(Required=false)]
                    public string ParentDeptCode { get; set; }
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }
                };

                /// <summary>
                /// 医疗组扩展信息列表
                /// </summary>
                [NameInMap("extendInfos")]
                [Validation(Required=false)]
                public List<QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos> ExtendInfos { get; set; }
                public class QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos : TeaModel {
                    /// <summary>
                    /// 扩展信息id
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

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
                    /// 租户CorpID
                    /// </summary>
                    [NameInMap("corpId")]
                    [Validation(Required=false)]
                    public string CorpId { get; set; }

                    /// <summary>
                    /// 部门code
                    /// </summary>
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    /// <summary>
                    /// 医疗组扩展字段key
                    /// </summary>
                    [NameInMap("deptExtendKey")]
                    [Validation(Required=false)]
                    public string DeptExtendKey { get; set; }

                    /// <summary>
                    /// 医疗组扩展字段value
                    /// </summary>
                    [NameInMap("deptExtendValue")]
                    [Validation(Required=false)]
                    public string DeptExtendValue { get; set; }

                    /// <summary>
                    /// 医疗组扩展字段描述
                    /// </summary>
                    [NameInMap("deptExtendDisplayName")]
                    [Validation(Required=false)]
                    public string DeptExtendDisplayName { get; set; }

                    /// <summary>
                    /// 0-有效 ，1-无效
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

            }

        }

        /// <summary>
        /// 当前页码
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}

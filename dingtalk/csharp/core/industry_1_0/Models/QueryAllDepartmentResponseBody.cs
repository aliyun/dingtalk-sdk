// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryAllDepartmentResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryAllDepartmentResponseBodyContent> Content { get; set; }
        public class QueryAllDepartmentResponseBodyContent : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptAndExt")]
            [Validation(Required=false)]
            public QueryAllDepartmentResponseBodyContentDeptAndExt DeptAndExt { get; set; }
            public class QueryAllDepartmentResponseBodyContentDeptAndExt : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment Department { get; set; }
                public class QueryAllDepartmentResponseBodyContentDeptAndExtDepartment : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("deptName")]
                    [Validation(Required=false)]
                    public string DeptName { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("deptOrder")]
                    [Validation(Required=false)]
                    public long? DeptOrder { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("deptStatus")]
                    [Validation(Required=false)]
                    public int? DeptStatus { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("deptType")]
                    [Validation(Required=false)]
                    public int? DeptType { get; set; }

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
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("parentDeptCode")]
                    [Validation(Required=false)]
                    public string ParentDeptCode { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("wardIdList")]
                    [Validation(Required=false)]
                    public List<long?> WardIdList { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("extendInfos")]
                [Validation(Required=false)]
                public List<QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos> ExtendInfos { get; set; }
                public class QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
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

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupAndExtList")]
            [Validation(Required=false)]
            public List<QueryAllDepartmentResponseBodyContentGroupAndExtList> GroupAndExtList { get; set; }
            public class QueryAllDepartmentResponseBodyContentGroupAndExtList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("extendInfos")]
                [Validation(Required=false)]
                public List<QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos> ExtendInfos { get; set; }
                public class QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
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

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("group")]
                [Validation(Required=false)]
                public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup Group { get; set; }
                public class QueryAllDepartmentResponseBodyContentGroupAndExtListGroup : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("deptId")]
                    [Validation(Required=false)]
                    public long? DeptId { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("deptStatus")]
                    [Validation(Required=false)]
                    public int? DeptStatus { get; set; }

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
                    [NameInMap("leader")]
                    [Validation(Required=false)]
                    public QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader Leader { get; set; }
                    public class QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("jobNumber")]
                        [Validation(Required=false)]
                        public string JobNumber { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("parentDeptCode")]
                    [Validation(Required=false)]
                    public string ParentDeptCode { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}

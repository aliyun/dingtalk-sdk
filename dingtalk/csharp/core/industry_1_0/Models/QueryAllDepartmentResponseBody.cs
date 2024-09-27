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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("deptAndExt")]
            [Validation(Required=false)]
            public QueryAllDepartmentResponseBodyContentDeptAndExt DeptAndExt { get; set; }
            public class QueryAllDepartmentResponseBodyContentDeptAndExt : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment Department { get; set; }
                public class QueryAllDepartmentResponseBodyContentDeptAndExtDepartment : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>asd123</para>
                    /// </summary>
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>骨科</para>
                    /// </summary>
                    [NameInMap("deptName")]
                    [Validation(Required=false)]
                    public string DeptName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("deptOrder")]
                    [Validation(Required=false)]
                    public long? DeptOrder { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("deptStatus")]
                    [Validation(Required=false)]
                    public int? DeptStatus { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("deptType")]
                    [Validation(Required=false)]
                    public int? DeptType { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-08-24 20:30:31</para>
                    /// </summary>
                    [NameInMap("gmtCreateStr")]
                    [Validation(Required=false)]
                    public string GmtCreateStr { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-08-24 20:30:31</para>
                    /// </summary>
                    [NameInMap("gmtModifiedStr")]
                    [Validation(Required=false)]
                    public string GmtModifiedStr { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>130000</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>骨科</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>asd123</para>
                    /// </summary>
                    [NameInMap("parentDeptCode")]
                    [Validation(Required=false)]
                    public string ParentDeptCode { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>备注</para>
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("wardIdList")]
                    [Validation(Required=false)]
                    public List<long?> WardIdList { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("extendInfos")]
                [Validation(Required=false)]
                public List<QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos> ExtendInfos { get; set; }
                public class QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>asd123</para>
                    /// </summary>
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>科室、医务科、医生都不一样</para>
                    /// </summary>
                    [NameInMap("deptExtendDisplayName")]
                    [Validation(Required=false)]
                    public string DeptExtendDisplayName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>科室、医务科、医生都不一样</para>
                    /// </summary>
                    [NameInMap("deptExtendKey")]
                    [Validation(Required=false)]
                    public string DeptExtendKey { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>科室、医务科、医生都不一样</para>
                    /// </summary>
                    [NameInMap("deptExtendValue")]
                    [Validation(Required=false)]
                    public string DeptExtendValue { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-08-24 20:30:31</para>
                    /// </summary>
                    [NameInMap("gmtCreateStr")]
                    [Validation(Required=false)]
                    public string GmtCreateStr { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-08-24 20:30:31</para>
                    /// </summary>
                    [NameInMap("gmtModifiedStr")]
                    [Validation(Required=false)]
                    public string GmtModifiedStr { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20000</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("groupAndExtList")]
            [Validation(Required=false)]
            public List<QueryAllDepartmentResponseBodyContentGroupAndExtList> GroupAndExtList { get; set; }
            public class QueryAllDepartmentResponseBodyContentGroupAndExtList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("extendInfos")]
                [Validation(Required=false)]
                public List<QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos> ExtendInfos { get; set; }
                public class QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>asd123</para>
                    /// </summary>
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>科室、医务科、医生都不一样</para>
                    /// </summary>
                    [NameInMap("deptExtendDisplayName")]
                    [Validation(Required=false)]
                    public string DeptExtendDisplayName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>科室、医务科、医生都不一样</para>
                    /// </summary>
                    [NameInMap("deptExtendKey")]
                    [Validation(Required=false)]
                    public string DeptExtendKey { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>科室、医务科、医生都不一样</para>
                    /// </summary>
                    [NameInMap("deptExtendValue")]
                    [Validation(Required=false)]
                    public string DeptExtendValue { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-08-24 20:30:31</para>
                    /// </summary>
                    [NameInMap("gmtCreateStr")]
                    [Validation(Required=false)]
                    public string GmtCreateStr { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-08-24 20:30:31</para>
                    /// </summary>
                    [NameInMap("gmtModifiedStr")]
                    [Validation(Required=false)]
                    public string GmtModifiedStr { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20000</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("group")]
                [Validation(Required=false)]
                public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup Group { get; set; }
                public class QueryAllDepartmentResponseBodyContentGroupAndExtListGroup : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13000</para>
                    /// </summary>
                    [NameInMap("deptId")]
                    [Validation(Required=false)]
                    public long? DeptId { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("deptStatus")]
                    [Validation(Required=false)]
                    public int? DeptStatus { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-08-24 20:30:31</para>
                    /// </summary>
                    [NameInMap("gmtCreateStr")]
                    [Validation(Required=false)]
                    public string GmtCreateStr { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-08-24 20:30:31</para>
                    /// </summary>
                    [NameInMap("gmtModifiedStr")]
                    [Validation(Required=false)]
                    public string GmtModifiedStr { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13001</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("leader")]
                    [Validation(Required=false)]
                    public QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader Leader { get; set; }
                    public class QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>888asd</para>
                        /// </summary>
                        [NameInMap("jobNumber")]
                        [Validation(Required=false)]
                        public string JobNumber { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>张三</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>666abc</para>
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三组</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13000</para>
                    /// </summary>
                    [NameInMap("parentDeptCode")]
                    [Validation(Required=false)]
                    public string ParentDeptCode { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>备注</para>
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130000</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>骨科</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}

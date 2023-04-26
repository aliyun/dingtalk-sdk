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
            [NameInMap("deptAndExt")]
            [Validation(Required=false)]
            public QueryAllDepartmentResponseBodyContentDeptAndExt DeptAndExt { get; set; }
            public class QueryAllDepartmentResponseBodyContentDeptAndExt : TeaModel {
                [NameInMap("department")]
                [Validation(Required=false)]
                public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment Department { get; set; }
                public class QueryAllDepartmentResponseBodyContentDeptAndExtDepartment : TeaModel {
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    [NameInMap("deptName")]
                    [Validation(Required=false)]
                    public string DeptName { get; set; }

                    [NameInMap("deptOrder")]
                    [Validation(Required=false)]
                    public long? DeptOrder { get; set; }

                    [NameInMap("deptStatus")]
                    [Validation(Required=false)]
                    public int? DeptStatus { get; set; }

                    [NameInMap("deptType")]
                    [Validation(Required=false)]
                    public int? DeptType { get; set; }

                    [NameInMap("gmtCreateStr")]
                    [Validation(Required=false)]
                    public string GmtCreateStr { get; set; }

                    [NameInMap("gmtModifiedStr")]
                    [Validation(Required=false)]
                    public string GmtModifiedStr { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("parentDeptCode")]
                    [Validation(Required=false)]
                    public string ParentDeptCode { get; set; }

                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("wardIdList")]
                    [Validation(Required=false)]
                    public List<long?> WardIdList { get; set; }

                }

                [NameInMap("extendInfos")]
                [Validation(Required=false)]
                public List<QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos> ExtendInfos { get; set; }
                public class QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos : TeaModel {
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    [NameInMap("deptExtendDisplayName")]
                    [Validation(Required=false)]
                    public string DeptExtendDisplayName { get; set; }

                    [NameInMap("deptExtendKey")]
                    [Validation(Required=false)]
                    public string DeptExtendKey { get; set; }

                    [NameInMap("deptExtendValue")]
                    [Validation(Required=false)]
                    public string DeptExtendValue { get; set; }

                    [NameInMap("gmtCreateStr")]
                    [Validation(Required=false)]
                    public string GmtCreateStr { get; set; }

                    [NameInMap("gmtModifiedStr")]
                    [Validation(Required=false)]
                    public string GmtModifiedStr { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

            }

            [NameInMap("groupAndExtList")]
            [Validation(Required=false)]
            public List<QueryAllDepartmentResponseBodyContentGroupAndExtList> GroupAndExtList { get; set; }
            public class QueryAllDepartmentResponseBodyContentGroupAndExtList : TeaModel {
                [NameInMap("extendInfos")]
                [Validation(Required=false)]
                public List<QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos> ExtendInfos { get; set; }
                public class QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos : TeaModel {
                    [NameInMap("deptCode")]
                    [Validation(Required=false)]
                    public string DeptCode { get; set; }

                    [NameInMap("deptExtendDisplayName")]
                    [Validation(Required=false)]
                    public string DeptExtendDisplayName { get; set; }

                    [NameInMap("deptExtendKey")]
                    [Validation(Required=false)]
                    public string DeptExtendKey { get; set; }

                    [NameInMap("deptExtendValue")]
                    [Validation(Required=false)]
                    public string DeptExtendValue { get; set; }

                    [NameInMap("gmtCreateStr")]
                    [Validation(Required=false)]
                    public string GmtCreateStr { get; set; }

                    [NameInMap("gmtModifiedStr")]
                    [Validation(Required=false)]
                    public string GmtModifiedStr { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

                [NameInMap("group")]
                [Validation(Required=false)]
                public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup Group { get; set; }
                public class QueryAllDepartmentResponseBodyContentGroupAndExtListGroup : TeaModel {
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
                    public QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader Leader { get; set; }
                    public class QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader : TeaModel {
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

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

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

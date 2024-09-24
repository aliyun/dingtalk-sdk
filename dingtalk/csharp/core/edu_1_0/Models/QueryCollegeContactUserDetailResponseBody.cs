// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryCollegeContactUserDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryCollegeContactUserDetailResponseBodyResult Result { get; set; }
        public class QueryCollegeContactUserDetailResponseBodyResult : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("admin")]
            [Validation(Required=false)]
            public bool? Admin { get; set; }

            [NameInMap("avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            [NameInMap("boss")]
            [Validation(Required=false)]
            public bool? Boss { get; set; }

            [NameInMap("deptIdList")]
            [Validation(Required=false)]
            public List<long?> DeptIdList { get; set; }

            [NameInMap("deptOrderList")]
            [Validation(Required=false)]
            public List<QueryCollegeContactUserDetailResponseBodyResultDeptOrderList> DeptOrderList { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultDeptOrderList : TeaModel {
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

            }

            [NameInMap("deptTypeSet")]
            [Validation(Required=false)]
            public List<QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet> DeptTypeSet { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet : TeaModel {
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("deptStructType")]
                [Validation(Required=false)]
                public string DeptStructType { get; set; }

                [NameInMap("deptType")]
                [Validation(Required=false)]
                public string DeptType { get; set; }

                [NameInMap("structDeptId")]
                [Validation(Required=false)]
                public long? StructDeptId { get; set; }

            }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("empType")]
            [Validation(Required=false)]
            public string EmpType { get; set; }

            [NameInMap("exclusiveAccount")]
            [Validation(Required=false)]
            public bool? ExclusiveAccount { get; set; }

            [NameInMap("exclusiveAccountCorpId")]
            [Validation(Required=false)]
            public string ExclusiveAccountCorpId { get; set; }

            [NameInMap("exclusiveAccountCorpName")]
            [Validation(Required=false)]
            public string ExclusiveAccountCorpName { get; set; }

            [NameInMap("exclusiveAccountType")]
            [Validation(Required=false)]
            public string ExclusiveAccountType { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("hideMobile")]
            [Validation(Required=false)]
            public bool? HideMobile { get; set; }

            [NameInMap("hiredDate")]
            [Validation(Required=false)]
            public long? HiredDate { get; set; }

            [NameInMap("jobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            [NameInMap("leaderInDept")]
            [Validation(Required=false)]
            public List<QueryCollegeContactUserDetailResponseBodyResultLeaderInDept> LeaderInDept { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultLeaderInDept : TeaModel {
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("leader")]
                [Validation(Required=false)]
                public bool? Leader { get; set; }

            }

            [NameInMap("loginId")]
            [Validation(Required=false)]
            public string LoginId { get; set; }

            [NameInMap("loginType")]
            [Validation(Required=false)]
            public string LoginType { get; set; }

            [NameInMap("mainDeptId")]
            [Validation(Required=false)]
            public long? MainDeptId { get; set; }

            [NameInMap("managerUserid")]
            [Validation(Required=false)]
            public string ManagerUserid { get; set; }

            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("orgEmail")]
            [Validation(Required=false)]
            public string OrgEmail { get; set; }

            [NameInMap("orgEmailType")]
            [Validation(Required=false)]
            public string OrgEmailType { get; set; }

            [NameInMap("realAuthed")]
            [Validation(Required=false)]
            public bool? RealAuthed { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("roleList")]
            [Validation(Required=false)]
            public List<QueryCollegeContactUserDetailResponseBodyResultRoleList> RoleList { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultRoleList : TeaModel {
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("senior")]
            [Validation(Required=false)]
            public bool? Senior { get; set; }

            [NameInMap("stateCode")]
            [Validation(Required=false)]
            public string StateCode { get; set; }

            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("unionEmpExt")]
            [Validation(Required=false)]
            public QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt UnionEmpExt { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("unionEmpMapList")]
                [Validation(Required=false)]
                public List<QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList> UnionEmpMapList { get; set; }
                public class QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList : TeaModel {
                    [NameInMap("corpId")]
                    [Validation(Required=false)]
                    public string CorpId { get; set; }

                    [NameInMap("userid")]
                    [Validation(Required=false)]
                    public string Userid { get; set; }

                }

                [NameInMap("userid")]
                [Validation(Required=false)]
                public string Userid { get; set; }

            }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

            [NameInMap("workPlace")]
            [Validation(Required=false)]
            public string WorkPlace { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

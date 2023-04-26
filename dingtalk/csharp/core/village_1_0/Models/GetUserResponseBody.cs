// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetUserResponseBody : TeaModel {
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        [NameInMap("admin")]
        [Validation(Required=false)]
        public bool? Admin { get; set; }

        [NameInMap("boss")]
        [Validation(Required=false)]
        public bool? Boss { get; set; }

        [NameInMap("departmentIdList")]
        [Validation(Required=false)]
        public List<long?> DepartmentIdList { get; set; }

        [NameInMap("departmentOrderSet")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyDepartmentOrderSet> DepartmentOrderSet { get; set; }
        public class GetUserResponseBodyDepartmentOrderSet : TeaModel {
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

        }

        [NameInMap("exclusiveAccount")]
        [Validation(Required=false)]
        public bool? ExclusiveAccount { get; set; }

        [NameInMap("exclusiveAccountType")]
        [Validation(Required=false)]
        public string ExclusiveAccountType { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        [NameInMap("hiredDate")]
        [Validation(Required=false)]
        public long? HiredDate { get; set; }

        [NameInMap("jobNumber")]
        [Validation(Required=false)]
        public string JobNumber { get; set; }

        [NameInMap("leaderInDepartment")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyLeaderInDepartment> LeaderInDepartment { get; set; }
        public class GetUserResponseBodyLeaderInDepartment : TeaModel {
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            [NameInMap("leader")]
            [Validation(Required=false)]
            public bool? Leader { get; set; }

        }

        [NameInMap("managerUserId")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("realAuthed")]
        [Validation(Required=false)]
        public bool? RealAuthed { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("roleList")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyRoleList> RoleList { get; set; }
        public class GetUserResponseBodyRoleList : TeaModel {
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        [NameInMap("senior")]
        [Validation(Required=false)]
        public bool? Senior { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("unionEmpExt")]
        [Validation(Required=false)]
        public GetUserResponseBodyUnionEmpExt UnionEmpExt { get; set; }
        public class GetUserResponseBodyUnionEmpExt : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

            [NameInMap("unionEmpMapList")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUnionEmpExtUnionEmpMapList> UnionEmpMapList { get; set; }
            public class GetUserResponseBodyUnionEmpExtUnionEmpMapList : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("staffId")]
                [Validation(Required=false)]
                public string StaffId { get; set; }

            }

        }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("workPlace")]
        [Validation(Required=false)]
        public string WorkPlace { get; set; }

    }

}

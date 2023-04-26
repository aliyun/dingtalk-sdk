// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryDoctorDetailsByJobNumberResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryDoctorDetailsByJobNumberResponseBodyContent Content { get; set; }
        public class QueryDoctorDetailsByJobNumberResponseBodyContent : TeaModel {
            [NameInMap("deptList")]
            [Validation(Required=false)]
            public List<QueryDoctorDetailsByJobNumberResponseBodyContentDeptList> DeptList { get; set; }
            public class QueryDoctorDetailsByJobNumberResponseBodyContentDeptList : TeaModel {
                [NameInMap("categoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("relationId")]
                [Validation(Required=false)]
                public long? RelationId { get; set; }

            }

            [NameInMap("groupList")]
            [Validation(Required=false)]
            public List<QueryDoctorDetailsByJobNumberResponseBodyContentGroupList> GroupList { get; set; }
            public class QueryDoctorDetailsByJobNumberResponseBodyContentGroupList : TeaModel {
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("groupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("isAssessGroup")]
                [Validation(Required=false)]
                public string IsAssessGroup { get; set; }

                [NameInMap("isLeader")]
                [Validation(Required=false)]
                public bool? IsLeader { get; set; }

                [NameInMap("relationId")]
                [Validation(Required=false)]
                public long? RelationId { get; set; }

            }

            [NameInMap("jobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public List<QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus> JobStatus { get; set; }
            public class QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("statusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

            }

            [NameInMap("professionalTitle")]
            [Validation(Required=false)]
            public QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle ProfessionalTitle { get; set; }
            public class QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("professionalTitleCategory")]
                [Validation(Required=false)]
                public string ProfessionalTitleCategory { get; set; }

                [NameInMap("professionalTitleDetail")]
                [Validation(Required=false)]
                public string ProfessionalTitleDetail { get; set; }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("userProbList")]
            [Validation(Required=false)]
            public List<QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList> UserProbList { get; set; }
            public class QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("userPropertyName")]
                [Validation(Required=false)]
                public string UserPropertyName { get; set; }

            }

        }

    }

}

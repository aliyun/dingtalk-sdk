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
            /// <summary>
            /// 科室列表
            /// </summary>
            [NameInMap("deptList")]
            [Validation(Required=false)]
            public List<QueryDoctorDetailsByJobNumberResponseBodyContentDeptList> DeptList { get; set; }
            public class QueryDoctorDetailsByJobNumberResponseBodyContentDeptList : TeaModel {
                /// <summary>
                /// 科室大类名称
                /// </summary>
                [NameInMap("categoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// 科室id
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// 科室名称
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// 修改时间
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// 人科关系关联id
                /// </summary>
                [NameInMap("relationId")]
                [Validation(Required=false)]
                public long? RelationId { get; set; }

            }

            /// <summary>
            /// 医疗组列表
            /// </summary>
            [NameInMap("groupList")]
            [Validation(Required=false)]
            public List<QueryDoctorDetailsByJobNumberResponseBodyContentGroupList> GroupList { get; set; }
            public class QueryDoctorDetailsByJobNumberResponseBodyContentGroupList : TeaModel {
                /// <summary>
                /// 科室id
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// 科室名称
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// 医疗组id
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// 医疗组名称
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// 用户在该医疗组是否为考核医疗组
                /// </summary>
                [NameInMap("isAssessGroup")]
                [Validation(Required=false)]
                public string IsAssessGroup { get; set; }

                /// <summary>
                /// 用户在该医疗组是否为组长
                /// </summary>
                [NameInMap("isLeader")]
                [Validation(Required=false)]
                public bool? IsLeader { get; set; }

                /// <summary>
                /// 人组关系关联id
                /// </summary>
                [NameInMap("relationId")]
                [Validation(Required=false)]
                public long? RelationId { get; set; }

            }

            /// <summary>
            /// 工号
            /// </summary>
            [NameInMap("jobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            /// <summary>
            /// 状态列表
            /// </summary>
            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public List<QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus> JobStatus { get; set; }
            public class QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus : TeaModel {
                /// <summary>
                /// 状态编码
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 状态名称
                /// </summary>
                [NameInMap("statusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

            }

            /// <summary>
            /// 职称
            /// </summary>
            [NameInMap("professionalTitle")]
            [Validation(Required=false)]
            public QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle ProfessionalTitle { get; set; }
            public class QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle : TeaModel {
                /// <summary>
                /// 职称编码
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 职称大类
                /// </summary>
                [NameInMap("professionalTitleCategory")]
                [Validation(Required=false)]
                public string ProfessionalTitleCategory { get; set; }

                /// <summary>
                /// 职称明细
                /// </summary>
                [NameInMap("professionalTitleDetail")]
                [Validation(Required=false)]
                public string ProfessionalTitleDetail { get; set; }

            }

            /// <summary>
            /// 医生的userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 用户名称
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// 身份属性
            /// </summary>
            [NameInMap("userProbList")]
            [Validation(Required=false)]
            public List<QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList> UserProbList { get; set; }
            public class QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList : TeaModel {
                /// <summary>
                /// 身份属性编码
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 身份属性名称
                /// </summary>
                [NameInMap("userPropertyName")]
                [Validation(Required=false)]
                public string UserPropertyName { get; set; }

            }

        }

    }

}

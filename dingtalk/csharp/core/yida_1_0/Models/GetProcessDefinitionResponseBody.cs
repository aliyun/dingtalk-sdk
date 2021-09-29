// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetProcessDefinitionResponseBody : TeaModel {
        /// <summary>
        /// outResult
        /// </summary>
        [NameInMap("outResult")]
        [Validation(Required=false)]
        public string OutResult { get; set; }

        /// <summary>
        /// processInstanceId
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// variables
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

        /// <summary>
        /// formUuid
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// processId
        /// </summary>
        [NameInMap("processId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// owners
        /// </summary>
        [NameInMap("owners")]
        [Validation(Required=false)]
        public List<GetProcessDefinitionResponseBodyOwners> Owners { get; set; }
        public class GetProcessDefinitionResponseBodyOwners : TeaModel {
            /// <summary>
            /// userInfo
            /// </summary>
            [NameInMap("userInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

            /// <summary>
            /// tbWang
            /// </summary>
            [NameInMap("tbWang")]
            [Validation(Required=false)]
            public string TbWang { get; set; }

            /// <summary>
            /// orderNum
            /// </summary>
            [NameInMap("orderNumber")]
            [Validation(Required=false)]
            public string OrderNumber { get; set; }

            /// <summary>
            /// departmentDescription
            /// </summary>
            [NameInMap("departmentDescription")]
            [Validation(Required=false)]
            public string DepartmentDescription { get; set; }

            /// <summary>
            /// displayName
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// masterDataDepartments
            /// </summary>
            [NameInMap("masterDataDepartments")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyOwnersMasterDataDepartments> MasterDataDepartments { get; set; }
            public class GetProcessDefinitionResponseBodyOwnersMasterDataDepartments : TeaModel {
                /// <summary>
                /// humanSourceGroupOrderNum
                /// </summary>
                [NameInMap("humanSourceGroupOrderNumber")]
                [Validation(Required=false)]
                public string HumanSourceGroupOrderNumber { get; set; }

                /// <summary>
                /// deptPath
                /// </summary>
                [NameInMap("deptPath")]
                [Validation(Required=false)]
                public string DeptPath { get; set; }

                /// <summary>
                /// deptName
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// deptNameEn
                /// </summary>
                [NameInMap("deptNameInEnglish")]
                [Validation(Required=false)]
                public string DeptNameInEnglish { get; set; }

                /// <summary>
                /// humanSourceGroupWorkNo
                /// </summary>
                [NameInMap("humanSourceGroupWorkNo")]
                [Validation(Required=false)]
                public string HumanSourceGroupWorkNo { get; set; }

                /// <summary>
                /// id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// masterWorkNo
                /// </summary>
                [NameInMap("masterWorkNo")]
                [Validation(Required=false)]
                public string MasterWorkNo { get; set; }

                /// <summary>
                /// deptNo
                /// </summary>
                [NameInMap("deptNo")]
                [Validation(Required=false)]
                public string DeptNo { get; set; }

            }

            /// <summary>
            /// displayEnName
            /// </summary>
            [NameInMap("displayEnName")]
            [Validation(Required=false)]
            public string DisplayEnName { get; set; }

            /// <summary>
            /// userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// personalPhoto
            /// </summary>
            [NameInMap("personalPhoto")]
            [Validation(Required=false)]
            public string PersonalPhoto { get; set; }

            /// <summary>
            /// status
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// originator
        /// </summary>
        [NameInMap("originator")]
        [Validation(Required=false)]
        public GetProcessDefinitionResponseBodyOriginator Originator { get; set; }
        public class GetProcessDefinitionResponseBodyOriginator : TeaModel {
            [NameInMap("userInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }
            [NameInMap("tbWang")]
            [Validation(Required=false)]
            public string TbWang { get; set; }
            [NameInMap("orderNumber")]
            [Validation(Required=false)]
            public string OrderNumber { get; set; }
            [NameInMap("departmentDescription")]
            [Validation(Required=false)]
            public string DepartmentDescription { get; set; }
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("masterDataDepartments")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments> MasterDataDepartments { get; set; }
            public class GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments : TeaModel {
                public string HumanSourceGroupOrderNumber { get; set; }
                public string DeptPath { get; set; }
                public string DeptName { get; set; }
                public string DeptNameInEnglish { get; set; }
                public string HumanSourceGroupWorkNo { get; set; }
                public long? Id { get; set; }
                public string MasterWorkNo { get; set; }
                public string DeptNo { get; set; }
            }
            [NameInMap("displayEnName")]
            [Validation(Required=false)]
            public string DisplayEnName { get; set; }
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("personalPhoto")]
            [Validation(Required=false)]
            public string PersonalPhoto { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        /// <summary>
        /// title
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// tasks
        /// </summary>
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<GetProcessDefinitionResponseBodyTasks> Tasks { get; set; }
        public class GetProcessDefinitionResponseBodyTasks : TeaModel {
            /// <summary>
            /// actioner
            /// </summary>
            [NameInMap("actionerId")]
            [Validation(Required=false)]
            public string ActionerId { get; set; }

            /// <summary>
            /// activity
            /// </summary>
            [NameInMap("activity")]
            [Validation(Required=false)]
            public GetProcessDefinitionResponseBodyTasksActivity Activity { get; set; }
            public class GetProcessDefinitionResponseBodyTasksActivity : TeaModel {
                [NameInMap("activityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }
                [NameInMap("activityNameInEnglish")]
                [Validation(Required=false)]
                public string ActivityNameInEnglish { get; set; }
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }
                [NameInMap("activityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }
            };

            /// <summary>
            /// taskId
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// status
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// status
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

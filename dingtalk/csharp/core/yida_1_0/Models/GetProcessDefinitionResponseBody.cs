// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetProcessDefinitionResponseBody : TeaModel {
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        [NameInMap("originator")]
        [Validation(Required=false)]
        public GetProcessDefinitionResponseBodyOriginator Originator { get; set; }
        public class GetProcessDefinitionResponseBodyOriginator : TeaModel {
            [NameInMap("departmentDescription")]
            [Validation(Required=false)]
            public string DepartmentDescription { get; set; }

            [NameInMap("displayEnName")]
            [Validation(Required=false)]
            public string DisplayEnName { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("masterDataDepartments")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments> MasterDataDepartments { get; set; }
            public class GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments : TeaModel {
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("deptNameInEnglish")]
                [Validation(Required=false)]
                public string DeptNameInEnglish { get; set; }

                [NameInMap("deptNo")]
                [Validation(Required=false)]
                public string DeptNo { get; set; }

                [NameInMap("deptPath")]
                [Validation(Required=false)]
                public string DeptPath { get; set; }

                [NameInMap("humanSourceGroupOrderNumber")]
                [Validation(Required=false)]
                public string HumanSourceGroupOrderNumber { get; set; }

                [NameInMap("humanSourceGroupWorkNo")]
                [Validation(Required=false)]
                public string HumanSourceGroupWorkNo { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("masterWorkNo")]
                [Validation(Required=false)]
                public string MasterWorkNo { get; set; }

            }

            [NameInMap("orderNumber")]
            [Validation(Required=false)]
            public string OrderNumber { get; set; }

            [NameInMap("personalPhoto")]
            [Validation(Required=false)]
            public string PersonalPhoto { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tbWang")]
            [Validation(Required=false)]
            public string TbWang { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

        }

        [NameInMap("outResult")]
        [Validation(Required=false)]
        public string OutResult { get; set; }

        [NameInMap("owners")]
        [Validation(Required=false)]
        public List<GetProcessDefinitionResponseBodyOwners> Owners { get; set; }
        public class GetProcessDefinitionResponseBodyOwners : TeaModel {
            [NameInMap("departmentDescription")]
            [Validation(Required=false)]
            public string DepartmentDescription { get; set; }

            [NameInMap("displayEnName")]
            [Validation(Required=false)]
            public string DisplayEnName { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("masterDataDepartments")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyOwnersMasterDataDepartments> MasterDataDepartments { get; set; }
            public class GetProcessDefinitionResponseBodyOwnersMasterDataDepartments : TeaModel {
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("deptNameInEnglish")]
                [Validation(Required=false)]
                public string DeptNameInEnglish { get; set; }

                [NameInMap("deptNo")]
                [Validation(Required=false)]
                public string DeptNo { get; set; }

                [NameInMap("deptPath")]
                [Validation(Required=false)]
                public string DeptPath { get; set; }

                [NameInMap("humanSourceGroupOrderNumber")]
                [Validation(Required=false)]
                public string HumanSourceGroupOrderNumber { get; set; }

                [NameInMap("humanSourceGroupWorkNo")]
                [Validation(Required=false)]
                public string HumanSourceGroupWorkNo { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("masterWorkNo")]
                [Validation(Required=false)]
                public string MasterWorkNo { get; set; }

            }

            [NameInMap("orderNumber")]
            [Validation(Required=false)]
            public string OrderNumber { get; set; }

            [NameInMap("personalPhoto")]
            [Validation(Required=false)]
            public string PersonalPhoto { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tbWang")]
            [Validation(Required=false)]
            public string TbWang { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

        }

        [NameInMap("processId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<GetProcessDefinitionResponseBodyTasks> Tasks { get; set; }
        public class GetProcessDefinitionResponseBodyTasks : TeaModel {
            [NameInMap("actionerId")]
            [Validation(Required=false)]
            public string ActionerId { get; set; }

            [NameInMap("activity")]
            [Validation(Required=false)]
            public GetProcessDefinitionResponseBodyTasksActivity Activity { get; set; }
            public class GetProcessDefinitionResponseBodyTasksActivity : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("activityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }

                [NameInMap("activityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                [NameInMap("activityNameInEnglish")]
                [Validation(Required=false)]
                public string ActivityNameInEnglish { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

    }

}

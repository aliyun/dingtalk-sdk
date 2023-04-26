// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetMeCorpSubmissionResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetMeCorpSubmissionResponseBodyData> Data { get; set; }
        public class GetMeCorpSubmissionResponseBodyData : TeaModel {
            [NameInMap("actioner")]
            [Validation(Required=false)]
            public List<GetMeCorpSubmissionResponseBodyDataActioner> Actioner { get; set; }
            public class GetMeCorpSubmissionResponseBodyDataActioner : TeaModel {
                [NameInMap("buName")]
                [Validation(Required=false)]
                public string BuName { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("employeeType")]
                [Validation(Required=false)]
                public string EmployeeType { get; set; }

                [NameInMap("employeeTypeInformation")]
                [Validation(Required=false)]
                public string EmployeeTypeInformation { get; set; }

                [NameInMap("humanResourceGroupWorkNumber")]
                [Validation(Required=false)]
                public string HumanResourceGroupWorkNumber { get; set; }

                [NameInMap("isSystemAdmin")]
                [Validation(Required=false)]
                public bool? IsSystemAdmin { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("orderNumber")]
                [Validation(Required=false)]
                public string OrderNumber { get; set; }

                [NameInMap("personalPhoto")]
                [Validation(Required=false)]
                public string PersonalPhoto { get; set; }

                [NameInMap("personalPhotoUrl")]
                [Validation(Required=false)]
                public string PersonalPhotoUrl { get; set; }

                [NameInMap("pinyinNameAll")]
                [Validation(Required=false)]
                public string PinyinNameAll { get; set; }

                [NameInMap("pinyinNickName")]
                [Validation(Required=false)]
                public string PinyinNickName { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("superUserId")]
                [Validation(Required=false)]
                public string SuperUserId { get; set; }

                [NameInMap("tbWang")]
                [Validation(Required=false)]
                public string TbWang { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("actionerId")]
            [Validation(Required=false)]
            public List<string> ActionerId { get; set; }

            [NameInMap("actionerName")]
            [Validation(Required=false)]
            public List<string> ActionerName { get; set; }

            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("currentActivityInstances")]
            [Validation(Required=false)]
            public List<GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances> CurrentActivityInstances { get; set; }
            public class GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("activityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }

                [NameInMap("activityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                [NameInMap("activityNameEn")]
                [Validation(Required=false)]
                public string ActivityNameEn { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("dataMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> DataMap { get; set; }

            [NameInMap("dataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("originatorAvatar")]
            [Validation(Required=false)]
            public string OriginatorAvatar { get; set; }

            [NameInMap("originatorDisplayName")]
            [Validation(Required=false)]
            public string OriginatorDisplayName { get; set; }

            [NameInMap("originatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            [NameInMap("processApprovedResult")]
            [Validation(Required=false)]
            public string ProcessApprovedResult { get; set; }

            [NameInMap("processApprovedResultText")]
            [Validation(Required=false)]
            public string ProcessApprovedResultText { get; set; }

            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("processInstanceStatus")]
            [Validation(Required=false)]
            public string ProcessInstanceStatus { get; set; }

            [NameInMap("processInstanceStatusText")]
            [Validation(Required=false)]
            public string ProcessInstanceStatusText { get; set; }

            [NameInMap("processName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

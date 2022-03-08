// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetMeCorpSubmissionResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetMeCorpSubmissionResponseBodyData> Data { get; set; }
        public class GetMeCorpSubmissionResponseBodyData : TeaModel {
            /// <summary>
            /// actioner
            /// </summary>
            [NameInMap("actioner")]
            [Validation(Required=false)]
            public List<GetMeCorpSubmissionResponseBodyDataActioner> Actioner { get; set; }
            public class GetMeCorpSubmissionResponseBodyDataActioner : TeaModel {
                /// <summary>
                /// buName
                /// </summary>
                [NameInMap("buName")]
                [Validation(Required=false)]
                public string BuName { get; set; }

                /// <summary>
                /// email
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// empType
                /// </summary>
                [NameInMap("employeeType")]
                [Validation(Required=false)]
                public string EmployeeType { get; set; }

                /// <summary>
                /// employeeTypeInformation
                /// </summary>
                [NameInMap("employeeTypeInformation")]
                [Validation(Required=false)]
                public string EmployeeTypeInformation { get; set; }

                /// <summary>
                /// hrgWorkNo
                /// </summary>
                [NameInMap("humanResourceGroupWorkNumber")]
                [Validation(Required=false)]
                public string HumanResourceGroupWorkNumber { get; set; }

                /// <summary>
                /// isSystemAdmin
                /// </summary>
                [NameInMap("isSystemAdmin")]
                [Validation(Required=false)]
                public bool? IsSystemAdmin { get; set; }

                /// <summary>
                /// level
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// nickName
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// orderNum
                /// </summary>
                [NameInMap("orderNumber")]
                [Validation(Required=false)]
                public string OrderNumber { get; set; }

                /// <summary>
                /// personalPhoto
                /// </summary>
                [NameInMap("personalPhoto")]
                [Validation(Required=false)]
                public string PersonalPhoto { get; set; }

                /// <summary>
                /// personalPhotoUrl
                /// </summary>
                [NameInMap("personalPhotoUrl")]
                [Validation(Required=false)]
                public string PersonalPhotoUrl { get; set; }

                /// <summary>
                /// pinyinNameAll
                /// </summary>
                [NameInMap("pinyinNameAll")]
                [Validation(Required=false)]
                public string PinyinNameAll { get; set; }

                /// <summary>
                /// pinyinNick
                /// </summary>
                [NameInMap("pinyinNickName")]
                [Validation(Required=false)]
                public string PinyinNickName { get; set; }

                /// <summary>
                /// state
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// superUserId
                /// </summary>
                [NameInMap("superUserId")]
                [Validation(Required=false)]
                public string SuperUserId { get; set; }

                /// <summary>
                /// tbWang
                /// </summary>
                [NameInMap("tbWang")]
                [Validation(Required=false)]
                public string TbWang { get; set; }

                /// <summary>
                /// userId
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// actionerId
            /// </summary>
            [NameInMap("actionerId")]
            [Validation(Required=false)]
            public List<string> ActionerId { get; set; }

            /// <summary>
            /// actionerName
            /// </summary>
            [NameInMap("actionerName")]
            [Validation(Required=false)]
            public List<string> ActionerName { get; set; }

            /// <summary>
            /// appType
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// createTime
            /// </summary>
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// currentActivityInstances
            /// </summary>
            [NameInMap("currentActivityInstances")]
            [Validation(Required=false)]
            public List<GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances> CurrentActivityInstances { get; set; }
            public class GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances : TeaModel {
                /// <summary>
                /// activityId
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// activityInstanceStatus
                /// </summary>
                [NameInMap("activityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }

                /// <summary>
                /// activityName
                /// </summary>
                [NameInMap("activityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                /// <summary>
                /// activityNameEn
                /// </summary>
                [NameInMap("activityNameEn")]
                [Validation(Required=false)]
                public string ActivityNameEn { get; set; }

                /// <summary>
                /// id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            /// <summary>
            /// dataMap
            /// </summary>
            [NameInMap("dataMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> DataMap { get; set; }

            /// <summary>
            /// dataType
            /// </summary>
            [NameInMap("dataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// finishTime
            /// </summary>
            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            /// <summary>
            /// formInstanceId
            /// </summary>
            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// formUuid
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// instValue
            /// </summary>
            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            /// <summary>
            /// modifiedTime
            /// </summary>
            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// originatorAvatar
            /// </summary>
            [NameInMap("originatorAvatar")]
            [Validation(Required=false)]
            public string OriginatorAvatar { get; set; }

            /// <summary>
            /// originatorDisplayName
            /// </summary>
            [NameInMap("originatorDisplayName")]
            [Validation(Required=false)]
            public string OriginatorDisplayName { get; set; }

            /// <summary>
            /// originatorId
            /// </summary>
            [NameInMap("originatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            /// <summary>
            /// processApprovedResult
            /// </summary>
            [NameInMap("processApprovedResult")]
            [Validation(Required=false)]
            public string ProcessApprovedResult { get; set; }

            /// <summary>
            /// processApprovedResultText
            /// </summary>
            [NameInMap("processApprovedResultText")]
            [Validation(Required=false)]
            public string ProcessApprovedResultText { get; set; }

            /// <summary>
            /// processCode
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// processId
            /// </summary>
            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// processInstanceId
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// processInstanceStatus
            /// </summary>
            [NameInMap("processInstanceStatus")]
            [Validation(Required=false)]
            public string ProcessInstanceStatus { get; set; }

            /// <summary>
            /// processInstanceStatusText
            /// </summary>
            [NameInMap("processInstanceStatusText")]
            [Validation(Required=false)]
            public string ProcessInstanceStatusText { get; set; }

            /// <summary>
            /// processName
            /// </summary>
            [NameInMap("processName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// title
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// version
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// 当前第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

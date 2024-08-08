// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetProcessInstanceWithExtraResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetProcessInstanceWithExtraResponseBodyResult Result { get; set; }
        public class GetProcessInstanceWithExtraResponseBodyResult : TeaModel {
            [NameInMap("approverUserIds")]
            [Validation(Required=false)]
            public List<string> ApproverUserIds { get; set; }

            [NameInMap("attachedProcessInstanceIds")]
            [Validation(Required=false)]
            public List<string> AttachedProcessInstanceIds { get; set; }

            [NameInMap("bizAction")]
            [Validation(Required=false)]
            public string BizAction { get; set; }

            [NameInMap("bizData")]
            [Validation(Required=false)]
            public string BizData { get; set; }

            [NameInMap("businessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            [NameInMap("ccUserIds")]
            [Validation(Required=false)]
            public List<string> CcUserIds { get; set; }

            /// <summary>
            /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("formComponentValues")]
            [Validation(Required=false)]
            public List<GetProcessInstanceWithExtraResponseBodyResultFormComponentValues> FormComponentValues { get; set; }
            public class GetProcessInstanceWithExtraResponseBodyResultFormComponentValues : TeaModel {
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                [NameInMap("componentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                [NameInMap("extValue")]
                [Validation(Required=false)]
                public string ExtValue { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("mainProcessInstanceId")]
            [Validation(Required=false)]
            public string MainProcessInstanceId { get; set; }

            [NameInMap("operationRecords")]
            [Validation(Required=false)]
            public List<GetProcessInstanceWithExtraResponseBodyResultOperationRecords> OperationRecords { get; set; }
            public class GetProcessInstanceWithExtraResponseBodyResultOperationRecords : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("attachments")]
                [Validation(Required=false)]
                public List<GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments> Attachments { get; set; }
                public class GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments : TeaModel {
                    [NameInMap("fileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    [NameInMap("spaceId")]
                    [Validation(Required=false)]
                    public string SpaceId { get; set; }

                }

                [NameInMap("ccUserIds")]
                [Validation(Required=false)]
                public List<string> CcUserIds { get; set; }

                /// <summary>
                /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("handSignToken")]
                [Validation(Required=false)]
                public string HandSignToken { get; set; }

                [NameInMap("images")]
                [Validation(Required=false)]
                public List<string> Images { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("showName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("originatorDeptId")]
            [Validation(Required=false)]
            public string OriginatorDeptId { get; set; }

            [NameInMap("originatorDeptName")]
            [Validation(Required=false)]
            public string OriginatorDeptName { get; set; }

            [NameInMap("originatorUserId")]
            [Validation(Required=false)]
            public string OriginatorUserId { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tasks")]
            [Validation(Required=false)]
            public List<GetProcessInstanceWithExtraResponseBodyResultTasks> Tasks { get; set; }
            public class GetProcessInstanceWithExtraResponseBodyResultTasks : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
                /// </summary>
                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("mobileUrl")]
                [Validation(Required=false)]
                public string MobileUrl { get; set; }

                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

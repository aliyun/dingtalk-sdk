// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class QueryProcessesWorkItemsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryProcessesWorkItemsResponseBodyData> Data { get; set; }
        public class QueryProcessesWorkItemsResponseBodyData : TeaModel {
            [NameInMap("activityCode")]
            [Validation(Required=false)]
            public string ActivityCode { get; set; }

            [NameInMap("activityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("bizObjectId")]
            [Validation(Required=false)]
            public string BizObjectId { get; set; }

            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("finisher")]
            [Validation(Required=false)]
            public QueryProcessesWorkItemsResponseBodyDataFinisher Finisher { get; set; }
            public class QueryProcessesWorkItemsResponseBodyDataFinisher : TeaModel {
                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("isApproval")]
            [Validation(Required=false)]
            public bool? IsApproval { get; set; }

            [NameInMap("isFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            [NameInMap("participant")]
            [Validation(Required=false)]
            public QueryProcessesWorkItemsResponseBodyDataParticipant Participant { get; set; }
            public class QueryProcessesWorkItemsResponseBodyDataParticipant : TeaModel {
                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("processVersion")]
            [Validation(Required=false)]
            public string ProcessVersion { get; set; }

            [NameInMap("receiptor")]
            [Validation(Required=false)]
            public QueryProcessesWorkItemsResponseBodyDataReceiptor Receiptor { get; set; }
            public class QueryProcessesWorkItemsResponseBodyDataReceiptor : TeaModel {
                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("receiveTimeGMT")]
            [Validation(Required=false)]
            public string ReceiveTimeGMT { get; set; }

            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

            [NameInMap("startTimeGMT")]
            [Validation(Required=false)]
            public string StartTimeGMT { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("workItemId")]
            [Validation(Required=false)]
            public string WorkItemId { get; set; }

            [NameInMap("workItemType")]
            [Validation(Required=false)]
            public string WorkItemType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}

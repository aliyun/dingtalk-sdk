// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class TaskInfoUpdateTaskRequest : TeaModel {
        [NameInMap("attr")]
        [Validation(Required=false)]
        public TaskInfoUpdateTaskRequestAttr Attr { get; set; }
        public class TaskInfoUpdateTaskRequestAttr : TeaModel {
            [NameInMap("listTaskDynamicAttr")]
            [Validation(Required=false)]
            public List<TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr> ListTaskDynamicAttr { get; set; }
            public class TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr : TeaModel {
                [NameInMap("attrCode")]
                [Validation(Required=false)]
                public string AttrCode { get; set; }

                [NameInMap("listAttrOptionsCode")]
                [Validation(Required=false)]
                public List<string> ListAttrOptionsCode { get; set; }

            }

        }

        [NameInMap("canceldelTaskCardId")]
        [Validation(Required=false)]
        public string CanceldelTaskCardId { get; set; }

        [NameInMap("cardDTO")]
        [Validation(Required=false)]
        public TaskInfoUpdateTaskRequestCardDTO CardDTO { get; set; }
        public class TaskInfoUpdateTaskRequestCardDTO : TeaModel {
            [NameInMap("atAccount")]
            [Validation(Required=false)]
            public string AtAccount { get; set; }

            [NameInMap("cardCallbackUrl")]
            [Validation(Required=false)]
            public string CardCallbackUrl { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public object Content { get; set; }

            [NameInMap("isAtAll")]
            [Validation(Required=false)]
            public bool? IsAtAll { get; set; }

            [NameInMap("receiverAccount")]
            [Validation(Required=false)]
            public string ReceiverAccount { get; set; }

        }

        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public TaskInfoUpdateTaskRequestDetailUrl DetailUrl { get; set; }
        public class TaskInfoUpdateTaskRequestDetailUrl : TeaModel {
            [NameInMap("appUrl")]
            [Validation(Required=false)]
            public string AppUrl { get; set; }

            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

        }

        [NameInMap("finishTaskCardId")]
        [Validation(Required=false)]
        public string FinishTaskCardId { get; set; }

        [NameInMap("listOpenConversationId")]
        [Validation(Required=false)]
        public List<string> ListOpenConversationId { get; set; }

        [NameInMap("operateType")]
        [Validation(Required=false)]
        public int? OperateType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorAccount")]
        [Validation(Required=false)]
        public string OperatorAccount { get; set; }

        [NameInMap("outTaskId")]
        [Validation(Required=false)]
        public string OutTaskId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("projId")]
        [Validation(Required=false)]
        public string ProjId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("secretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        [NameInMap("sendMsgFlag")]
        [Validation(Required=false)]
        public int? SendMsgFlag { get; set; }

        [NameInMap("startTaskCardId")]
        [Validation(Required=false)]
        public string StartTaskCardId { get; set; }

        [NameInMap("taskContent")]
        [Validation(Required=false)]
        public string TaskContent { get; set; }

        [NameInMap("taskEndTime")]
        [Validation(Required=false)]
        public long? TaskEndTime { get; set; }

        [NameInMap("taskExecutePersonDTOS")]
        [Validation(Required=false)]
        public List<TaskInfoUpdateTaskRequestTaskExecutePersonDTOS> TaskExecutePersonDTOS { get; set; }
        public class TaskInfoUpdateTaskRequestTaskExecutePersonDTOS : TeaModel {
            [NameInMap("employeeCode")]
            [Validation(Required=false)]
            public string EmployeeCode { get; set; }

            [NameInMap("personType")]
            [Validation(Required=false)]
            public int? PersonType { get; set; }

        }

        [NameInMap("taskTitle")]
        [Validation(Required=false)]
        public string TaskTitle { get; set; }

        [NameInMap("taskUrlMobile")]
        [Validation(Required=false)]
        public string TaskUrlMobile { get; set; }

        [NameInMap("taskUrlPc")]
        [Validation(Required=false)]
        public string TaskUrlPc { get; set; }

        [NameInMap("updateTaskCardId")]
        [Validation(Required=false)]
        public string UpdateTaskCardId { get; set; }

    }

}

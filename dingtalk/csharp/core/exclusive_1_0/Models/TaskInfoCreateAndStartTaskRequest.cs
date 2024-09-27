// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class TaskInfoCreateAndStartTaskRequest : TeaModel {
        [NameInMap("attr")]
        [Validation(Required=false)]
        public TaskInfoCreateAndStartTaskRequestAttr Attr { get; set; }
        public class TaskInfoCreateAndStartTaskRequestAttr : TeaModel {
            [NameInMap("listTaskDynamicAttr")]
            [Validation(Required=false)]
            public List<TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr> ListTaskDynamicAttr { get; set; }
            public class TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr : TeaModel {
                [NameInMap("attrCode")]
                [Validation(Required=false)]
                public string AttrCode { get; set; }

                [NameInMap("listAttrOptionsCode")]
                [Validation(Required=false)]
                public List<string> ListAttrOptionsCode { get; set; }

            }

        }

        [NameInMap("backlogDTO")]
        [Validation(Required=false)]
        public TaskInfoCreateAndStartTaskRequestBacklogDTO BacklogDTO { get; set; }
        public class TaskInfoCreateAndStartTaskRequestBacklogDTO : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public TaskInfoCreateAndStartTaskRequestBacklogDTOContent Content { get; set; }
            public class TaskInfoCreateAndStartTaskRequestBacklogDTOContent : TeaModel {
                [NameInMap("isOnlyShowExecutor")]
                [Validation(Required=false)]
                public bool? IsOnlyShowExecutor { get; set; }

                [NameInMap("priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

        }

        [NameInMap("backlogGenerateFlag")]
        [Validation(Required=false)]
        public int? BacklogGenerateFlag { get; set; }

        [NameInMap("businessCode")]
        [Validation(Required=false)]
        public string BusinessCode { get; set; }

        [NameInMap("canceldelTaskCardId")]
        [Validation(Required=false)]
        public string CanceldelTaskCardId { get; set; }

        [NameInMap("cardDTO")]
        [Validation(Required=false)]
        public TaskInfoCreateAndStartTaskRequestCardDTO CardDTO { get; set; }
        public class TaskInfoCreateAndStartTaskRequestCardDTO : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("customFlag")]
        [Validation(Required=false)]
        public int? CustomFlag { get; set; }

        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public TaskInfoCreateAndStartTaskRequestDetailUrl DetailUrl { get; set; }
        public class TaskInfoCreateAndStartTaskRequestDetailUrl : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorAccount")]
        [Validation(Required=false)]
        public string OperatorAccount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("outTaskId")]
        [Validation(Required=false)]
        public string OutTaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("projId")]
        [Validation(Required=false)]
        public string ProjId { get; set; }

        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("secretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        [NameInMap("sendMsgFlag")]
        [Validation(Required=false)]
        public int? SendMsgFlag { get; set; }

        [NameInMap("sort")]
        [Validation(Required=false)]
        public int? Sort { get; set; }

        [NameInMap("startTaskCardId")]
        [Validation(Required=false)]
        public string StartTaskCardId { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public int? State { get; set; }

        [NameInMap("taskContent")]
        [Validation(Required=false)]
        public string TaskContent { get; set; }

        [NameInMap("taskEndTime")]
        [Validation(Required=false)]
        public long? TaskEndTime { get; set; }

        [NameInMap("taskExecutePersonDTOS")]
        [Validation(Required=false)]
        public List<TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS> TaskExecutePersonDTOS { get; set; }
        public class TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS : TeaModel {
            [NameInMap("employeeCode")]
            [Validation(Required=false)]
            public string EmployeeCode { get; set; }

            [NameInMap("personType")]
            [Validation(Required=false)]
            public int? PersonType { get; set; }

        }

        [NameInMap("taskGroupDTOList")]
        [Validation(Required=false)]
        public List<TaskInfoCreateAndStartTaskRequestTaskGroupDTOList> TaskGroupDTOList { get; set; }
        public class TaskInfoCreateAndStartTaskRequestTaskGroupDTOList : TeaModel {
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskSystem")]
        [Validation(Required=false)]
        public string TaskSystem { get; set; }

        [NameInMap("taskTemplCode")]
        [Validation(Required=false)]
        public string TaskTemplCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskTitle")]
        [Validation(Required=false)]
        public string TaskTitle { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

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

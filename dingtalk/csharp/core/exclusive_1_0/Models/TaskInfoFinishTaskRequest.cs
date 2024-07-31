// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class TaskInfoFinishTaskRequest : TeaModel {
        [NameInMap("cardDTO")]
        [Validation(Required=false)]
        public TaskInfoFinishTaskRequestCardDTO CardDTO { get; set; }
        public class TaskInfoFinishTaskRequestCardDTO : TeaModel {
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

        [NameInMap("taskExecutePersonDTOS")]
        [Validation(Required=false)]
        public List<TaskInfoFinishTaskRequestTaskExecutePersonDTOS> TaskExecutePersonDTOS { get; set; }
        public class TaskInfoFinishTaskRequestTaskExecutePersonDTOS : TeaModel {
            [NameInMap("employeeCode")]
            [Validation(Required=false)]
            public string EmployeeCode { get; set; }

            [NameInMap("personType")]
            [Validation(Required=false)]
            public int? PersonType { get; set; }

        }

    }

}

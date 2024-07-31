// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class TaskInfoAddDelTaskPersonRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operateType")]
        [Validation(Required=false)]
        public int? OperateType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorAccount")]
        [Validation(Required=false)]
        public string OperatorAccount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskExecutePersonDTOS")]
        [Validation(Required=false)]
        public List<TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS> TaskExecutePersonDTOS { get; set; }
        public class TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS : TeaModel {
            [NameInMap("employeeCode")]
            [Validation(Required=false)]
            public string EmployeeCode { get; set; }

            [NameInMap("personType")]
            [Validation(Required=false)]
            public int? PersonType { get; set; }

        }

    }

}

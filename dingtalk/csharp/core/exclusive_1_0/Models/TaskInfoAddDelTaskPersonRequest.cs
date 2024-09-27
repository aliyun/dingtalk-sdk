// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class TaskInfoAddDelTaskPersonRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operateType")]
        [Validation(Required=false)]
        public int? OperateType { get; set; }

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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("secretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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

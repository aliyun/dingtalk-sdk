// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class TerminateProcessInstanceRequest : TeaModel {
        /// <summary>
        /// 是否通过系统操作：
        /// 
        /// true：由系统直接终止
        /// 
        /// false：由指定的操作者终止
        /// </summary>
        [NameInMap("isSystem")]
        [Validation(Required=false)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// 操作人的userid。
        /// 
        /// 当is_system为false时，该参数必传。
        /// </summary>
        [NameInMap("operatingUserId")]
        [Validation(Required=false)]
        public string OperatingUserId { get; set; }

        /// <summary>
        /// 审批实例ID，可通过调用获取审批实例ID列表接口获取。
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 终止说明。
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

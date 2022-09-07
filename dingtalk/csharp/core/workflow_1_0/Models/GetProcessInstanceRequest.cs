// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetProcessInstanceRequest : TeaModel {
        /// <summary>
        /// 审批实例ID企业内部应用可通过获取审批实例ID列表接口获取。钉钉三方企业应用可以通过推送的审批事件中获取，参考biz_type=22。
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}

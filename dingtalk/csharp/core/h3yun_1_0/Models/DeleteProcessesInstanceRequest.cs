// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class DeleteProcessesInstanceRequest : TeaModel {
        /// <summary>
        /// 删除成功后，是否需要更新业务表单关联的流程实例id
        /// </summary>
        [NameInMap("isAutoUpdateBizObject")]
        [Validation(Required=false)]
        public bool? IsAutoUpdateBizObject { get; set; }

        /// <summary>
        /// 流程实例id
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class DeleteProcessRequest : TeaModel {
        /// <summary>
        /// 是否清理正在运行的任务
        /// </summary>
        [NameInMap("cleanRunningTask")]
        [Validation(Required=false)]
        public bool? CleanRunningTask { get; set; }

        /// <summary>
        /// 模板code
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

    }

}

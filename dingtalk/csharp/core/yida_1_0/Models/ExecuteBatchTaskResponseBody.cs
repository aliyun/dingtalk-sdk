// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ExecuteBatchTaskResponseBody : TeaModel {
        /// <summary>
        /// 审批失败的任务数
        /// </summary>
        [NameInMap("failNumber")]
        [Validation(Required=false)]
        public int? FailNumber { get; set; }

        /// <summary>
        /// 审批成功的任务数
        /// </summary>
        [NameInMap("successNumber")]
        [Validation(Required=false)]
        public int? SuccessNumber { get; set; }

        /// <summary>
        /// 总任务数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

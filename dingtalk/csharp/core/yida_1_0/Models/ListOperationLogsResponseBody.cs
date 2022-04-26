// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListOperationLogsResponseBody : TeaModel {
        /// <summary>
        /// 操作记录对象
        /// </summary>
        [NameInMap("operationLogMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> OperationLogMap { get; set; }

    }

}

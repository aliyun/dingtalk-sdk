// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class GetExecuteUrlRequest : TeaModel {
        [NameInMap("account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        [NameInMap("signContainer")]
        [Validation(Required=false)]
        public int? SignContainer { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class ListProgressByIdsRequest : TeaModel {
        /// <summary>
        /// 进展ID列表
        /// </summary>
        [NameInMap("progressIds")]
        [Validation(Required=false)]
        public List<string> ProgressIds { get; set; }

    }

}

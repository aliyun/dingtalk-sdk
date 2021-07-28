// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryClassScheduleConfigRequest : TeaModel {
        /// <summary>
        /// 课程id列表
        /// </summary>
        [NameInMap("classIds")]
        [Validation(Required=false)]
        public List<long?> ClassIds { get; set; }

        /// <summary>
        /// 操作者的UserID
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}

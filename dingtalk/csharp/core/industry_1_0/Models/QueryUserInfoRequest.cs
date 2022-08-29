// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserInfoRequest : TeaModel {
        /// <summary>
        /// 按月标记。不填默认当月。填0为次月。
        /// </summary>
        [NameInMap("monthMark")]
        [Validation(Required=false)]
        public string MonthMark { get; set; }

    }

}

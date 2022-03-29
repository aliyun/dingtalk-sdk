// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models
{
    public class WriteIsvStateRequest : TeaModel {
        /// <summary>
        /// ISV名称
        /// </summary>
        [NameInMap("isvName")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// 数据完成日期
        /// </summary>
        [NameInMap("statDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

    }

}

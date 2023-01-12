// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class AppendRowsRequest : TeaModel {
        /// <summary>
        /// 要追加的值(二维数组)
        /// 最大size:
        /// 	1000
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<List<string>> Values { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

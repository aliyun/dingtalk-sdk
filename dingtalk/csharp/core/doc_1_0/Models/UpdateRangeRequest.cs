// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class UpdateRangeRequest : TeaModel {
        /// <summary>
        /// 背景色
        /// </summary>
        [NameInMap("backgroundColors")]
        [Validation(Required=false)]
        public List<List<string>> BackgroundColors { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<List<string>> Values { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SetColumnsVisibilityRequest : TeaModel {
        /// <summary>
        /// 要显示、隐藏的第一列的位置，从0开始。
        /// </summary>
        [NameInMap("column")]
        [Validation(Required=false)]
        public long? Column { get; set; }

        /// <summary>
        /// 要显示、隐藏的列的数量。
        /// </summary>
        [NameInMap("columnCount")]
        [Validation(Required=false)]
        public long? ColumnCount { get; set; }

        /// <summary>
        /// 列可见性
        /// 枚举值:
        /// 	visible: 可见
        /// 	hidden: 隐藏
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

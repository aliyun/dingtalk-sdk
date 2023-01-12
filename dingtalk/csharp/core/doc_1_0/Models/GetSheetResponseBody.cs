// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetSheetResponseBody : TeaModel {
        /// <summary>
        /// 工作表列数。
        /// </summary>
        [NameInMap("columnCount")]
        [Validation(Required=false)]
        public long? ColumnCount { get; set; }

        /// <summary>
        /// 工作表id
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 最后一列非空列的位置，从0开始，表为空时返回-1。
        /// </summary>
        [NameInMap("lastNonEmptyColumn")]
        [Validation(Required=false)]
        public long? LastNonEmptyColumn { get; set; }

        /// <summary>
        /// 最后一行非空行的位置，从0开始，表为空时返回-1。
        /// </summary>
        [NameInMap("lastNonEmptyRow")]
        [Validation(Required=false)]
        public long? LastNonEmptyRow { get; set; }

        /// <summary>
        /// 工作表名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 工作表行数。
        /// </summary>
        [NameInMap("rowCount")]
        [Validation(Required=false)]
        public long? RowCount { get; set; }

        /// <summary>
        /// 工作表可见性
        /// 枚举值:
        ///    visible: 可见
        ///    hidden: 隐藏
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}

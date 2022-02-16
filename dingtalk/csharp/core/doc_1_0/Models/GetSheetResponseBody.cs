// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetSheetResponseBody : TeaModel {
        /// <summary>
        /// 最后一列非空列的位置，从0开始。表为空时返回-1。
        /// </summary>
        [NameInMap("lastNonEmptyColumn")]
        [Validation(Required=false)]
        public long? LastNonEmptyColumn { get; set; }

        /// <summary>
        /// 最后一行非空行的位置，从0开始。表为空时返回-1。
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
        /// 工作表可见性
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}

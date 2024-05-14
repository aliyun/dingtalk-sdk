// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SheetAutofitRowsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fontWidth")]
        [Validation(Required=false)]
        public long? FontWidth { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("row")]
        [Validation(Required=false)]
        public long? Row { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("rowCount")]
        [Validation(Required=false)]
        public long? RowCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

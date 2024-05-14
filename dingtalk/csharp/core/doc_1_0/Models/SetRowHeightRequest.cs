// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SetRowHeightRequest : TeaModel {
        [NameInMap("height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("row")]
        [Validation(Required=false)]
        public int? Row { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

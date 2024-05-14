// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class DocContentRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public DocContentRequestOption Option { get; set; }
        public class DocContentRequestOption : TeaModel {
            [NameInMap("targetFormat")]
            [Validation(Required=false)]
            public string TargetFormat { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

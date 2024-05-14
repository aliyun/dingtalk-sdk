// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class InitDocumentRequest : TeaModel {
        [NameInMap("attachmentsMap")]
        [Validation(Required=false)]
        public Dictionary<string, AttachmentsMapValue> AttachmentsMap { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("importType")]
        [Validation(Required=false)]
        public int? ImportType { get; set; }

        [NameInMap("linksKey")]
        [Validation(Required=false)]
        public string LinksKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}

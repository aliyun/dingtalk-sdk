// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfContentRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public Stream Content { get; set; }

        [NameInMap("updateQuoteList")]
        [Validation(Required=false)]
        public List<Stream> UpdateQuoteList { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("krId")]
        [Validation(Required=false)]
        public Stream KrId { get; set; }

        [NameInMap("operatorUid")]
        [Validation(Required=false)]
        public Stream OperatorUid { get; set; }

    }

}

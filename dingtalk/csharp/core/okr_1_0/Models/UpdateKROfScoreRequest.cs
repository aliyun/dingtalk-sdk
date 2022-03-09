// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfScoreRequest : TeaModel {
        [NameInMap("score")]
        [Validation(Required=false)]
        public long? Score { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("krId")]
        [Validation(Required=false)]
        public Stream KrId { get; set; }

        [NameInMap("ownerId")]
        [Validation(Required=false)]
        public Stream OwnerId { get; set; }

    }

}

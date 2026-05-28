// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktre_1_0.Models
{
    public class CreateTicketResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateTicketResponseBodyData Data { get; set; }
        public class CreateTicketResponseBodyData : TeaModel {
            [NameInMap("ticketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

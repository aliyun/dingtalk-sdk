// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktre_1_0.Models
{
    public class CreateTicketRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("reporters")]
        [Validation(Required=false)]
        public List<CreateTicketRequestReporters> Reporters { get; set; }
        public class CreateTicketRequestReporters : TeaModel {
            [NameInMap("carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("screenshots")]
            [Validation(Required=false)]
            public List<string> Screenshots { get; set; }

            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}

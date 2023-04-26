// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateVideoConferenceResponseBody : TeaModel {
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("conferencePassword")]
        [Validation(Required=false)]
        public string ConferencePassword { get; set; }

        [NameInMap("externalLinkUrl")]
        [Validation(Required=false)]
        public string ExternalLinkUrl { get; set; }

        [NameInMap("hostPassword")]
        [Validation(Required=false)]
        public string HostPassword { get; set; }

        [NameInMap("phoneNumbers")]
        [Validation(Required=false)]
        public List<string> PhoneNumbers { get; set; }

        [NameInMap("roomCode")]
        [Validation(Required=false)]
        public string RoomCode { get; set; }

    }

}

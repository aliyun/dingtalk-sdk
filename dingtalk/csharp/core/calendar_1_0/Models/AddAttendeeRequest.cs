// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class AddAttendeeRequest : TeaModel {
        [NameInMap("attendeesToAdd")]
        [Validation(Required=false)]
        public List<AddAttendeeRequestAttendeesToAdd> AttendeesToAdd { get; set; }
        public class AddAttendeeRequestAttendeesToAdd : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

    }

}

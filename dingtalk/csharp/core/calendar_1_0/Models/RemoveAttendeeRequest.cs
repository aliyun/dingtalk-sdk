// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class RemoveAttendeeRequest : TeaModel {
        [NameInMap("attendeesToRemove")]
        [Validation(Required=false)]
        public List<RemoveAttendeeRequestAttendeesToRemove> AttendeesToRemove { get; set; }
        public class RemoveAttendeeRequestAttendeesToRemove : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}

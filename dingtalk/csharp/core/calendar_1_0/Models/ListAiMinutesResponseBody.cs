// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListAiMinutesResponseBody : TeaModel {
        [NameInMap("minutes")]
        [Validation(Required=false)]
        public List<ListAiMinutesResponseBodyMinutes> Minutes { get; set; }
        public class ListAiMinutesResponseBodyMinutes : TeaModel {
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("minutesId")]
            [Validation(Required=false)]
            public string MinutesId { get; set; }

        }

    }

}

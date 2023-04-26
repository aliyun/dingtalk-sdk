// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetSubscribedCalendarResponseBody : TeaModel {
        [NameInMap("author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        [NameInMap("calendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("managers")]
        [Validation(Required=false)]
        public List<string> Managers { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("subscribeScope")]
        [Validation(Required=false)]
        public GetSubscribedCalendarResponseBodySubscribeScope SubscribeScope { get; set; }
        public class GetSubscribedCalendarResponseBodySubscribeScope : TeaModel {
            [NameInMap("corpIds")]
            [Validation(Required=false)]
            public List<string> CorpIds { get; set; }

            [NameInMap("openConversationIds")]
            [Validation(Required=false)]
            public List<string> OpenConversationIds { get; set; }

            [NameInMap("unionIds")]
            [Validation(Required=false)]
            public List<string> UnionIds { get; set; }

        }

    }

}

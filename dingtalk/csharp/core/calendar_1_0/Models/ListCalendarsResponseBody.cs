// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListCalendarsResponseBody : TeaModel {
        /// <summary>
        /// 日历信息
        /// </summary>
        [NameInMap("response")]
        [Validation(Required=false)]
        public ListCalendarsResponseBodyResponse Response { get; set; }
        public class ListCalendarsResponseBodyResponse : TeaModel {
            [NameInMap("calendars")]
            [Validation(Required=false)]
            public List<ListCalendarsResponseBodyResponseCalendars> Calendars { get; set; }
            public class ListCalendarsResponseBodyResponseCalendars : TeaModel {
                public string Id { get; set; }
                public string Summary { get; set; }
                public string Description { get; set; }
                public string TimeZone { get; set; }
                public string ETag { get; set; }
                public string Type { get; set; }
                public string Privilege { get; set; }
            }
        };

    }

}

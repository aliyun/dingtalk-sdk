// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListCalendarsResponseBody : TeaModel {
        [NameInMap("response")]
        [Validation(Required=false)]
        public ListCalendarsResponseBodyResponse Response { get; set; }
        public class ListCalendarsResponseBodyResponse : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("calendars")]
            [Validation(Required=false)]
            public List<ListCalendarsResponseBodyResponseCalendars> Calendars { get; set; }
            public class ListCalendarsResponseBodyResponseCalendars : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("eTag")]
                [Validation(Required=false)]
                public string ETag { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("privilege")]
                [Validation(Required=false)]
                public string Privilege { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}

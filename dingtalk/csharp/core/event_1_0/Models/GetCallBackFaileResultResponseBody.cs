// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkevent_1_0.Models
{
    public class GetCallBackFaileResultResponseBody : TeaModel {
        [NameInMap("failedList")]
        [Validation(Required=false)]
        public List<GetCallBackFaileResultResponseBodyFailedList> FailedList { get; set; }
        public class GetCallBackFaileResultResponseBodyFailedList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;CalendarEventUpdateTime&quot;:1668735924619,&quot;CorpId&quot;:&quot;ding9<b>cd16741&quot;,&quot;ChangeType&quot;:&quot;updated&quot;,&quot;EventType&quot;:&quot;calendar_event_change&quot;,&quot;CalendarId&quot;:&quot;NzE3MjU0NEB1c2V</b><em>5jb218MTQwMDE2&quot;,&quot;EventTime&quot;:1668735924640,&quot;LegacyCalendarEventId&quot;:&quot;1C1BB56076</em><b>8A338&quot;,&quot;BizId&quot;:&quot;1668</b>4640&quot;,&quot;CalendarEventId&quot;:&quot;RVNUZllHK<b>elEydz09&quot;,&quot;operator&quot;:{&quot;type&quot;:&quot;user&quot;},&quot;UnionIdList&quot;:[&quot;QQa</b>mYiE&quot;]}</para>
            /// </summary>
            [NameInMap("callBackData")]
            [Validation(Required=false)]
            public string CallBackData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>calendar_event_change</para>
            /// </summary>
            [NameInMap("callBackTag")]
            [Validation(Required=false)]
            public string CallBackTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding9f50b15b*****41</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>166***39184</para>
            /// </summary>
            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

    }

}

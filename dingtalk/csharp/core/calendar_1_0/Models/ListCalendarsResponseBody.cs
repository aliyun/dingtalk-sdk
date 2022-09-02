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
                /// <summary>
                /// 日历描述
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Calendar资源的ETag，用于检测该Calendar以及内部的Event是否有被更新
                /// </summary>
                [NameInMap("eTag")]
                [Validation(Required=false)]
                public string ETag { get; set; }

                /// <summary>
                /// 日历id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 权限信息
                /// </summary>
                [NameInMap("privilege")]
                [Validation(Required=false)]
                public string Privilege { get; set; }

                /// <summary>
                /// 日历标题
                /// </summary>
                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// 时区
                /// </summary>
                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

                /// <summary>
                /// 日历类型
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}

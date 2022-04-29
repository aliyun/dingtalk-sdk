// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetSubscribedCalendarResponseBody : TeaModel {
        /// <summary>
        /// 日历作者
        /// </summary>
        [NameInMap("author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        /// <summary>
        /// 订阅日历id
        /// </summary>
        [NameInMap("calendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        /// <summary>
        /// 日历描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 可管理人群
        /// </summary>
        [NameInMap("managers")]
        [Validation(Required=false)]
        public List<string> Managers { get; set; }

        /// <summary>
        /// 日历名
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 可订阅范围
        /// </summary>
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
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class UpdateSubscribedCalendarsRequest : TeaModel {
        /// <summary>
        /// 日历介绍
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 日历管理员列表
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
        /// 可订阅列表
        /// </summary>
        [NameInMap("subscribeScope")]
        [Validation(Required=false)]
        public UpdateSubscribedCalendarsRequestSubscribeScope SubscribeScope { get; set; }
        public class UpdateSubscribedCalendarsRequestSubscribeScope : TeaModel {
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class CreateSubscribedCalendarRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("managers")]
        [Validation(Required=false)]
        public List<string> Managers { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subscribeScope")]
        [Validation(Required=false)]
        public CreateSubscribedCalendarRequestSubscribeScope SubscribeScope { get; set; }
        public class CreateSubscribedCalendarRequestSubscribeScope : TeaModel {
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

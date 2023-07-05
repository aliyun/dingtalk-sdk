// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_activities_1_0.Models
{
    public class SendLiveActivityRequest : TeaModel {
        [NameInMap("activityEventData")]
        [Validation(Required=false)]
        public SendLiveActivityRequestActivityEventData ActivityEventData { get; set; }
        public class SendLiveActivityRequestActivityEventData : TeaModel {
            [NameInMap("i18nContentState")]
            [Validation(Required=false)]
            public object I18nContentState { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("activityEventOption")]
        [Validation(Required=false)]
        public SendLiveActivityRequestActivityEventOption ActivityEventOption { get; set; }
        public class SendLiveActivityRequestActivityEventOption : TeaModel {
            [NameInMap("dismissalDate")]
            [Validation(Required=false)]
            public long? DismissalDate { get; set; }

            [NameInMap("pushType")]
            [Validation(Required=false)]
            public string PushType { get; set; }

            [NameInMap("sendDate")]
            [Validation(Required=false)]
            public long? SendDate { get; set; }

            [NameInMap("staleDate")]
            [Validation(Required=false)]
            public long? StaleDate { get; set; }

        }

        [NameInMap("activityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

    }

}

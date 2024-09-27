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

            /// <summary>
            /// <b>Example:</b>
            /// <para>ride_with_alibtrip</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("activityEventOption")]
        [Validation(Required=false)]
        public SendLiveActivityRequestActivityEventOption ActivityEventOption { get; set; }
        public class SendLiveActivityRequestActivityEventOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1686903998</para>
            /// </summary>
            [NameInMap("dismissalDate")]
            [Validation(Required=false)]
            public long? DismissalDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>update</para>
            /// </summary>
            [NameInMap("pushType")]
            [Validation(Required=false)]
            public string PushType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1686903998</para>
            /// </summary>
            [NameInMap("sendDate")]
            [Validation(Required=false)]
            public long? SendDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1686903998</para>
            /// </summary>
            [NameInMap("staleDate")]
            [Validation(Required=false)]
            public long? StaleDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bizUniqueId</para>
        /// </summary>
        [NameInMap("activityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

    }

}

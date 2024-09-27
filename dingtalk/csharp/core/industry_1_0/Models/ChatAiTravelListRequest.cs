// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatAiTravelListRequest : TeaModel {
        [NameInMap("paramList")]
        [Validation(Required=false)]
        public List<ChatAiTravelListRequestParamList> ParamList { get; set; }
        public class ChatAiTravelListRequestParamList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>qaz1234567</para>
            /// </summary>
            [NameInMap("itineraryId")]
            [Validation(Required=false)]
            public string ItineraryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;lineNumber&quot;:1}</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qaz12345900</para>
        /// </summary>
        [NameInMap("travelId")]
        [Validation(Required=false)]
        public string TravelId { get; set; }

    }

}

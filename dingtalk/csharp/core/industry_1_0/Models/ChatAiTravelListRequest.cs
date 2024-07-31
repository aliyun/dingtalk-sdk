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
            [NameInMap("itineraryId")]
            [Validation(Required=false)]
            public string ItineraryId { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("travelId")]
        [Validation(Required=false)]
        public string TravelId { get; set; }

    }

}

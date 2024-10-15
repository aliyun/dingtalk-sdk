// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetGroupLiveListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetGroupLiveListResponseBodyResult Result { get; set; }
        public class GetGroupLiveListResponseBodyResult : TeaModel {
            [NameInMap("groupLiveList")]
            [Validation(Required=false)]
            public List<GetGroupLiveListResponseBodyResultGroupLiveList> GroupLiveList { get; set; }
            public class GetGroupLiveListResponseBodyResultGroupLiveList : TeaModel {
                [NameInMap("anchorNickname")]
                [Validation(Required=false)]
                public string AnchorNickname { get; set; }

                [NameInMap("anchorUnionId")]
                [Validation(Required=false)]
                public string AnchorUnionId { get; set; }

                [NameInMap("liveEndTime")]
                [Validation(Required=false)]
                public long? LiveEndTime { get; set; }

                [NameInMap("liveStartTime")]
                [Validation(Required=false)]
                public long? LiveStartTime { get; set; }

                [NameInMap("liveUuid")]
                [Validation(Required=false)]
                public string LiveUuid { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetUserStayLengthResponseBody : TeaModel {
        [NameInMap("itemList")]
        [Validation(Required=false)]
        public List<GetUserStayLengthResponseBodyItemList> ItemList { get; set; }
        public class GetUserStayLengthResponseBodyItemList : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("statDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

            [NameInMap("stayTimeLenApp1d")]
            [Validation(Required=false)]
            public long? StayTimeLenApp1d { get; set; }

            [NameInMap("stayTimeLenPc1d")]
            [Validation(Required=false)]
            public long? StayTimeLenPc1d { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

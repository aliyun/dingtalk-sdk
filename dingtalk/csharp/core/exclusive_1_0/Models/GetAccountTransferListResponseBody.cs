// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetAccountTransferListResponseBody : TeaModel {
        [NameInMap("itemList")]
        [Validation(Required=false)]
        public List<GetAccountTransferListResponseBodyItemList> ItemList { get; set; }
        public class GetAccountTransferListResponseBodyItemList : TeaModel {
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public long? DeptName { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

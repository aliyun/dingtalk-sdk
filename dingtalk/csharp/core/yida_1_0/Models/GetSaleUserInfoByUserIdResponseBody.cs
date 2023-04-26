// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetSaleUserInfoByUserIdResponseBody : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        [NameInMap("corpList")]
        [Validation(Required=false)]
        public List<GetSaleUserInfoByUserIdResponseBodyCorpList> CorpList { get; set; }
        public class GetSaleUserInfoByUserIdResponseBodyCorpList : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_global_e_c_1_0.Models
{
    public class GetLoginUserResponseBody : TeaModel {
        [NameInMap("commodityInfo")]
        [Validation(Required=false)]
        public GetLoginUserResponseBodyCommodityInfo CommodityInfo { get; set; }
        public class GetLoginUserResponseBodyCommodityInfo : TeaModel {
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("openId")]
        [Validation(Required=false)]
        public string OpenId { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

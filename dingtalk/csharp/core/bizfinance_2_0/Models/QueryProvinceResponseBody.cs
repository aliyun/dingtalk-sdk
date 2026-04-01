// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryProvinceResponseBody : TeaModel {
        [NameInMap("provinces")]
        [Validation(Required=false)]
        public List<QueryProvinceResponseBodyProvinces> Provinces { get; set; }
        public class QueryProvinceResponseBodyProvinces : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}

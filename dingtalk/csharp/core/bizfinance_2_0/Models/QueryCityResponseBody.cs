// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryCityResponseBody : TeaModel {
        [NameInMap("citys")]
        [Validation(Required=false)]
        public List<QueryCityResponseBodyCitys> Citys { get; set; }
        public class QueryCityResponseBodyCitys : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}

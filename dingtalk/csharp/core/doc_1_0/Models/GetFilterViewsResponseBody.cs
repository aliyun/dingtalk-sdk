// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetFilterViewsResponseBody : TeaModel {
        [NameInMap("filterViews")]
        [Validation(Required=false)]
        public List<GetFilterViewsResponseBodyFilterViews> FilterViews { get; set; }
        public class GetFilterViewsResponseBodyFilterViews : TeaModel {
            [NameInMap("criteria")]
            [Validation(Required=false)]
            public Dictionary<string, FilterViewsCriteriaValue> Criteria { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("range")]
            [Validation(Required=false)]
            public string Range { get; set; }

        }

    }

}

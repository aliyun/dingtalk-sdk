// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class UpdateDentryAppPropertiesRequest : TeaModel {
        [NameInMap("appProperties")]
        [Validation(Required=false)]
        public List<UpdateDentryAppPropertiesRequestAppProperties> AppProperties { get; set; }
        public class UpdateDentryAppPropertiesRequestAppProperties : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

        }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}

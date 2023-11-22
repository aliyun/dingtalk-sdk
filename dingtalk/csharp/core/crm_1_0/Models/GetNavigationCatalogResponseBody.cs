// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetNavigationCatalogResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetNavigationCatalogResponseBodyResult Result { get; set; }
        public class GetNavigationCatalogResponseBodyResult : TeaModel {
            [NameInMap("bizTraceId")]
            [Validation(Required=false)]
            public string BizTraceId { get; set; }

            [NameInMap("module")]
            [Validation(Required=false)]
            public string Module { get; set; }

            [NameInMap("navCatalog")]
            [Validation(Required=false)]
            public List<GetNavigationCatalogResponseBodyResultNavCatalog> NavCatalog { get; set; }
            public class GetNavigationCatalogResponseBodyResultNavCatalog : TeaModel {
                [NameInMap("children")]
                [Validation(Required=false)]
                public object Children { get; set; }

                [NameInMap("navCode")]
                [Validation(Required=false)]
                public string NavCode { get; set; }

                [NameInMap("navId")]
                [Validation(Required=false)]
                public string NavId { get; set; }

                [NameInMap("navName")]
                [Validation(Required=false)]
                public string NavName { get; set; }

                [NameInMap("navType")]
                [Validation(Required=false)]
                public string NavType { get; set; }

            }

        }

    }

}

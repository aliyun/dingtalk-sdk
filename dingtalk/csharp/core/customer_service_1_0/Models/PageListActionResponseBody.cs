// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class PageListActionResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<PageListActionResponseBodyList> List { get; set; }
        public class PageListActionResponseBodyList : TeaModel {
            [NameInMap("actionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            [NameInMap("actionContent")]
            [Validation(Required=false)]
            public List<PageListActionResponseBodyListActionContent> ActionContent { get; set; }
            public class PageListActionResponseBodyListActionContent : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("displayValue")]
                [Validation(Required=false)]
                public string DisplayValue { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("valueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("operatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            [NameInMap("operatorRole")]
            [Validation(Required=false)]
            public string OperatorRole { get; set; }

        }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

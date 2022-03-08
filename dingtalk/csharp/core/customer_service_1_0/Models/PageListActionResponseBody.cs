// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class PageListActionResponseBody : TeaModel {
        /// <summary>
        /// list
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<PageListActionResponseBodyList> List { get; set; }
        public class PageListActionResponseBodyList : TeaModel {
            /// <summary>
            /// actionCode
            /// </summary>
            [NameInMap("actionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            /// <summary>
            /// actionContent
            /// </summary>
            [NameInMap("actionContent")]
            [Validation(Required=false)]
            public List<PageListActionResponseBodyListActionContent> ActionContent { get; set; }
            public class PageListActionResponseBodyListActionContent : TeaModel {
                /// <summary>
                /// displayName
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// displayValue
                /// </summary>
                [NameInMap("displayValue")]
                [Validation(Required=false)]
                public string DisplayValue { get; set; }

                /// <summary>
                /// name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// value
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// valueType
                /// </summary>
                [NameInMap("valueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

            /// <summary>
            /// operator
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// operatorId
            /// </summary>
            [NameInMap("operatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            /// <summary>
            /// operatorRole
            /// </summary>
            [NameInMap("operatorRole")]
            [Validation(Required=false)]
            public string OperatorRole { get; set; }

        }

        /// <summary>
        /// nextCursor
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// total
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

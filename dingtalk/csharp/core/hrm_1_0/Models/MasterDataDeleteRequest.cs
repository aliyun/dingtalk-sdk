// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataDeleteRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<MasterDataDeleteRequestBody> Body { get; set; }
        public class MasterDataDeleteRequestBody : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("bizTime")]
            [Validation(Required=false)]
            public long? BizTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("bizUk")]
            [Validation(Required=false)]
            public string BizUk { get; set; }

            [NameInMap("entityCode")]
            [Validation(Required=false)]
            public string EntityCode { get; set; }

            [NameInMap("fieldList")]
            [Validation(Required=false)]
            public List<MasterDataDeleteRequestBodyFieldList> FieldList { get; set; }
            public class MasterDataDeleteRequestBodyFieldList : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("valueStr")]
                [Validation(Required=false)]
                public string ValueStr { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public MasterDataDeleteRequestBodyScope Scope { get; set; }
            public class MasterDataDeleteRequestBodyScope : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("scopeCode")]
                [Validation(Required=false)]
                public string ScopeCode { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}

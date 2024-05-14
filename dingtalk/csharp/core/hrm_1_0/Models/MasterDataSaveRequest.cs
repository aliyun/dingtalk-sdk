// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataSaveRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<MasterDataSaveRequestBody> Body { get; set; }
        public class MasterDataSaveRequestBody : TeaModel {
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fieldList")]
            [Validation(Required=false)]
            public List<MasterDataSaveRequestBodyFieldList> FieldList { get; set; }
            public class MasterDataSaveRequestBodyFieldList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("valueStr")]
                [Validation(Required=false)]
                public string ValueStr { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public MasterDataSaveRequestBodyScope Scope { get; set; }
            public class MasterDataSaveRequestBodyScope : TeaModel {
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}

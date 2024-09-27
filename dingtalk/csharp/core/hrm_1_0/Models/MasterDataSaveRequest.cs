// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataSaveRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<MasterDataSaveRequestBody> Body { get; set; }
        public class MasterDataSaveRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12312</para>
            /// </summary>
            [NameInMap("bizTime")]
            [Validation(Required=false)]
            public long? BizTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uk123</para>
            /// </summary>
            [NameInMap("bizUk")]
            [Validation(Required=false)]
            public string BizUk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>base</para>
            /// </summary>
            [NameInMap("entityCode")]
            [Validation(Required=false)]
            public string EntityCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fieldList")]
            [Validation(Required=false)]
            public List<MasterDataSaveRequestBodyFieldList> FieldList { get; set; }
            public class MasterDataSaveRequestBodyFieldList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("valueStr")]
                [Validation(Required=false)]
                public string ValueStr { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public MasterDataSaveRequestBodyScope Scope { get; set; }
            public class MasterDataSaveRequestBodyScope : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>performance</para>
                /// </summary>
                [NameInMap("scopeCode")]
                [Validation(Required=false)]
                public string ScopeCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user123</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}

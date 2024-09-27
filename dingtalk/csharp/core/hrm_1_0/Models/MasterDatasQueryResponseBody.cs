// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDatasQueryResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<MasterDatasQueryResponseBodyResult> Result { get; set; }
        public class MasterDatasQueryResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>uk123123</para>
            /// </summary>
            [NameInMap("objId")]
            [Validation(Required=false)]
            public string ObjId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admind123</para>
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PERFORMANCE</para>
            /// </summary>
            [NameInMap("scopeCode")]
            [Validation(Required=false)]
            public string ScopeCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>base</para>
            /// </summary>
            [NameInMap("viewEntityCode")]
            [Validation(Required=false)]
            public string ViewEntityCode { get; set; }

            [NameInMap("viewEntityFieldVOList")]
            [Validation(Required=false)]
            public List<MasterDatasQueryResponseBodyResultViewEntityFieldVOList> ViewEntityFieldVOList { get; set; }
            public class MasterDatasQueryResponseBodyResultViewEntityFieldVOList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>performanceValue</para>
                /// </summary>
                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("fieldDataVO")]
                [Validation(Required=false)]
                public MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO FieldDataVO { get; set; }
                public class MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>绩效等级</para>
                /// </summary>
                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

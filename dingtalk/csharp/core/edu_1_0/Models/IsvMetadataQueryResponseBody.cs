// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class IsvMetadataQueryResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public IsvMetadataQueryResponseBodyResult Result { get; set; }
        public class IsvMetadataQueryResponseBodyResult : TeaModel {
            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<IsvMetadataQueryResponseBodyResultFields> Fields { get; set; }
            public class IsvMetadataQueryResponseBodyResultFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>该字段为id主键</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("fieldKey")]
                [Validation(Required=false)]
                public string FieldKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>id主键</para>
                /// </summary>
                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>varchar</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("primaryKey")]
                [Validation(Required=false)]
                public bool? PrimaryKey { get; set; }

                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tb_test01</para>
            /// </summary>
            [NameInMap("tableCode")]
            [Validation(Required=false)]
            public string TableCode { get; set; }

            [NameInMap("tableExist")]
            [Validation(Required=false)]
            public bool? TableExist { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

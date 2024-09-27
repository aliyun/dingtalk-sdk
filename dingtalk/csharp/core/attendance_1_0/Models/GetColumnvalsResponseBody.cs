// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetColumnvalsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetColumnvalsResponseBodyResult> Result { get; set; }
        public class GetColumnvalsResponseBodyResult : TeaModel {
            [NameInMap("columnData")]
            [Validation(Required=false)]
            public List<GetColumnvalsResponseBodyResultColumnData> ColumnData { get; set; }
            public class GetColumnvalsResponseBodyResultColumnData : TeaModel {
                [NameInMap("columnValues")]
                [Validation(Required=false)]
                public List<GetColumnvalsResponseBodyResultColumnDataColumnValues> ColumnValues { get; set; }
                public class GetColumnvalsResponseBodyResultColumnDataColumnValues : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1709222400000</para>
                    /// </summary>
                    [NameInMap("date")]
                    [Validation(Required=false)]
                    public long? Date { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fixedValue")]
                [Validation(Required=false)]
                public string FixedValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>129339038</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

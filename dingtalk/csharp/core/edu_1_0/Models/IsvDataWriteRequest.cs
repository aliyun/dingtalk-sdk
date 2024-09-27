// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class IsvDataWriteRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>tb_test01</para>
        /// </summary>
        [NameInMap("objectCode")]
        [Validation(Required=false)]
        public string ObjectCode { get; set; }

        [NameInMap("rowValueList")]
        [Validation(Required=false)]
        public List<List<IsvDataWriteRequestRowValueList>> RowValueList { get; set; }
        public class IsvDataWriteRequestRowValueList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

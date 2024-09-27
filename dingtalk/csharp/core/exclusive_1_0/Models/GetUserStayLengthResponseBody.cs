// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetUserStayLengthResponseBody : TeaModel {
        [NameInMap("itemList")]
        [Validation(Required=false)]
        public List<GetUserStayLengthResponseBodyItemList> ItemList { get; set; }
        public class GetUserStayLengthResponseBodyItemList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>小张</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20220501</para>
            /// </summary>
            [NameInMap("statDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("stayTimeLenApp1d")]
            [Validation(Required=false)]
            public long? StayTimeLenApp1d { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("stayTimeLenPc1d")]
            [Validation(Required=false)]
            public long? StayTimeLenPc1d { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123***</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

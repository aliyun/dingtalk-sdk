// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetAccountTransferListResponseBody : TeaModel {
        [NameInMap("itemList")]
        [Validation(Required=false)]
        public List<GetAccountTransferListResponseBodyItemList> ItemList { get; set; }
        public class GetAccountTransferListResponseBodyItemList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>财务部</para>
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public long? DeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小张</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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

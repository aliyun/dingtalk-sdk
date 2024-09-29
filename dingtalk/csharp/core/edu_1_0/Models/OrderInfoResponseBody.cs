// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class OrderInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public OrderInfoResponseBodyResult Result { get; set; }
        public class OrderInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx店铺</para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("itemList")]
            [Validation(Required=false)]
            public List<OrderInfoResponseBodyResultItemList> ItemList { get; set; }
            public class OrderInfoResponseBodyResultItemList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商品名称</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("itemNum")]
                [Validation(Required=false)]
                public string ItemNum { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>808324521</para>
            /// </summary>
            [NameInMap("orderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7245</para>
            /// </summary>
            [NameInMap("receiverPhoneSuffix")]
            [Validation(Required=false)]
            public string ReceiverPhoneSuffix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>商家名称</para>
            /// </summary>
            [NameInMap("shopName")]
            [Validation(Required=false)]
            public string ShopName { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

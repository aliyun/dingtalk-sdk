// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SendPrintOrderNoticeMsgRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("createOrderTime")]
        [Validation(Required=false)]
        public string CreateOrderTime { get; set; }

        [NameInMap("deliveryCompanyName")]
        [Validation(Required=false)]
        public string DeliveryCompanyName { get; set; }

        [NameInMap("deliveryNumber")]
        [Validation(Required=false)]
        public string DeliveryNumber { get; set; }

        [NameInMap("deliveryTime")]
        [Validation(Required=false)]
        public string DeliveryTime { get; set; }

        [NameInMap("paymentTime")]
        [Validation(Required=false)]
        public string PaymentTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public string Price { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

    }

}

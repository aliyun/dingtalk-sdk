// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncInvoiceEntityRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding89233847892ndkas</para>
        /// </summary>
        [NameInMap("channelCorpId")]
        [Validation(Required=false)]
        public string ChannelCorpId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("delAll")]
        [Validation(Required=false)]
        public bool? DelAll { get; set; }

        [NameInMap("entityList")]
        [Validation(Required=false)]
        public List<SyncInvoiceEntityRequestEntityList> EntityList { get; set; }
        public class SyncInvoiceEntityRequestEntityList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("entityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("invoiceId")]
        [Validation(Required=false)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20881001829000</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

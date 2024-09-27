// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class CreateCustomerResponseBody : TeaModel {
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<CreateCustomerResponseBodyContacts> Contacts { get; set; }
        public class CreateCustomerResponseBodyContacts : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>contact_id</para>
            /// </summary>
            [NameInMap("contactInstanceId")]
            [Validation(Required=false)]
            public string ContactInstanceId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer_id</para>
        /// </summary>
        [NameInMap("customerInstanceId")]
        [Validation(Required=false)]
        public string CustomerInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>crm_customer</para>
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

    }

}

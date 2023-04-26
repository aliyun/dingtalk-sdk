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
            [NameInMap("contactInstanceId")]
            [Validation(Required=false)]
            public string ContactInstanceId { get; set; }

        }

        [NameInMap("customerInstanceId")]
        [Validation(Required=false)]
        public string CustomerInstanceId { get; set; }

        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

    }

}

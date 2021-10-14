// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class CreateCustomerResponseBody : TeaModel {
        /// <summary>
        /// 联系人保存结果
        /// </summary>
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<CreateCustomerResponseBodyContacts> Contacts { get; set; }
        public class CreateCustomerResponseBodyContacts : TeaModel {
            /// <summary>
            /// 联系人实例id
            /// </summary>
            [NameInMap("contactInstanceId")]
            [Validation(Required=false)]
            public string ContactInstanceId { get; set; }

        }

        /// <summary>
        /// 客户实例id
        /// </summary>
        [NameInMap("customerInstanceId")]
        [Validation(Required=false)]
        public string CustomerInstanceId { get; set; }

        /// <summary>
        /// 保存客户类型
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

    }

}

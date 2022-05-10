// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreUsersRequest : TeaModel {
        /// <summary>
        /// 门店通通讯录Cod
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 节点Id
        /// </summary>
        [NameInMap("nodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

    }

}

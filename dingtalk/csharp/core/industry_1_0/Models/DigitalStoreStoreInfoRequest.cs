// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreStoreInfoRequest : TeaModel {
        /// <summary>
        /// 门店通通讯录Code
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 门店Id
        /// </summary>
        [NameInMap("storeId")]
        [Validation(Required=false)]
        public long? StoreId { get; set; }

    }

}
